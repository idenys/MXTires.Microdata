#region License
// Copyright (c) 2016 1010Tires.com
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

using Newtonsoft.Json;
namespace MXTires.Microdata
{
    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
    public class ProductModel : Product
    {
        /// <summary>
        /// A pointer to a base product from which this product is a variant. 
        /// It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
        /// </summary>
         [JsonProperty("isVariantOf")]
        public ProductModel IsVariantOf { get; set; }

        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product to its newer variant.
        /// </summary>
        [JsonProperty("predecessorOf")]
        public ProductModel PredecessorOf { get; set; }
        /// <summary>
        /// A pointer from a newer variant of a product to its previous, often discontinued predecessor.
        /// </summary>
        [JsonProperty("successorOf")]
        public ProductModel SuccessorOf { get; set; }
    }
}