using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXTires.Microdata
{
    public class PriceSpecification : Thing
    {

        #region Properties

        //eligibleQuantity	QuantitativeValue 	The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        //eligibleTransactionVolume	PriceSpecification 	The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// <summary>
        /// Number 	The highest price if the price is a range.
        /// </summary>
        public string maxPrice { get; set; }
        /// <summary>
        /// Number 	The lowest price if the price is a range.
        /// </summary>
        public string minPrice { get; set; }

        /// <summary>
        /// Number  or Text. The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes. 
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// Text. The currency (in 3-letter ISO 4217 format) of the price or a price component, when attached to PriceSpecification and its subtypes.
        /// </summary>
        public string PriceCurrency { get; set; }
        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        public DateTime? validFrom { get; set; }
        /// <summary>
        /// The end of the validity of offer, price specification, or opening hours data.
        /// </summary>
        public DateTime? validThrough { get; set; }
        /// <summary>
        /// Boolean 	Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        /// </summary>
        public bool valueAddedTaxIncluded { get; set; }

        #endregion
    }
}