using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible.Enumeration;

namespace MXTires.Microdata
{
    /// <summary>
    /// A map.
    /// </summary>
    public class Map : CreativeWork
    {
        /// <summary>
        /// MapCategoryType - Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        public MapCategoryType mapType {get;set;}
    }
}
