using MXTires.Microdata.Intengible;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata
{
    /// <summary>
    /// A list of items of any sort—for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. 
    /// Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
    public class ItemList : Thing
    {
        /// <summary>
        /// Thing  or ListItem  or Text - For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.
        /// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists. 
        /// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements. Use ListItem with a 'position' property in such cases.
        /// </summary>
        public ListItem itemListElement { get; set; }
        /// <summary>
        /// ItemListOrderType  or Text - Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        public string itemListOrder { get; set; }
        /// <summary>
        /// Number - The number of items in an ItemList. Note that some descriptions might not full describe all items in a list (e.g. multi-page pagination).
        /// </summary>
        public string numberOfItems { get; set; }
    }
}
