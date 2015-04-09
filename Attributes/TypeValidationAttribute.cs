using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MXTires.Microdata.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class TypeValidationAttribute : ValidationAttribute
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

        public override bool IsValid(object value)
        {
            if (AcceptedTypes == null) AcceptedTypes = new List<Type>();
            if (AcceptedType1 != null) AcceptedTypes.Add(AcceptedType1);
            if (AcceptedType2 != null) AcceptedTypes.Add(AcceptedType2);
            var validator = new TypeValidator(AcceptedTypes);
            return validator.IsValid(value.GetType());
        }

        //public virtual Validator ValidatorInstance
        //{
        //    get
        //    {
        //        if (AcceptedTypes != null) return new TypeValidator(AcceptedTypes);
        //        return new TypeValidator(AcceptedType1, AcceptedType2);
        //    }
        //}

        //public Type ValidatorType
        //{
        //    get { return typeof(TypeValidator); }
        //}

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture,
              ErrorMessageString, name, AcceptedTypes.ToArray());
        }
    }
}
