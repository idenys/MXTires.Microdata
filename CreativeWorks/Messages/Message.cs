#region License
// Copyright (c) 2017 1010Tires.com
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

namespace MXTires.Microdata.CreativeWorks.Messages
{

    using System;
    using System.Collections.Generic;
    using MXTires.Microdata.Intangible;
    using MXTires.Microdata.Validators;
    using Newtonsoft.Json;

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    public class Message : CreativeWork
    {
        object bccRecipient;
        /// <summary>
        /// ContactPoint  or Organization  or Person - A sub property of recipient. The recipient blind copied on a message.
        /// </summary>
        [JsonProperty("bccRecipient")]
        public object BccRecipient
        {
            get { return this.bccRecipient; }
            set
            {
                TypeValidator validator = new TypeValidator(new List<Type>(new Type[] { typeof(ContactPoint), typeof(Organization), typeof(Person) }));
                validator.Validate(value);
                this.bccRecipient = value;
            }
        }

        object ccRecipient;
        /// <summary>
        /// ContactPoint  or Organization  or Person - A sub property of recipient. The recipient copied on a message.
        /// </summary>
        [JsonProperty("ccRecipient")]
        public object CcRecipient
        {
            get { return this.ccRecipient; }
            set
            {
                TypeValidator validator = new TypeValidator(new List<Type>(new Type[] { typeof(ContactPoint), typeof(Organization), typeof(Person) }));
                validator.Validate(value);
                this.ccRecipient = value;
            }
        }

        /// <summary>
        /// DateTime - The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        [JsonProperty("dateRead")]
        public DateTime DateRead { get; set; }

        /// <summary>
        /// DateTime - The date/time the message was received if a single recipient exists.
        /// </summary>
        [JsonProperty("dateReceived")]
        public DateTime DateReceived { get; set; }

        /// <summary>
        /// DateTime - The date/time at which the message was sent..
        /// </summary>
        [JsonProperty("dateSent")]
        public DateTime DateSent { get; set; }

        /// <summary>
        /// CreativeWork - A CreativeWork attached to the message.
        /// </summary>
        [JsonProperty("messageAttachment")]
        public CreativeWork MessageAttachment { get; set; }

        object recipient;
        /// <summary>
        /// Audience  or ContactPoint  or Organization  or Person - A sub property of participant. 
        /// The participant who is at the receiving end of the action.
        /// </summary>
        [JsonProperty("recipient")]
        public object Recipient
        {
            get { return this.recipient; }
            set
            {
                TypeValidator validator = new TypeValidator(new List<Type>(new Type[] { 
                    typeof(Audience), typeof(ContactPoint), typeof(Organization), typeof(Person) 
                }));
                validator.Validate(value);
                this.recipient = value;
            }
        }

        object sender;
        /// <summary>
        /// Audience  or Organization  or Person - A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [JsonProperty("sender")]
        public object Sender {             
            get { return this.sender; }
            set
            {
                TypeValidator validator = new TypeValidator(new List<Type>(new Type[] { 
                    typeof(Audience), typeof(Organization), typeof(Person) 
                }));
                validator.Validate(value);
                this.sender = value;
            } }

        object toRecipient;
        /// <summary>
        /// Audience  or ContactPoint  or Organization  or Person - A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        [JsonProperty("toRecipient")]
        public object ToRecipient {
            get { return this.toRecipient; }
            set
            {
                TypeValidator validator = new TypeValidator(new List<Type>(new Type[] 
                { 
                    typeof(Audience), typeof(ContactPoint), typeof(Organization), typeof(Person) 
                }));
                validator.Validate(value);
                this.toRecipient = value;
            } }
    }
}
