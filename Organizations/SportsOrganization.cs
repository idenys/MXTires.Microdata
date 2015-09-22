using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Organizations
{
    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    public class SportsOrganization : Organization
    {
        object sport;

        /// <summary>
        /// URL  or Text - A type of sport (e.g. Baseball).
        /// </summary>
        [JsonProperty("sport")]
        public object Sport
        {
            get { return sport; }
            set
            {
                var validator = new TypeValidator(typeof(string), typeof(string));
                validator.Validate(value);
                sport = value;
            }
        }
    }
}
