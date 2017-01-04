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
using System.Collections.Generic;
namespace MXTires.Microdata.Validators
{
    /// <summary>
    /// Class TypeValidator.
    /// </summary>
    public class TypeValidator : Validator
    {
        /// <summary>
        /// The types
        /// </summary>
        private IList<Type> types;
        /// <summary>
        /// The type1
        /// </summary>
        private Type type1;
        /// <summary>
        /// The type2
        /// </summary>
        private Type type2;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeValidator"/> class.
        /// </summary>
        /// <param name="acceptableTypes">The acceptable types.</param>
        public TypeValidator(IList<Type> acceptableTypes)
        {
            types = acceptableTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeValidator"/> class.
        /// </summary>
        /// <param name="acceptableType1">The acceptable type1.</param>
        /// <param name="acceptableType2">The acceptable type2.</param>
        public TypeValidator(Type acceptableType1, Type acceptableType2 = null)
        {
            type1 = acceptableType1;
            type2 = acceptableType2;
            types = new List<Type>() { type1, type2 };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeValidator"/> class.
        /// </summary>
        /// <param name="typeNamespace">The namespace within all types will be acceptable</param>
        /// <param name="excludeWithinNamespace">List of type names within the namespace that will be excluded</param>
        /// <param name="acceptableTypes">List of other types (not from upper namespace) that will be included</param>
        public TypeValidator(string typeNamespace, IList<string> excludeWithinNamespace, List<Type> acceptableTypes = null)
        {
            types = NamespaceTypes.GetNamespaceTypes(typeNamespace, excludeWithinNamespace);
            if (acceptableTypes != null)
            {
                foreach (Type t in acceptableTypes)
                {
                    if (!types.Contains(t))
                    {
                        types.Add(t);
                    }
                }

            }
        }

        /// <summary>
        /// Determines whether the specified type is valid.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if the specified type is valid; otherwise, <c>false</c>.</returns>
        public override bool IsValid(Type type)
        {
            if (type1 != null && type == type1) return true;
            if (type2 != null && type == type2) return true;

            foreach (var item in types)
            {
                if (type == item) return true;
            }
            return false;
        }

        /// <summary>
        /// Validates the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public override void Validate(object value)
        {
            if ((value != null) && !IsValid(value.GetType()))
            {
                string errMsg = "";
                foreach (var item in types)
                {
                    if (!string.IsNullOrEmpty(errMsg)) errMsg = errMsg + " and ";
                    errMsg = errMsg + item.FullName;
                }
                throw new ArgumentException(string.Format("Type of {0} is not valid for this property. Accepted types are: {1} ", value.GetType(), errMsg));
            }
        }
    }
}