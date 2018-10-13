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

using System;
using System.Collections.Generic;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Attributes
{
    /// <summary>
    /// /// <summary>
    /// Defines the microdata property.
    /// </summary>
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class MicrodataPropertyAttribute : Attribute
    {

        string propertyName;
        /// <summary>
        /// Initializes a new instance of the <see cref="MicrodataPropertyAttribute"/> class with the specified name.
        /// </summary>
        /// <param name="name">Name of the property.</param>
        public MicrodataPropertyAttribute(String name)
        {
            propertyName = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MicrodataPropertyAttribute"/> class with the specified name and accepted types.
        /// </summary>
        /// <param name="name">Name of the property</param>
        /// <param name="acceptedTypes">Types acceptable by this property</param>
        public MicrodataPropertyAttribute(String name, IList<Type> acceptedTypes)
        {
            ConstructorInit(name, null, acceptedTypes);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MicrodataPropertyAttribute"/> class with the specified name and accepted types.
        /// </summary>
        /// <param name="name">Name of the property</param>
        /// <param name="acceptedTypes">Types acceptable by this property</param>
        public MicrodataPropertyAttribute(String name, Type acceptedType1, Type acceptedType2)
        {
            ConstructorInit(name, null, new List<Type> { acceptedType1, acceptedType2 });
        }

        /// <summary>
        /// Name of the property
        /// </summary>
        /// <value>The name of the property.</value>
        public String Name
        {
            get
            {
                return propertyName;
            }
        }

        /// <summary>
        /// Set list of accepted types
        /// </summary>
        /// <value>Collection of types</value>
        public IList<Type> AcceptedTypes { get; private set; }

        bool isRequired = false;
        /// <summary>
        /// Indicating whether this property is required.
        /// </summary>
        /// <value>
        /// 	A value indicating whether this property is required.
        /// </value>
        public bool IsRequired
        {
            get
            {
                return isRequired;
            }
        }
        /// <summary>
        /// Class - Relates a property to a class that is (one of) the type(s) the property is expected to be used on.
        /// </summary>
        public Class DomainIncludes { get; private set; }

        /// <summary>
        /// Property - Relates a property to a property that is its inverse. Inverse properties relate the same pairs of items to each other, but in reversed direction. For example, the 'alumni' and 'alumniOf' properties are inverseOf each other. Some properties don't have explicit inverses; in these situations RDFa and JSON-LD syntax for reverse properties can be used.
        /// </summary>
        public Property InverseOf { get; private set; }

        /// <summary>
        /// Class - Relates a property to a class that constitutes (one of) the expected type(s) for values of the property.
        /// </summary>
        public Class RangeIncludes { get; private set; }

        object supersededBy = null;
        /// <summary>
        /// Property  or Enumeration  or Class - Relates a term (i.e. a property, class or enumeration) to one that supersedes it.
        /// </summary>
        public object SupersededBy
        {
            get { return this.supersededBy; }
        }

        TypeValidator validator;

        /// <summary>
        /// Comon initialization method
        /// </summary>
        /// <param name="name">Property name</param>
        /// <param name="type"></param>
        /// <param name="acceptedTypes"></param>
        private void ConstructorInit(string name, Type type, IList<Type> acceptedTypes)
        {
            if (acceptedTypes != null) { validator = new TypeValidator(acceptedTypes); }
        }
    }
}
