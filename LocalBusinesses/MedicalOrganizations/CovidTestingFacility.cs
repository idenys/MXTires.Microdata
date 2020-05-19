#region License
// Copyright (c) 2020 1010Tires.com
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


namespace MXTires.Microdata.LocalBusinesses.MedicalOrganizations
{
    using MXTires.Microdata.LocalBusinesses.LodgingBusinesses;

    /// <summary>
    /// A CovidTestingFacility is a <see cref="MedicalClinic"/> where testing for the COVID-19 Coronavirus disease is available. 
    /// If the facility is being made available from an established <see cref="Pharmacy"/>, <see cref="Hotel"/>, or other non-medical organization, multiple types can be listed. 
    /// This makes it easier to re-use existing schema.org information about that place e.g. contact info, address, opening hours. Note that in an emergency, such information may not always be reliable.
    /// </summary>
    /// <remarks>This term is proposed for full integration into Schema.org, pending implementation feedback and adoption from applications and websites.</remarks>
    public class CovidTestingFacility : MedicalClinic 
    {
    }
}
