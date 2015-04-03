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
using Newtonsoft.Json;
namespace MXTires.Microdata
{
    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise. 
    /// Related actions: 
    /// <list type="bullet">
    /// <item>
    ///     <description>
    ///         <code>ListenAction</code>: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.
    ///     </description>
    /// </item>
    /// <item>
    ///     <description>
    ///         <code>WatchAction</code>: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content
    ///     </description>
    /// </item>
    /// </list>
    /// </summary>
    public class PlayAction : Action
    {
        /// <summary>
        /// Audience - The intended audience of the item, i.e. the group for whom the item was created.
        /// </summary>
        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// Event - Upcoming or past event associated with this place, organization, or action. Supersedes events.
        /// </summary>
        [JsonProperty("event")]
        public Event Event { get; set; }
    }
}