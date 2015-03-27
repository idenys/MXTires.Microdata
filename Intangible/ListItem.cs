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
        public Int32 Position { get; set; }

        /// <summary>
        /// ListItem - A link to the ListItem that preceeds the current one.
        /// </summary>
        [JsonProperty("previousItem")]
        public ListItem PreviousItem { get; set; }
    }
}
