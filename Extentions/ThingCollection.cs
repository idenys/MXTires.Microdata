#region License
// Copyright (c) 2016 1010Tires.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System.Collections.Generic;
using System.Linq;
using System.Text;

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
