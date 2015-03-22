using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MXTires.Microdata.Intangible.Enumeration;

namespace MXTires.Microdata
{
    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    public class WarrantyPromise :StructuredValue
    {
        /// <summary>
        /// QuantitativeValue 	The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
        /// </summary>
        public QuantitativeValue durationOfWarranty{get;set;}	

        /// <summary>
        /// WarrantyScope 	The scope of the warranty promise.
        /// </summary>
        public WarrantyScope warrantyScope { get; set; }	
    }
}
