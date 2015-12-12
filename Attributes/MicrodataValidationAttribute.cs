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
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Xml;
using System.Globalization;
using System.ComponentModel;
using System.Security;
using System.Text;
using System;
using MXTires.Microdata.Validators;
namespace MXTires.Microdata.Attributes
{
    /// <summary>
    /// Class MicrodataValidationAttribute.
    /// </summary>
    public class MicrodataValidationAttribute : Attribute
    {

        /// <summary>
        /// The _declaring type
        /// </summary>
        internal Type _declaringType;
        /// <summary>
        /// The _validator
        /// </summary>
        private readonly Type _validator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MicrodataValidationAttribute"/> class.
        /// </summary>
        protected MicrodataValidationAttribute() {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MicrodataValidationAttribute"/> class.
        /// </summary>
        /// <param name="validator">The validator.</param>
        /// <exception cref="System.ArgumentNullException">validator</exception>
        /// <exception cref="System.ArgumentException">Validator Error 1</exception>
        public MicrodataValidationAttribute(Type validator)
        {
            if (validator == null) {
                throw new ArgumentNullException("validator");
            }

            if (!typeof(Validator).IsAssignableFrom(validator))
            {
                throw new ArgumentException("Validator Error 1");
            }
 
            _validator = validator;
        }
        /// <summary>
        /// Gets the validator instance.
        /// </summary>
        /// <value>The validator instance.</value>
        public virtual Validator ValidatorInstance
        {
            get {
                return (Validator) new object(); //(Validator) TypeUtil.CreateInstanceRestricted(_declaringType, _validator);
            }
        }

        // Used for limiting the visibility of types that can be accessed in the reflection
        // call made by the ValidatorInstance property getter. This will normally be the
        // type that declared the attribute, but in certain cases it could be a subclass
        // of the type that declared the attribute. This should be ok from a security
        // perspective, as one wouldn't reasonably expect a derived type to have fewer
        // security constraints than its base type.
        /// <summary>
        /// Sets the type of the declaring.
        /// </summary>
        /// <param name="declaringType">Type of the declaring.</param>
        internal void SetDeclaringType(Type declaringType) {
            if (declaringType == null) {
                Debug.Fail("Declaring type must not be null.");
                return; // don't throw in an in-place update
            }
 
            if (_declaringType == null) {
                // First call to this method - allow any type to be set
                _declaringType = declaringType;
            }
            else if (_declaringType != declaringType) {
                Debug.Fail("Subsequent calls cannot change the declaring type of the attribute.");
                return; // don't throw in an in-place update
            }
        }

        /// <summary>
        /// Gets the type of the validator.
        /// </summary>
        /// <value>The type of the validator.</value>
        public Type ValidatorType {
            get {
                return _validator;
            }
        }
    }
}