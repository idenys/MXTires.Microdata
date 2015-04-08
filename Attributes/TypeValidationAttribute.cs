using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;

namespace MXTires.Microdata.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class TypeValidationAttribute : Attribute
    {
        public Type AcceptedType1 { get; set; }
        public Type AcceptedType2 { get; set; }
        public List<Type> AcceptedTypes { get; set; }
        //private Type validator;
        //public TypeValidationAttribute(Type propertyClassType) { 

        //     if (propertyClassType == null)
        //    {
        //        throw new ArgumentNullException("propertyClassType");
        //    }
        //    if (!typeof (CoinValidatorBase).IsAssignableFrom(validator))
        //    {
        //        throw new ArgumentException("Validator Attribute param not validator");
        //    }
        //    type = propertyClassType;
        //public bool IsValid(Type )

        public virtual Validator ValidatorInstance
        {
            get
            {
                if (AcceptedTypes != null) return new TypeValidator(AcceptedTypes);
                return new TypeValidator(AcceptedType1, AcceptedType2);
            }
        }

        public Type ValidatorType
        {
            get { return typeof(TypeValidator); }
        }
    }
}
