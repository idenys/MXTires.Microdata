using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
    public class Wheel : Product
    {
        [JsonProperty("@type", Order = 2)]
        public new string Type { get { return "Product/Wheel"; } }

    //    [JsonProperty("additionalType")]
    //    public new string AdditionalType { get { return "http://www.1010tires.com/About/Wheel-Tech"; } }

    //    public Wheel() {
    //        base.SameAs = new List<string>();
    //        SameAs.Add("http://en.wikipedia.org/wiki/Wheel");
    //    }
    //}
}
