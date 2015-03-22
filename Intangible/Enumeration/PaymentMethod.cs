using System;
using System.Runtime.Serialization;
namespace MXTires.Microdata
{
    /// <summary>
    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction. Commonly used values: http://purl.org/goodrelations/v1#ByBankTransferInAdvance http://purl.org/goodrelations/v1#ByInvoice http://purl.org/goodrelations/v1#Cash http://purl.org/goodrelations/v1#CheckInAdvance http://purl.org/goodrelations/v1#COD http://purl.org/goodrelations/v1#DirectDebit http://purl.org/goodrelations/v1#GoogleCheckout http://purl.org/goodrelations/v1#PayPal http://purl.org/goodrelations/v1#PaySwarm
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

        VisaCheckout = 1 << 9,

    }
}
