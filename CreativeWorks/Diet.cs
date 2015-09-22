using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.CreativeWorks
{
    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    public class Diet : CreativeWork
    {
        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        [JsonProperty("dietFeatures")]
        public string DietFeatures {get;set;}

	
//endorsers	Person  or 
//Organization 	People or organizations that endorse the plan.
//expertConsiderations	Text 	Medical expert advice related to the plan.
//overview	Text 	Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
//physiologicalBenefits	Text 	Specific physiologic benefits associated to the plan.
//proprietaryName	Text 	Proprietary name given to the diet plan, typically by its originator or creator.
//risks	Text 	Specific physiologic risks associated to the plan.
    }
}
