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

using System;
using Newtonsoft.Json;
namespace MXTires.Microdata.Intangible
{
    /// <summary>
    /// A Property value specification.
    /// </summary>
    public class PropertyValueSpecification : Thing
    {
        /// <summary>
        /// Text  or Thing 	The default value of the input. For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        /// </summary>
        [JsonProperty("defaultValue")]
        public object DefaultValue { get; set; }

        /// <summary>
        /// Number 	The upper value of some characteristic or property.
        /// </summary>
        [JsonProperty("maxValue")]
        public Int64? MaxValue { get; set; }

        /// <summary>
        /// Number 	The lower value of some characteristic or property.
        /// </summary>
        [JsonProperty("minValue")]
        public Int64? MinValue { get; set; }

        /// <summary>
        /// Boolean - Whether multiple values are allowed for the property. Default is false.
        /// </summary>
        [JsonProperty("multipleValues")]
        public Boolean MultipleValues { get; set; }

        /// <summary>
        /// Boolean - Whether or not a property is mutable. Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        /// </summary>
        [JsonProperty("readonlyValue")]
        public Boolean ReadonlyValue { get; set; }

        /// <summary>
        /// Number 	The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        /// </summary>
        [JsonProperty("stepValue")]
        public Int64? StepValue { get; set; }

        /// <summary>
        /// Number 	Specifies the allowed range for number of characters in a literal value.
        /// </summary>
        [JsonProperty("valueMaxLength")]
        public Int64? ValueMaxLength { get; set; }

        /// <summary>
        /// Number 	Specifies the minimum allowed range for number of characters in a literal value.
        /// </summary>
        [JsonProperty("valueMinLength")]
        public Int64? ValueMinLength { get; set; }

        /// <summary>
        /// Text - Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        /// </summary>
        [JsonProperty("valueName")]
        public string ValueName { get; set; }

        /// <summary>
        /// Text - Specifies a regular expression for testing literal values according to the HTML spec.
        /// </summary>
        [JsonProperty("valuePattern")]
        public string ValuePattern { get; set; }

        /// <summary>
        /// Boolean - Whether the property must be filled in to complete the action. Default is false.
        /// </summary>
        [JsonProperty("valueRequired")]
        public Boolean ValueRequired { get; set; }
    }
}