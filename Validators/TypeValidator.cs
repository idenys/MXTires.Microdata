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
    public class TypeValidator : Validator
    {
        private List<Type> types;
        private Type type1;
        private Type type2;

        public TypeValidator(List<Type> acceptableTypes)
        {
            types = acceptableTypes;
        }

        public TypeValidator(Type acceptableType1, Type acceptableType2 = null)
        {
            type1 = acceptableType1;
            type2 = acceptableType2;
        }

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

        public override void Validate(object value)
        {
            if ((value != null) && !IsValid(value.GetType()))
            {
                throw new ArgumentException(string.Format("Value of {0} is not valid.", value.GetType()));
            }
        }
    }
}