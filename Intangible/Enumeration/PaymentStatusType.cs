using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        PaymentAutomaticallyApplied = 1 << 0,
        /// <summary>
        /// The payment has been received and processed.
        /// </summary>
        PaymentComplete = 1 << 1,
        /// <summary>
        /// The payee received the payment, but it was declined for some reason.
        /// </summary>
        PaymentDeclined = 1 << 2,
        /// <summary>
        /// The payment is due, but still within an acceptable time to be received.
        /// </summary>
        PaymentDue = 1 << 3,
        /// <summary>
        /// The payment is due and considered late.
        /// </summary>
        PaymentPastDue = 1 << 4,
    }
}