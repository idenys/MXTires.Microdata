using Newtonsoft.Json;

namespace MXTires.Microdata
{
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    public class TypeAndQuantityNode:StructuredValue
    {
        /// <summary>
        /// Number 	The quantity of the goods included in the offer.
        /// </summary>
        [JsonProperty("amountOfThisGood")]
        public float AmountOfThisGood { get; set; }		

        /// <summary>
        /// BusinessFunction - The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [JsonProperty("businessFunction")]
        public BusinessFunction BusinessFunction { get; set; }		
        
        /// <summary>
        /// Product 	The product that this structured value is referring to.
        /// </summary>
        [JsonProperty("typeOfGood")]
        public Product TypeOfGood  { get; set; }		

        /// <summary>
        /// Text - The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        [JsonProperty("unitCode")]
        public string UnitCode  { get; set; }		
    }
}
