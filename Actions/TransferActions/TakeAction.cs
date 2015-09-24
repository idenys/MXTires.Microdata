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
    /// The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.
    /// Related actions:
    /// <see cref="GiveAction"/>: Reciprocal of TakeAction
    /// <see cref="ReceiveAction"/>: Unlike ReceiveAction, TakeAction implies that ownership has been transfered
    /// </summary>
    public class TakeAction : TransferAction
    {
    }
}
