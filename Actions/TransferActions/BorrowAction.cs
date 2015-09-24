using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TransferActions
{
    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.
    /// Related actions:
    /// <see cref="LendAction"/>: Reciprocal of BorrowAction
    /// </summary>
    public class BorrowAction : TransferAction
    {
        /// <summary>
        /// Person - A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        [JsonProperty("lender")]
        public Person Lender { get; set; }
    }
}
