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
using MXTires.Microdata.Intangible.Quantities;
using System;
namespace MXTires.Microdata
{
    /// <summary>
    /// Class Event.
    /// </summary>
    public class Event : Thing
    {
        /// <summary>
        /// Thing - The subject matter of the content.
        /// </summary>
        [JsonProperty("about")]
        public Thing About { get; set; }

        /// <summary>
        /// Person - An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip. Supersedes  <see cref="Actors"/>.
        /// </summary>
        /// <value>The attendee.</value>
        [JsonProperty("actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// Collection of <see cref="Actor"/>
        /// </summary>
        [JsonProperty("actors")]
        public IList<Person> Actors { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }
        
        /// <summary>
        /// The attendee
        /// </summary>
        Thing attendee;
        /// <summary>
        /// Organization or Person - A person or organization attending the event. Supersedes <see cref="attendees"/>.
        /// </summary>
        /// <value>The attendee.</value>
        [JsonProperty("attendee")]
        [TypeValidation(typeof(Organization), typeof(Person))]
        public Thing Attendee
        {
            get { return attendee; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                attendee = value;
            }
        }

        /// <summary>
        /// Collection of Organization or Person. Superseded by <see cref="attendee"/>.
        /// </summary>
        /// <value>The attendee.</value>
        [JsonProperty("attendees")]
        public IList<object> Attendees { get; set; }

        /// <summary>
        /// Audience - An intended audience, i.e.a group for whom something was created. Supersedes <see cref="ServiceAudience"/> .
        /// </summary>
        [JsonProperty("audience")] 
        public Audience Audience { get; set; }

        /// <summary>
        /// Superseeded by <see cref="Audience"/>
        /// </summary>
        [JsonProperty("serviceAudience")]
        public IList<Audience> ServiceAudience { get; set; }

        Thing composer;
        /// <summary>
        /// Organization or Person - The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [JsonProperty("composer")]
        [TypeValidation(typeof(Organization), typeof(Person))]
        public Thing Composer
        {
            get { return composer; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                composer = value;
            }
        }

        Thing contributor;
        /// <summary>
        /// Organization or Person - A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [JsonProperty("contributor")]
        [TypeValidation(typeof(Organization), typeof(Person))]
        public Thing Contributor
        {
            get { return contributor; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                contributor = value;
            }
        }

        /// <summary>
        /// Person - A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. 
        /// Directors can be associated with individual items or with a series, episode, clip. Supersedes directors.
        /// </summary>
        [JsonProperty("director")]
        public Person Director { get; set; }

        /// <summary>
        /// Superseeded by <see cref="Director"/>
        /// </summary>
        [JsonProperty("directors")]
        public IList<Person> Directors { get; set; }

        /// <summary>
        /// DateTime - The time admission will commence.
        /// </summary>
        /// <value>The door time.</value>
        [JsonProperty("doorTime")]
        public string DoorTime { get; set; }

        /// <summary>
        /// Duration - The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        /// <value>The duration.</value>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// Date - The end date and time of the item (in ISO 8601 date format).
        /// </summary>
        /// <value>The end date.</value>
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// EventAttendanceModeEnumeration - The eventAttendanceMode of an event indicates whether it occurs online, offline, or a mix.
        /// </summary>
        [JsonProperty("eventAttendanceMode")]
        public EventAttendanceModeEnumeration EventAttendanceMode { get; set; }

        /// <summary>
        /// Schedule - Associates an Event with a Schedule.
        /// There are circumstances where it is preferable to share a schedule for a series of repeating events rather than data on the individual events themselves.
        /// For example, a website or application might prefer to publish a schedule for a weekly gym class rather than provide data on every event. 
        /// A schedule could be processed by applications to add forthcoming events to a calendar. 
        /// An Event that is associated with a Schedule using this property should not have startDate or endDate properties. 
        /// These are instead defined within the associated Schedule, this avoids any ambiguity for clients using the data.
        /// The property might have repeated values to specify different schedules, e.g. for different months or seasons.
        /// </summary>
        [JsonProperty("eventSchedule")]
        public Schedule EventSchedule { get; set; }
        
        Thing funder;
        /// <summary>
        /// Organization  or Person - A person or organization that supports (<see cref="Sponsors"/>) something through some kind of financial contribution.
        /// </summary>
        [JsonProperty("funder")]
        public Thing Funder
        {
            get { return this.funder; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                this.funder = value;
            }
        }

        object inLanguage;
        /// <summary>
        /// Language  or Text - The language of the content or performance or used in an action. Please use one of the language codes from the IETF BCP 47 standard. Supersedes language.
        /// </summary>
        [JsonProperty("inLanguage")]
        public object InLanguage
        {
            get { return inLanguage; }
            set
            {
                var validator = new TypeValidator(typeof(Language), typeof(string));
                validator.Validate(value);
                inLanguage = value;
            }
        }

        /// <summary>
        /// EventStatusType - An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        /// <value>The event status.</value>
        [JsonProperty("eventStatus")]
        public EventStatusType? EventStatus { get; set; }       
            
        /// <summary>
        /// The location
        /// </summary>
        Thing location;
        /// <summary>
        /// PostalAddress  or Place - The location of the event, organization or action.
        /// </summary>
        /// <value>The location.</value>
        [JsonProperty("location")]
        public Thing Location
        {
            get { return location; }
            set
            {
                var validator = new TypeValidator(typeof(PostalAddress), typeof(Place));
                validator.Validate(value);
                location = value;
            }
        }

        /// <summary>
        /// Integer - The total number of individuals that may attend an event or venue.
        /// </summary>
        [JsonProperty("maximumAttendeeCapacity")]
        public int? MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// Integer - The maximum physical attendee capacity of an Event whose eventAttendanceMode is OfflineEventAttendanceMode(or the offline aspects, in the case of a MixedEventAttendanceMode).
        /// </summary>
        [JsonProperty("maximumPhysicalAttendeeCapacity")]
        public int? MaximumPhysicalAttendeeCapacity { get; set; }

        /// <summary>
        ///  Integer - The maximum physical attendee capacity of an Event whose eventAttendanceMode is OnlineEventAttendanceMode(or the online aspects, in the case of a MixedEventAttendanceMode).
        /// </summary>
        [JsonProperty("maximumVirtualAttendeeCapacity")]
        public int? MaximumVirtualAttendeeCapacity { get; set; }
       
        /// <summary>
        /// Offer - An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        /// <value>The offers.</value>
        [JsonProperty("offers")]
        public IList<Offer> Offers { get; set; }

        /// <summary>
        /// The organizer
        /// </summary>
        Thing organizer;
        /// <summary>
        /// Organization  or Person - An organizer of an Event.
        /// </summary>
        /// <value>The organizer.</value>
        [JsonProperty("organizer")]
        public Thing Organizer
        {
            get { return organizer; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                organizer = value;
            }
        }

        /// <summary>
        /// The performer
        /// </summary>
        Thing performer;
        /// <summary>
        /// Organization  or Person 	A performer at the event—for example, a presenter, musician, musical group or actor. Supersedes <see cref="Performers"/>.
        /// </summary>
        /// <value>The performer.</value>
        [JsonProperty("performer")]
        public Thing Performer
        {
            get { return performer; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                performer = value;
            }
        }

        /// <summary>
        /// Collection of performers. Superseded by <see cref="Performer"/>
        /// </summary>
        [JsonProperty("performers")]
        public IList<object> Performers { get; set; }

        /// <summary>
        /// Date  - Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        /// <value>The previous start date.</value>
        [JsonProperty("previousStartDate")]
        public string PreviousStartDate { get; set; }

        /// <summary>
        /// CreativeWork - The CreativeWork that captured all or part of this Event. Inverse property: recordedAt.
        /// </summary>
        /// <value>The recorded in.</value>
        [JsonProperty("recordedIn")]
        public CreativeWork RecordedIn { get; set; }

        /// <summary>
        /// Integer - The number of attendee places for an event that remain unallocated.
        /// </summary>
        /// <value>The recorded in.</value>
        [JsonProperty("remainingAttendeeCapacity")]
        public int RemainingAttendeeCapacity { get; set; }

        /// <summary>
        ///  Review - A review of the item. Supersedes <see cref="reviews"/>.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        ///  Superseded by <see cref="Review"/>.
        /// </summary>
        [JsonProperty("reviews")]
        public IList<Review> Reviews { get; set; }

        Thing sponsor;
        /// <summary>
        /// Organization  or Person - A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [JsonProperty("sponsor")]
        public Thing Sponsor
        {
            get { return this.sponsor; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                this.sponsor = value;
            }
        }

        /// <summary>
        /// Collection of sponsors
        /// </summary>
        public IList<Thing> Sponsors { get; set; }

        /// <summary>
        /// Date - The start date and time of the item (in ISO 8601 date format).
        /// </summary>
        /// <value>The start date.</value>
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// Event -	An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference. Supersedes subEvents.
        /// </summary>
        /// <value>The sub event.</value>
        [JsonProperty("subEvent")]
        public Event SubEvent { get; set; }

        /// <summary>
        /// Event -	An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        /// <value>The super event.</value>
        [JsonProperty("superEvent")]
        public Event SuperEvent { get; set; }

        /// <summary>
        /// Text  - The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        /// <value>The typical age range.</value>
        [JsonProperty("typicalAgeRange")]
        public string TypicalAgeRange { get; set; }

        /// <summary>
        /// CreativeWork - A work featured in some event, e.g. exhibited in an ExhibitionEvent. 
        /// Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        /// </summary>
        /// <value>The work performed.</value>
        [JsonProperty("workFeatured")]
        public CreativeWork WorkFeatured { get; set; }

        /// <summary>
        /// CreativeWork - A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        /// <value>The work performed.</value>
        [JsonProperty("workPerformed")]
        public CreativeWork WorkPerformed { get; set; }

        /// <summary>
        /// A flag to signal that the publication is accessible for free.
        /// </summary>
        [JsonProperty("isAccessibleForFree")]
        public Boolean? IsAccessibleForFree { get; set; }
    }
}
