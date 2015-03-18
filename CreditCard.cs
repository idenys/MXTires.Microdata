using System;
using System.Runtime.Serialization;

namespace MXTires.Microdata
{
    /// <summary>
    /// A credit or debit card type as a standardized procedure for transferring the monetary amount for a purchase. 
    /// Commonly used values: http://purl.org/goodrelations/v1#AmericanExpress http://purl.org/goodrelations/v1#DinersClub 
    /// http://purl.org/goodrelations/v1#Discover http://purl.org/goodrelations/v1#JCB 
    /// http://purl.org/goodrelations/v1#MasterCard http://purl.org/goodrelations/v1#VISA
    /// </summary>
    [Flags]
    public enum CreditCard
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#AmericanExpress")]
        AmericanExpress,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#DinersClub")]
        DinersClub,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#Discover")]
        Discover,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#JCB")]
        Jcb,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#MasterCard")]
        MasterCard,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#VISA")]
        Visa,
    }
}