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
    /// The act of registering to an organization/service without the guarantee to receive it.
    /// Related actions:
    /// <see cref="RegisterAction"/>: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted
    /// </summary>
    public class ApplyAction : Action
    {
    }
}
