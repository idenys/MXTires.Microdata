using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// A list of possible product availability options.
    /// </summary>
    [Flags]
    public enum ItemAvailability 
    {
        /// <summary>
        /// The discontinued
        /// </summary>
        [EnumMember(Value = "http://schema.org/Discontinued")]
        Discontinued = 1,

        /// <summary>
        /// The in stock
        /// </summary>
        [EnumMember(Value = "http://schema.org/InStock")]
        InStock = 2,

        /// <summary>
        /// The in store only
        /// </summary>
        [EnumMember(Value = "http://schema.org/InStoreOnly")]
        InStoreOnly = 4,

        /// <summary>
        /// The limited availability
        /// </summary>
        [EnumMember(Value = "http://schema.org/LimitedAvailability")]
        LimitedAvailability = 8,

        /// <summary>
        /// The online only
        /// </summary>
        [EnumMember(Value = "http://schema.org/OnlineOnly")]
        OnlineOnly = 16,

        /// <summary>
        /// The out of stock
        /// </summary>
        [EnumMember(Value = "http://schema.org/OutOfStock")]
        OutOfStock = 32,

        /// <summary>
        /// The pre order
        /// </summary>
        [EnumMember(Value = "http://schema.org/PreOrder")]
        PreOrder = 64,

        /// <summary>
        /// The sold out
        /// </summary>
        [EnumMember(Value = "http://schema.org/SoldOut")]
        SoldOut = 128 
    }
}
