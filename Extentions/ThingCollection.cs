using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Extentions
{
    static class ThingCollection
    {
        /// <summary>
        /// If you had an IEnumerable called blogPosts you can then ToJsonLdList() to generate the JSON for the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="things">enumeration of things</param>
        /// <param name="addScriptTag">Optional - set <code>True</code> to add the outer 'script' tag</param>
        /// <returns>LD-JSON representation on <see cref="Thing"/> collection as a string </returns>
        /// <remarks>
        /// Contributed by Dan Booth
        /// </remarks>
        public static string ToJsonLdList<T>(this IEnumerable<T> things, bool addScriptTag = false) where T : Thing
        {
            if (things == null || !things.Any())
                return null;

            int total = things.Count();
            int cnt = 0;

            StringBuilder json = new StringBuilder();

            if (addScriptTag)
                json.AppendLine("<script type=\"application/ld+json\">");

            json.AppendLine("[");

            foreach (var thing in things)
            {
                json.AppendLine(thing.ToString());

                if (++cnt < total)
                {
                    json.AppendLine(",");
                }
            }

            if (addScriptTag)
                json.AppendLine("</script>");

            json.AppendLine("]");

            return json.ToString();
        }
    }
}
