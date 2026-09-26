using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MXTires.Microdata.Serialization
{
    /// <summary>
    /// Serializes the library's enumerations as the URI given by each member's <see cref="EnumMemberAttribute"/>.
    /// A <see cref="FlagsAttribute"/> combination is written as a JSON array of URIs.
    /// Serializing a member without a URI throws, so a bare name or a number never reaches the output.
    /// </summary>
    public class SchemaEnumConverter : JsonConverter
    {
        private static readonly ConcurrentDictionary<Type, EnumMap> Maps = new ConcurrentDictionary<Type, EnumMap>();

        /// <inheritdoc />
        public override bool CanConvert(Type objectType)
        {
            var type = Nullable.GetUnderlyingType(objectType) ?? objectType;
            return type.IsEnum && type.Assembly == typeof(Thing).Assembly;
        }

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            var uris = GetUris((Enum)value);
            if (uris.Count == 1)
            {
                writer.WriteValue(uris[0]);
                return;
            }

            writer.WriteStartArray();
            foreach (var uri in uris)
            {
                writer.WriteValue(uri);
            }
            writer.WriteEndArray();
        }

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var nullableUnderlying = Nullable.GetUnderlyingType(objectType);
            var type = nullableUnderlying ?? objectType;

            if (reader.TokenType == JsonToken.Null)
            {
                if (nullableUnderlying == null)
                {
                    throw new JsonSerializationException($"Cannot convert null to {type.Name}.");
                }
                return null;
            }

            var map = GetMap(type);
            long result = 0;
            if (reader.TokenType == JsonToken.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                {
                    result |= map.Parse(reader.Value as string);
                }
            }
            else
            {
                result = map.Parse(reader.Value as string);
            }

            return Enum.ToObject(type, result);
        }

        /// <summary>
        /// Returns the URIs an enum value serializes to: one for a single member, several for a [Flags] combination.
        /// </summary>
        /// <exception cref="JsonSerializationException">The value, or one of its flags, has no URI.</exception>
        public static IList<string> GetUris(Enum value)
        {
            var map = GetMap(value.GetType());
            var raw = Convert.ToInt64(value, CultureInfo.InvariantCulture);

            var exact = map.Members.FirstOrDefault(m => m.Value == raw);
            if (exact != null)
            {
                return new List<string> { map.UriOf(exact) };
            }

            if (map.IsFlags && raw != 0)
            {
                var selected = map.Members.Where(m => m.Value != 0 && (raw & m.Value) == m.Value).ToList();
                var covered = selected.Aggregate(0L, (acc, m) => acc | m.Value);
                if (covered == raw)
                {
                    return selected.Select(map.UriOf).Distinct().ToList();
                }
            }

            throw new JsonSerializationException($"{map.Type.Name} value {raw} is not a defined member and cannot be serialized to JSON-LD.");
        }

        private static EnumMap GetMap(Type type) => Maps.GetOrAdd(type, t => new EnumMap(t));

        private sealed class EnumMember
        {
            public string Name;
            public long Value;
            public string Uri;
        }

        private sealed class EnumMap
        {
            public readonly Type Type;
            public readonly bool IsFlags;
            public readonly List<EnumMember> Members;

            public EnumMap(Type type)
            {
                Type = type;
                IsFlags = type.IsDefined(typeof(FlagsAttribute), false);
                Members = type.GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Select(f => new EnumMember
                    {
                        Name = f.Name,
                        Value = Convert.ToInt64(f.GetValue(null), CultureInfo.InvariantCulture),
                        Uri = f.GetCustomAttribute<EnumMemberAttribute>()?.Value
                    })
                    .ToList();
            }

            public string UriOf(EnumMember member)
            {
                if (string.IsNullOrEmpty(member.Uri))
                {
                    throw new JsonSerializationException($"{Type.Name}.{member.Name} has no [EnumMember] URI and cannot be serialized to JSON-LD.");
                }
                return member.Uri;
            }

            public long Parse(string text)
            {
                var member = Members.FirstOrDefault(m => m.Uri == text)
                    ?? Members.FirstOrDefault(m => string.Equals(m.Name, text, StringComparison.OrdinalIgnoreCase));
                if (member == null)
                {
                    throw new JsonSerializationException($"'{text}' is not a known {Type.Name} value.");
                }
                return member.Value;
            }
        }
    }
}
