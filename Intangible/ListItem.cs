#region License
// Copyright (c) 2017 1010Tires.com
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    public class ListItem : Thing
    {
        /// <summary>
        /// Thing - An entity represented by an entry in a list (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [JsonProperty("item")]
        public Thing Item { get; set; }

        /// <summary>
        /// ListItem - A link to the ListItem that follows the current one.
        /// </summary>
        [JsonProperty("nextItem")]
        public ListItem NextItem { get; set; }

        /// <summary>
        /// Integer or Text - The position of an item in a series or sequence of items.
        /// </summary>
        [JsonProperty("position")]
        public Int32? Position { get; set; }

        /// <summary>
        /// ListItem - A link to the ListItem that preceeds the current one.
        /// </summary>
        [JsonProperty("previousItem")]
        public ListItem PreviousItem { get; set; }
    }
}
