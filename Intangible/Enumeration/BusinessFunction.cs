using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the
    /// organization or business person through the offer. Typical are sell, rental or lease, maintenance or
    /// repair, manufacture / produce, recycle / dispose, engineering / construction, or installation.
    /// Proprietary specifications of access rights are also instances of this class.
    /// Commonly used values:
    /// http://purl.org/goodrelations/v1#ConstructionInstallation
    /// http://purl.org/goodrelations/v1#Dispose
    /// http://purl.org/goodrelations/v1#LeaseOut
    /// http://purl.org/goodrelations/v1#Maintain
    /// http://purl.org/goodrelations/v1#ProvideService
    /// http://purl.org/goodrelations/v1#Repair
    /// http://purl.org/goodrelations/v1#Sell
    /// http://purl.org/goodrelations/v1#Buy
    /// </summary>
    [Flags]
    public enum BusinessFunction
    {
        /// <summary>
        /// The construction installation
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ConstructionInstallation")]
        ConstructionInstallation = 1 << 0,
        /// <summary>
        /// The dispose
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Dispose")]
        Dispose = 1 << 1,
        /// <summary>
        /// The lease out
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#LeaseOut")]
        LeaseOut = 1 << 2,
        /// <summary>
        /// The maintain
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Maintain")]
        Maintain = 1 << 3,
        /// <summary>
        /// The provide service
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ProvideService")]
        ProvideService = 1 << 4,
        /// <summary>
        /// The repair
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Repair")]
        Repair = 1 << 5,
        /// <summary>
        /// The sell
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Sell")]
        Sell = 1 << 6,
        /// <summary>
        /// The buy
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Buy")]
        Buy = 1 << 7
    }
}
