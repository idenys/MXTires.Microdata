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
        /// <summary>
        /// The by bank transfer in advance
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByBankTransferInAdvance")]
        ByBankTransferInAdvance = 1 << 0,

        /// <summary>
        /// The by invoice
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByInvoice")]
        ByInvoice = 1 << 1,

        /// <summary>
        /// The cash
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Cash")]
        Cash = 1 << 2,

        /// <summary>
        /// The check in advance
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#CheckInAdvance")]
        CheckInAdvance = 1 << 3,

        /// <summary>
        /// The cod
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#COD")]
        Cod = 1 << 4,

        /// <summary>
        /// The direct debit
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DirectDebit")]
        DirectDebit = 1 << 5,

        /// <summary>
        /// The google checkout
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#GoogleCheckout")]
        GoogleCheckout = 1 << 6,

        /// <summary>
        /// The pay pal
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PayPal")]
        PayPal = 1 << 7,

        /// <summary>
        /// The pay swarm
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PaySwarm")]
        PaySwarm = 1 << 8,

        /// <summary>
        /// The visa checkout
        /// </summary>
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

        /// <summary>
        /// The american express
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#AmericanExpress")]
        AmericanExpress= 1 << 11,

        /// <summary>
        /// The diners club
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DinersClub")]
        DinersClub= 1 << 12,

        /// <summary>
        /// The discover
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Discover")]
        Discover= 1 << 13,

        /// <summary>
        /// The JCB
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#JCB")]
        Jcb= 1 << 14,

        /// <summary>
        /// The master card
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#MasterCard")]
        MasterCard= 1 << 15,

        /// <summary>
        /// The visa
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#VISA")]
        Visa= 1 << 16,

    }
}
