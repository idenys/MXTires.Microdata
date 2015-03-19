using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class Audience : Thing
    {
        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.) domain: Audience Range: Text
        /// </summary>
        public string AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        public string AdministrativeArea { get; set; }

    }
}