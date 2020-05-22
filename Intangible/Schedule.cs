#region License
// Copyright (c) 2020 1010Tires.com
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

using MXTires.Microdata.Intangible.Quantities;
using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring Event. At a minimum a schedule will specify repeatFrequency which describes the interval between occurences of the event. Additional information can be provided to specify the schedule more precisely. This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// </summary>
    public class Schedule : Thing
    {/// <summary>
     /// DayOfWeek  or Text Defines the day(s) of the week on which a recurring Event takes place.May be specified using either DayOfWeek, or alternatively Text conforming to iCal's syntax for byDay recurrence rules
     /// </summary>
        [JsonProperty("byDay")]
        public object ByDay { get; set; }

        /// <summary>
        /// Integer - Defines the month(s) of the year on which a recurring Event takes place.Specified as an Integer between 1-12. January is 1.
        /// </summary>
        [JsonProperty("byMonth")]
        public object ByMonth { get; set; }

        /// <summary>
        /// Integer - Defines the day(s) of the month on which a recurring Event takes place.Specified as an Integer between 1-31. 
        /// </summary>
        [JsonProperty("byMonthDay")]
        public object ByMonthDay { get; set; }

        /// <summary>
        /// Duration - The duration of the item(movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        /// <summary>
        /// Date or DateTime  - The end date and time of the item(in ISO 8601 date format).
        /// </summary>
        [JsonProperty("endDate")]
        public object endDate { get; set; }

        /// <summary>
        /// DateTime  or Time - The endTime of something.For a reserved event or service (e.g.FoodEstablishmentReservation), the time that it is expected to end.For actions that span a period of time, when the action was performed.e.g.John wrote a book from January to December.For media, including audio and video, it's the time offset of the end of a clip within a larger file.
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [JsonProperty("endTime")]
        public object endTime { get; set; }

        /// <summary>
        /// Date  or DateTime - Defines a Date or DateTime during which a scheduled Event will not take place. The property allows exceptions to a Schedule to be specified. If an exception is specified as a DateTime then only the event that would have started at that specific date and time should be excluded from the schedule. If an exception is specified as a Date then any event that is scheduled for that 24 hour period should be excluded from the schedule. This allows a whole day to be excluded from the schedule without having to itemise every scheduled event.
        /// </summary>
        [JsonProperty("exceptDate")]
        public object ExceptDate { get; set; }

        /// <summary>
        /// Integer - Defines the number of times a recurring Event will take place
        /// </summary>
        [JsonProperty("repeatCount")]
        public object RepeatCount { get; set; }

        /// <summary>
        /// Duration or Text Defines the frequency at which Events will occur according to a schedule Schedule.The intervals between events should be defined as a Duration of time.
        /// </summary>
        [JsonProperty("repeatFrequency")]
        public object RepeatFrequency { get; set; }

        /// <summary>
        /// Text - Indicates the timezone for which the time(s) indicated in the Schedule are given. The value provided should be among those listed in the IANA Time Zone Database.
        /// </summary>
        [JsonProperty("scheduleTimezone")]
        public string ScheduleTimezone { get; set; }

        /// <summary>
        /// Date  or DateTime - The start date and time of the item(in ISO 8601 date format).
        /// </summary>
        [JsonProperty("startDate")]
        public object StartDate { get; set; }

        /// <summary>
        /// DateTime or Time - The startTime of something. For a reserved event or service (e.g.FoodEstablishmentReservation), the time that it is expected to start.For actions that span a period of time, when the action was performed.e.g.John wrote a book from January to December.For media, including audio and video, it's the time offset of the start of a clip within a larger file.
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [JsonProperty("startTime")]
        public object StartTime { get; set; }
    }
}
