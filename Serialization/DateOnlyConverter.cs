using Newtonsoft.Json.Converters;

namespace MXTires.Microdata.Serialization
{
    /// <summary>
    /// Writes a <see cref="System.DateTime"/> as a schema.org Date (yyyy-MM-dd), without time or time zone.
    /// </summary>
    public class DateOnlyConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateOnlyConverter"/> class.
        /// </summary>
        public DateOnlyConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
