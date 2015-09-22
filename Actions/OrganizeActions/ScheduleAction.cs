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
    /// Scheduling future actions, events, or tasks.
    /// Related actions:
    /// ReserveAction: Unlike ReserveAction, ScheduleAction allocates future actions (e.g. an event, a task, etc) towards a time slot / spatial allocation
    /// 
    /// </summary>
    public class ScheduleAction : PlanAction
    {
    }
}
