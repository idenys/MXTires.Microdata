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

namespace MXTires.Microdata.CreativeWorks
{
    using Newtonsoft.Json;
    using MXTires.Microdata.Intangible.Services;

    /// <summary>
    /// A SpecialAnnouncement combines a simple date-stamped textual information update with contextualized Web links and other structured data. 
    /// It represents an information update made by a locally-oriented organization, for example schools, pharmacies, healthcare providers, community groups, police, local government.
    /// </summary>
    public class SpecialAnnouncement : CreativeWork
    {
        /// <summary>
        /// CivicStructure  or LocalBusiness - Indicates a specific CivicStructure or LocalBusiness associated with the SpecialAnnouncement.
        /// For example, a specific testing facility or business with special opening hours. 
        /// For a larger geographic region like a quarantine of an entire region, use spatialCoverage.
        /// </summary>
        [JsonProperty("announcementLocation")]
        public object AnnouncementLocation { get; set; }

        /// <summary>
        /// PhysicalActivityCategory  or Text or object or URL - A category for the item.
        /// Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [JsonProperty("category")]
        public object Category { get; set; }

        /// <summary>
        /// Date  or DateTime - Publication date of an online listing.
        /// </summary>
        [JsonProperty("datePosted")]
        public object DatePosted { get; set; }

        /// <summary>
        /// URL  or   WebContent Information about disease prevention.
        /// </summary>
        [JsonProperty("diseasePreventionInfo")]
        public object DiseasePreventionInfo { get; set; }

        /// <summary>
        /// Dataset  or Observation or URL or WebContent Statistical - information about the spread of a disease, either as WebContent, 
        /// or described directly as a Dataset, or the specific Observations in the dataset.When a WebContent URL is provided, 
        /// the page indicated might also contain more such markup.
        /// </summary>
        [JsonProperty("diseaseSpreadStatistics")]
        public object DiseaseSpreadStatistics { get; set; }

        /// <summary>
        /// URL  or WebContent - Information about getting tested(for a MedicalCondition), e.g. in the context of a pandemic.
        /// </summary>
        [JsonProperty("gettingTestedInfo")]
        public object GettingTestedInfo { get; set; }

        /// <summary>
        /// GovernmentService - governmentBenefitsInfo provides information about government benefits associated with a SpecialAnnouncement.
        /// </summary>
        [JsonProperty("governmentBenefitsInfo")]
        public GovernmentService GovernmentBenefitsInfo { get; set; }

        /// <summary>
        /// URL or WebContent - Indicates a page with news updates and guidelines.This could often be(but is not required to be) the main page containing SpecialAnnouncement markup on a site.
        /// </summary>
        [JsonProperty("newsUpdatesAndGuidelines")]
        public object NewsUpdatesAndGuidelines { get; set; }

        /// <summary>
        /// URL  or WebContent - Information about public transport closures.
        /// </summary>
        [JsonProperty("publicTransportClosuresInfo")]
        public object PublicTransportClosuresInfo { get; set; }

        /// <summary>
        ///URL or WebContent - Guidelines about quarantine rules, e.g. in the context of a pandemic.
        ///</summary>
        [JsonProperty("quarantineGuidelines")]
        public object QuarantineGuidelines { get; set; }

        /// <summary>
        /// URL  or  WebContent - Information about school closures.
        /// </summary>
        [JsonProperty("schoolClosuresInfo")]
        public object SchoolClosuresInfo { get; set; }

        /// <summary>
        /// URL  or WebContent - Information about travel bans, e.g. in the context of a pandemic.
        /// </summary>
        [JsonProperty("travelBans")]
        public object TravelBans { get; set; }

        /// <summary>
        /// DataFeed  or URL - The URL for a feed, e.g.associated with a podcast series, blog, or series of date-stamped updates.This is usually RSS or Atom.
        /// </summary>
        [JsonProperty("webFeed")]
        public object WebFeed { get; set; }


    }
}
