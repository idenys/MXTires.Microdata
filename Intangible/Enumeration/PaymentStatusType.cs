using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// </summary>
    public enum PaymentStatusType
    {
        /// <summary>
        /// An automatic payment system is in place and will be used.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentAutomaticallyApplied")]
        PaymentAutomaticallyApplied = 1 << 0,
        /// <summary>
        /// The payment has been received and processed.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentComplete")]
        PaymentComplete = 1 << 1,
        /// <summary>
        /// The payee received the payment, but it was declined for some reason.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentDeclined")]
        PaymentDeclined = 1 << 2,
        /// <summary>
        /// The payment is due, but still within an acceptable time to be received.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentDue")]
        PaymentDue = 1 << 3,
        /// <summary>
        /// The payment is due and considered late.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentPastDue")]
        PaymentPastDue = 1 << 4,
    }
}