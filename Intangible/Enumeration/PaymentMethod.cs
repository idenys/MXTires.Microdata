using System;
using System.Runtime.Serialization;
namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase. 
    /// Payment methods are characterized by the legal and technical structures used, and by the organization or 
    /// group carrying out the transaction. Commonly used values: 
    /// http://purl.org/goodrelations/v1#ByBankTransferInAdvance 
    /// http://purl.org/goodrelations/v1#ByInvoice 
    /// http://purl.org/goodrelations/v1#Cash 
    /// http://purl.org/goodrelations/v1#CheckInAdvance 
    /// http://purl.org/goodrelations/v1#COD 
    /// http://purl.org/goodrelations/v1#DirectDebit 
    /// http://purl.org/goodrelations/v1#GoogleCheckout 
    /// http://purl.org/goodrelations/v1#PayPal 
    /// http://purl.org/goodrelations/v1#PaySwarm
    /// </summary>
    [Flags]
    public enum PaymentMethod
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByBankTransferInAdvance")]
        ByBankTransferInAdvance = 1 << 0,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByInvoice")]
        ByInvoice = 1 << 1,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#Cash")]
        Cash = 1 << 2,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#CheckInAdvance")]
        CheckInAdvance = 1 << 3,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#COD")]
        Cod = 1 << 4,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#DirectDebit")]
        DirectDebit = 1 << 5,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#GoogleCheckout")]
        GoogleCheckout = 1 << 6,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#PayPal")]
        PayPal = 1 << 7,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#PaySwarm")]
        PaySwarm = 1 << 8,

        [EnumMember(Value = "VisaCheckout")]
        VisaCheckout = 1 << 9,

        /// <summary>
        /// A credit or debit card type as a standardized procedure for transferring the monetary amount for a purchase. 
        /// Commonly used values: http://purl.org/goodrelations/v1#AmericanExpress http://purl.org/goodrelations/v1#DinersClub 
        /// http://purl.org/goodrelations/v1#Discover http://purl.org/goodrelations/v1#JCB 
        /// http://purl.org/goodrelations/v1#MasterCard http://purl.org/goodrelations/v1#VISA
        /// </summary>
        [EnumMember(Value = "http://schema.org/CreditCard")]
        CreditCard = 1 << 10,
    
        [EnumMember(Value = "http://purl.org/goodrelations/v1#AmericanExpress")]
        AmericanExpress= 1 << 11,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#DinersClub")]
        DinersClub= 1 << 12,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#Discover")]
        Discover= 1 << 13,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#JCB")]
        Jcb= 1 << 14,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#MasterCard")]
        MasterCard= 1 << 15,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#VISA")]
        Visa= 1 << 16,

    }
}
