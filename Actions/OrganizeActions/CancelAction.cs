using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.OrganizeActions
{
    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.
    /// Related actions:
    /// ConfirmAction: The antonym of CancelAction
    /// </summary>
    public class CancelAction : PlanAction
    {
    }
}
