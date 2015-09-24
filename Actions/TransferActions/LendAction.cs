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
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.
    /// Related actions:
    /// <see cref="BorrowAction"/>: Reciprocal of BorrowAction
    /// </summary>
    public class LendAction : TransferAction
    {
        /// <summary>
        /// Person - A sub property of participant. The person that borrows the object being lent.
        /// </summary>
        [JsonProperty("borrower")]
        public Person Borrower { get; set; }
    }
}
