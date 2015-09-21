using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.InteractActions
{
    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
    public class CommunicateAction : InteractAction
    {
        /// <summary>
        /// Thing - The subject matter of the content.
        /// </summary>
        [JsonProperty("about")]
        public Thing About { get; set; }

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

        Thing recipient;
        /// <summary>
        /// Organization  or Person  or Audience - A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [JsonProperty("recipient")]
        public Thing Recipient
        {
            get { return recipient; }
            set
            {
                var typeList = new List<Type> (){typeof(Organization), typeof(Person), typeof(Audience)};
                var validator = new TypeValidator(typeList);
                validator.Validate(value);
                recipient = value;
            }
        }
    }
}
