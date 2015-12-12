using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// A business entity type is a conceptual entity representing the legal form, the size, the main line of business,
    /// the position in the value chain, or any combination thereof, of an organization or business person.
    /// Commonly used values:
    /// http://purl.org/goodrelations/v1#Business
    /// http://purl.org/goodrelations/v1#Enduser
    /// http://purl.org/goodrelations/v1#PublicInstitution
    /// http://purl.org/goodrelations/v1#Reseller
    /// </summary>
    [Flags]
    public enum BusinessEntityType
    {
        /// <summary>
        /// The business
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Business")]
        Business = 1 << 0,

        /// <summary>
        /// The end user
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Enduser")]
        Enduser = 1 << 1,

        /// <summary>
        /// The public institution
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PublicInstitution")]
        PublicInstitution = 1 << 2,

        /// <summary>
        /// The reseller
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Reseller")]
        Reseller = 1 << 3
    }
}
