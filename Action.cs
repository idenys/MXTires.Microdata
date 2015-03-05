using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class Action : Thing
    {
        /// <summary>
        /// ActionStatusType - Indicates the current disposition of the Action.
        /// </summary>
        public ActionStatusType ActionStatus { get; set; }

        /// <summary>
        /// Person  or Organization - The direct performer or driver of the action (animate or inanimate). e.g. *John* wrote a book.
        /// </summary>
        public Thing agent { get; set; }

        /// <summary>
        /// DateTime - The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), 
        /// the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. 
        /// John wrote a book from January to *December*. Note that Event uses startDate/endDate instead of startTime/endTime, 
        /// even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        public DateTime? endTime { get; set; }

        /// <summary>
        /// Thing 	For failed actions, more information on the cause of the failure.
        /// </summary>
        public Thing error { get; set; }

        /// <summary>
        ///  Thing 	The object that helped the agent perform the action. e.g. John wrote a book with *a pen*.
        /// </summary>
        public Thing instrument { get; set; }

        /// <summary>
        /// PostalAddress  or Place - The location of the event, organization or action.
        /// </summary>
        public Thing location { get; set; }

        /// <summary>
        /// Thing - The object upon the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read *a book*.
        /// </summary>
        [JsonProperty("object")]
        public Thing ActionObject { get; set; }
        /// <summary>
        /// Person  or  Organization - Other co-agents that participated in the action indirectly. e.g. John wrote a book with *Steve*.
        /// </summary>
        public Thing participant { get; set; }
        /// <summary>
        /// Thing 	The result produced in the action. e.g. John wrote *a book*.
        /// </summary>
        public Thing result { get; set; }
        /// <summary>
        /// DateTime -The startTime of something. 
        /// For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. 
        /// For actions that span a period of time, when the action was performed. e.g. John wrote a book from *January* to December. 
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. 
        /// This situation may be clarified in future revisions.
        /// </summary>
        public DateTime? startTime { get; set; }

        /// <summary>
        ///EntryPoint 	Indicates a target EntryPoint for an Action.
        /// </summary>
        [JsonProperty("target")]
        public EntryPoint Target { get; set; }
    }
}