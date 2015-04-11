#region License
// Copyright (c) 2015 1010Tires.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;
using System.Collections.Generic;
using MXTires.Microdata.Attributes;
using MXTires.Microdata.Validators;
namespace MXTires.Microdata
{
    public class Event : Thing
    {
        Thing attendee;
        /// <summary>
        /// Organization  or Person - A person or organization attending the event. Supersedes attendees.
        /// </summary>
        [JsonProperty("attendee")]
        [TypeValidation(typeof(Organization), typeof(Person))]
        public Thing Attendee
        {
            get { return attendee; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(attendee);
                attendee = value;
            }
        }

        /// <summary>
        /// DateTime - The time admission will commence.
        /// </summary>
        [JsonProperty("doorTime")]
        public string DoorTime { get; set; }

        /// <summary>
        /// Duration - The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// Date - The end date and time of the item (in ISO 8601 date format).
        /// </summary>
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// EventStatusType - An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        [JsonProperty("eventStatus")]
        public EventStatusType EventStatus { get; set; }

        /// <summary>
        /// PostalAddress  or Place - The location of the event, organization or action.
        /// </summary>
        [JsonProperty("location")]
        public Thing Location { get; set; }

        /// <summary>
        /// Offer - An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        [JsonProperty("offers")]
        public IList<Offer> Offers { get; set; }

        /// <summary>
        /// Organization  or Person - An organizer of an Event.
        /// </summary>
        [JsonProperty("organizer")]
        public Thing Organizer { get; set; }

        /// <summary>
        /// Organization  or Person 	A performer at the event—for example, a presenter, musician, musical group or actor. Supersedes performers.
        /// </summary>
        [JsonProperty("performer")]
        public Thing Performer { get; set; }

        /// <summary>
        /// Date  - Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        [JsonProperty("previousStartDate")]
        public Thing PreviousStartDate { get; set; }

        /// <summary>
        /// CreativeWork - The CreativeWork that captured all or part of this Event. Inverse property: recordedAt.
        /// </summary>
        [JsonProperty("recordedIn")]
        public CreativeWork RecordedIn { get; set; }

        /// <summary>
        /// Date - The start date and time of the item (in ISO 8601 date format).
        /// </summary>
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// Event -	An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference. Supersedes subEvents.
        /// </summary>
        [JsonProperty("subEvent")]
        public Event SubEvent { get; set; }

        /// <summary>
        /// Event -	An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        [JsonProperty("superEvent")]
        public Event SuperEvent { get; set; }

        /// <summary>
        /// Text  - The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [JsonProperty("typicalAgeRange")]
        public string TypicalAgeRange { get; set; }

        /// <summary>
        /// CreativeWork - A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        [JsonProperty("workPerformed")]
        public CreativeWork WorkPerformed { get; set; }
    }
}
