using System.Runtime.Serialization;
namespace MXTires.Microdata
{
    /// <summary>
    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction. Commonly used values: http://purl.org/goodrelations/v1#ByBankTransferInAdvance http://purl.org/goodrelations/v1#ByInvoice http://purl.org/goodrelations/v1#Cash http://purl.org/goodrelations/v1#CheckInAdvance http://purl.org/goodrelations/v1#COD http://purl.org/goodrelations/v1#DirectDebit http://purl.org/goodrelations/v1#GoogleCheckout http://purl.org/goodrelations/v1#PayPal http://purl.org/goodrelations/v1#PaySwarm
    /// </summary>
    public enum PaymentMethod
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByBankTransferInAdvance")]
        ByBankTransferInAdvance,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#ByInvoice")]
        ByInvoice,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#Cash")]
        Cash,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#CheckInAdvance")]
        CheckInAdvance,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#COD")]
        COD,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#DirectDebit")]
        DirectDebit,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#GoogleCheckout")]
        GoogleCheckout,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#PayPal")]
        PayPal,

        [EnumMember(Value = "http://purl.org/goodrelations/v1#PaySwarm")]
        PaySwarm
    }
}
