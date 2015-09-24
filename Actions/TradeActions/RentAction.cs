using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.LocalBusinesses;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TradeActions
{
    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. 
    /// For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    public class RentAction : TradeAction
    {
        object landlord;

        /// <summary>
        /// Person  or Organization - A sub property of participant. The owner of the real estate property.
        /// </summary>
        [JsonProperty("landlord")]
        public object Landlord
        {
            get { return landlord; }
            set
            {
                var validator = new TypeValidator(typeof(Person), typeof(Organization));
                validator.Validate(value);
                landlord = value;
            }
        }

           /// <summary>
        /// RealEstateAgent - A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        [JsonProperty("realEstateAgent")]
        public RealEstateAgent RealEstateAgent { get; set; }
    }
}
