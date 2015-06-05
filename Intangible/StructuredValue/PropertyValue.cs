using Newtonsoft.Json;
using System;

namespace MXTires.Microdata.Intangible.StructuredValue
{
    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. 
    /// If there is an additional human-readable version of the value, put that into the 'description' property. 
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. 
    /// Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    /// </summary>
    public class PropertyValue : Thing
    {
        /// <summary>
        /// Number - The upper value of some characteristic or property.
        /// </summary>
        [JsonProperty("maxValue")]
        public string MaxValue { get; set; }

        /// <summary>
        /// Number - The lower value of some characteristic or property.
        /// </summary>
        [JsonProperty("minValue")]
        public string MinValue { get; set; }

        /// <summary>
        /// URL  or Text - A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3) a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry). Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        /// </summary>
        [JsonProperty("propertyID")]
        public string PropertyID { get; set; }

        /// <summary>
        ///  URL  or Text 	The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        /// <summary>
        /// Text - A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for unitCode.
        /// </summary>
        [JsonProperty("unitText")]
        public string UnitText { get; set; }

        /// <summary>
        /// Text  or StructuredValue  or Number  or Boolean - The value of the quantitative value or property value node. For QuantitativeValue, the recommended type for values is 'Number'. For PropertyValue, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }

        /// <summary>
        /// QualitativeValue  or QuantitativeValue  or PropertyValue  or Enumeration  or  StructuredValue - A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        [JsonProperty("valueReference")]
        public string ValueReference { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public PropertyValue(string name, object value) {
            Name = name; 
            Value = value;
        }
    }
}
