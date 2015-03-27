using Newtonsoft.Json;

namespace MXTires.Microdata.Intangible
{
    public class Item : Thing
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public override string Type { get { return "thing"; } }
    
    }
}
