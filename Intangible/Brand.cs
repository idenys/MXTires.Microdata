using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    public class Brand : Thing
    {
        /// <summary>
        /// An associated logo.
        /// </summary>
        public string Logo { get; set; }
    }
}
