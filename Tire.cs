using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    public class Tire : Product
    {
        [JsonProperty("@type", Order = 2)]
        public new string Type { get { return "Product/Tire"; } }

        //[JsonProperty("additionalType")]
        //public new string AdditionalType { get { return "http://www.1010tires.com/About/Tire-Tech"; } }

        //public Tire()
        //{
        //    base.SameAs = new List<string>();
        //    SameAs.Add("http://en.wikipedia.org/wiki/Tire");
        //}
    }
}
