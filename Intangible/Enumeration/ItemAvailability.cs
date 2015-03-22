using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MXTires.Microdata
{
    /// <summary>
    /// A list of possible product availability options.
    /// </summary>
    [Flags]
    public enum ItemAvailability 
    {
        [EnumMember(Value = "http://schema.org/Discontinued")]
        Discontinued = 1,

        [EnumMember(Value = "http://schema.org/InStock")]
        InStock = 2,

        [EnumMember(Value = "http://schema.org/InStoreOnly")]
        InStoreOnly = 4,

        [EnumMember(Value = "http://schema.org/LimitedAvailability")]
        LimitedAvailability = 8,

        [EnumMember(Value = "http://schema.org/OnlineOnly")]
        OnlineOnly = 16,

        [EnumMember(Value = "http://schema.org/OutOfStock")]
        OutOfStock = 32,

        [EnumMember(Value = "http://schema.org/PreOrder")]
        PreOrder = 64,

        [EnumMember(Value = "http://schema.org/SoldOut")]
        SoldOut = 128 
    }
}
