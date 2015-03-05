using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class ProductModel : Product
    {
        /// <summary>
        /// A pointer to a base product from which this product is a variant. 
        /// It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
        /// </summary>
        public ProductModel isVariantOf { get; set; }
        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product to its newer variant.
        /// </summary>
        public ProductModel predecessorOf { get; set; }
        /// <summary>
        /// A pointer from a newer variant of a product to its previous, often discontinued predecessor.
        /// </summary>
        public ProductModel successorOf { get; set; }
    }
}