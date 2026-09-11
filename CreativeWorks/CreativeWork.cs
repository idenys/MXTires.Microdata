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
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Organizations.PerformingGroups;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Places.AdministrativeAreas;

namespace MXTires.Microdata
{
    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
    public class CreativeWork : Thing
    {
        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [JsonProperty("about")]
        public Thing About { get; set; }

        /// <summary>
        /// Text - A description of the abstract if the CreativeWork is an Article.
        /// </summary>
        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        /// <summary>
        /// Text - The human sensory perceptual system or cognitive faculty through which a person may process or perceive information.
        /// </summary>
        [JsonProperty("accessMode")]
        public string AccessMode { get; set; }

        /// <summary>
        /// ItemList - A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource.
        /// </summary>
        [JsonProperty("accessModeSufficient")]
        public ItemList AccessModeSufficient { get; set; }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (WebSchemas wiki lists possible values).
        /// </summary>
        [JsonProperty("accessibilityAPI")]
        public string AccessibilityAPI { get; set; }

        /// <summary>
        /// Text 	Identifies input methods that are sufficient to fully control the described resource (WebSchemas wiki lists possible values).
        /// </summary>
        [JsonProperty("accessibilityControl")]
        public string AccessibilityControl { get; set; }

        /// <summary>
        /// Text 	Content features of the resource, such as accessible media, alternatives and supported enhancements for 
        /// accessibility (WebSchemas wiki lists possible values).
        /// </summary>
        [JsonProperty("accessibilityFeature")]
        public string AccessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. 
        /// Related to WCAG 2.0 guideline 2.3. (WebSchemas wiki lists possible values)
        /// </summary>
        [JsonProperty("accessibilityHazard")]
        public string AccessibilityHazard { get; set; }

        /// <summary>
        /// Text - A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed".
        /// </summary>
        [JsonProperty("accessibilitySummary")]
        public string AccessibilitySummary { get; set; }

        /// <summary>
        /// Person - Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [JsonProperty("accountablePerson")]
        public Person AccountablePerson { get; set; }

        private object acquireLicensePage;
        /// <summary>
        /// CreativeWork or URL - Indicates a page documenting how licenses can be purchased or otherwise acquired, for the current item.
        /// </summary>
        [JsonProperty("acquireLicensePage")]
        public object AcquireLicensePage
        {
            get { return acquireLicensePage; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                acquireLicensePage = value;
            }
        }

        /// <summary>
        /// AggregateRating - The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonProperty("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// Text 	A secondary title of the CreativeWork.
        /// </summary>
        [JsonProperty("alternativeHeadline")]
        public string AlternativeHeadline { get; set; }

        private object archivedAt;
        /// <summary>
        /// URL or WebPage - Indicates a page or other link involved in archival of a CreativeWork. In the case of MediaReview, the items in a MediaReviewItem may often become inaccessible, but be archived by archival, journalistic, activist, or law enforcement organizations. In such cases, the referenced page may not directly publish the content.
        /// </summary>
        [JsonProperty("archivedAt")]
        public object ArchivedAt
        {
            get { return archivedAt; }
            set
            {
                var validator = new TypeValidator(typeof(WebPage), typeof(string));
                validator.Validate(value);
                archivedAt = value;
            }
        }

        /// <summary>
        /// DefinedTerm or Text - The predominant type or kind characterizing the assessment. e.g. 'e-values as measures of confidence' or 'homework problem, 'rubric'.
        /// </summary>
        [JsonProperty("assesses")]
        public string Assesses { get; set; }

        /// <summary>
        /// MediaObject - A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        [JsonProperty("associatedMedia")]
        public MediaObject AssociatedMedia { get; set; }

        /// <summary>
        /// Audience - The intended audience of the item, i.e. the group for whom the item was created.
        /// </summary>
        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        [JsonProperty("audio")]
        public AudioObject Audio { get; set; }

        Thing author;
        /// <summary>
        /// Person  or  Organization - The author of this content. 
        /// Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. 
        /// That is equivalent to this and may be used interchangeably.
        /// </summary>
        [JsonProperty("author", Required = Required.Always)]
        public Thing Author
        {
            get { return author; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                author = value;
            }
        }

        /// <summary>
        /// Text - An award won by this person or for this creative work. Supersedes awards.
        /// </summary>
        [JsonProperty("award")]
        public string Award { get; set; }

        /// <summary>
        /// Person - Fictional person connected with a creative work.
        /// </summary>
        [JsonProperty("character")]
        public Person Character { get; set; }

        /// <summary>
        /// 	CreativeWork  {get;set;} or 
        ///     Text - A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [JsonProperty("citation")]
        public CreativeWork Citation { get; set; }

        /// <summary>
        /// UserComments  or Comment, typically from users, on this CreativeWork.
        /// </summary>
        public object Comment
        {
            set
            {
                Comments = Comments ?? new List<object>();
                Comments.Add(value);
            }
        }

        /// <summary>
        /// UserComments  Comments, typically from users, on this CreativeWork.
        /// </summary>
        [JsonProperty("comment")]
        public List<object> Comments { get; set; }

        /// <summary>
        /// Integer - The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        [JsonProperty("commentCount")]
        public Int32? CommentCount { get; set; }

        /// <summary>
        /// Text - Conditions that affect the availability of, or method(s) of access to, an item. Typically used for real world items such as an ArchiveComponent held by an ArchiveOrganization.
        /// </summary>
        [JsonProperty("conditionsOfAccess")]
        public string ConditionsOfAccess { get; set; }

        /// <summary>
        /// Place - The location of the content.
        /// </summary>
        [JsonProperty("contentLocation")]
        public Place ContentLocation { get; set; }

        /// <summary>
        /// Text - Official rating of a piece of content—for example,'MPAA PG-13'.
        /// </summary>
        [JsonProperty("contentRating")]
        public string ContentRating { get; set; }

        /// <summary>
        /// DateTime - The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasize a particular moment within an Event.
        /// </summary>
        [JsonProperty("contentReferenceTime")]
        public DateTime? ContentReferenceTime { get; set; }

        private Thing contributor;
        /// <summary>
        /// Person  or Organization - A secondary contributor to the CreativeWork.
        /// </summary>
        [JsonProperty("contributor")]
        public Thing Contributor
        {
            get { return contributor; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                contributor = value;
            }
        }

        private Thing copyrightHolder;
        /// <summary>
        /// Person  or Organization - The party holding the legal copyright to the <see cref="CreativeWork"/>.
        /// </summary>
        [JsonProperty("copyrightHolder")]
        public Thing CopyrightHolder
        {
            get { return copyrightHolder; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                copyrightHolder = value;
            }
        }

        /// <summary>
        /// Text - Text of a notice appropriate for describing the copyright aspects of this Creative Work, ideally indicating the owner of the copyright for the work.
        /// </summary>
        [JsonProperty("copyrightNotice")]
        public string CopyrightNotice { get; set; }

        /// <summary>
        /// Number - The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [JsonProperty("copyrightYear")]
        public Int32? CopyrightYear { get; set; }

        /// <summary>
        /// CorrectionComment, Text, or URL - Indicates a correction to a CreativeWork, either via a CorrectionComment, textually or in another document.
        /// </summary>
        [JsonProperty("correction")]
        public string Correction { get; set; }

        /// <summary>
        /// Country - The country of origin of something, including products as well as creative works such as movie and TV content.
        /// </summary>
        [JsonProperty("countryOfOrigin")]
        public Country CountryOfOrigin { get; set; }

        /// <summary>
        /// DefinedTerm or Text - The status of a creative work in terms of its stage in a lifecycle. Example terms include Incomplete, Draft, Published, Obsolete.
        /// </summary>
        [JsonProperty("creativeWorkStatus")]
        public string CreativeWorkStatus { get; set; }

        private Thing creator;

        /// <summary>
        /// Person  or Organization - The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
        /// </summary>
        [JsonProperty("creator")]
        public Thing Creator
        {
            get { return creator; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                creator = value;
            }
        }

        /// <summary>
        /// Text - Text that can be used to credit person(s) and/or organization(s) associated with a published Creative Work.
        /// </summary>
        [JsonProperty("creditText")]
        public string CreditText { get; set; }

        /// <summary>
        /// Date - The date on which the CreativeWork was created.
        /// </summary>
        [JsonProperty("dateCreated")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Date - The date on which the CreativeWork was most recently modified.
        /// </summary>
        [JsonProperty("dateModified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Date - Date of first broadcast/publication.
        /// </summary>
        [JsonProperty("datePublished")]
        public DateTime? DatePublished { get; set; }

        /// <summary>
        /// IPTCDigitalSourceEnumeration - Content coded as reflecting a particular currently discussed digital human trafficking/slavery topic, or the IPTC "Digital Source Type" vocabulary term for content that was primarily created/produced by human authorship, or various forms of algorithmic/AI generation, e.g. "algorithmicMedia".
        /// </summary>
        [JsonProperty("digitalSourceType")]
        public string DigitalSourceType { get; set; }

        /// <summary>
        ///  URL - A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [JsonProperty("discussionUrl")]
        public string DiscussionUrl { get; set; }

        /// <summary>
        /// Place - A NewsArticle associated with the Media Object.
        /// </summary>
        [JsonProperty("displayLocation")]
        public Place DisplayLocation { get; set; }

        /// <summary>
        /// Text or URL - An EIDR (Entertainment Identifier Registry) identifier representing a specific edit / edition for a work of film or television.
        /// </summary>
        [JsonProperty("editEIDR")]
        public string EditEIDR { get; set; }

        /// <summary>
        /// Person - Specifies the Person who edited the CreativeWork.
        /// </summary>
        [JsonProperty("editor")]
        public Person Editor { get; set; }

        /// <summary>
        /// AlignmentObject - An alignment to an established educational framework.
        /// </summary>
        [JsonProperty("educationalAlignment")]
        public AlignmentObject EducationalAlignment { get; set; }

        /// <summary>
        /// DefinedTerm, Text, or URL - The level in terms of progression through an educational or training context. Examples of educational levels include 'beginner', 'intermediate' or 'advanced'.
        /// </summary>
        [JsonProperty("educationalLevel")]
        public string EducationalLevel { get; set; }

        /// <summary>
        /// Text - The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        [JsonProperty("educationalUse")]
        public string EducationalUse { get; set; }

        /// <summary>
        /// MediaObject - A media object that encodes this CreativeWork. This property is a synonym for associatedMedia. Supersedes encodings.
        /// </summary>
        [JsonProperty("encoding")]
        public MediaObject Encoding { get; set; }

        /// <summary>
        /// Text or URL - Media type typically expressed using a MIME format (see IANA site and MDN reference), e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.
        /// </summary>
        [JsonProperty("encodingFormat")]
        public string EncodingFormat { get; set; }

        /// <summary>
        /// CreativeWork - A creative work that this work is an example/instance/realization/derivation of. Inverse property: workExample.
        /// </summary>
        [JsonProperty("exampleOfWork")]
        public CreativeWork ExampleOfWork { get; set; }

        private Thing funder;
        /// <summary>
        /// Organization or Person - A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [JsonProperty("funder")]
        public Thing Funder
        {
            get { return funder; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                funder = value;
            }
        }

        /// <summary>
        /// Grant - A Grant that directly or indirectly provided funding or sponsorship for this item.
        /// </summary>
        [JsonProperty("funding")]
        public Grant Funding { get; set; }

        /// <summary>
        /// Text - Genre of the creative work or group.
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// CreativeWork - Indicates a CreativeWork that is (in some sense) a part of this CreativeWork. Inverse property: isPartOf.
        /// </summary>
        [JsonProperty("hasPart")]
        public CreativeWork HasPart { get; set; }

        /// <summary>
        /// Text -	Headline of the article
        /// </summary>
        [JsonProperty("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// Text - The language of the content. please use one of the language codes from the IETF BCP 47 standard.
        /// </summary>
        [JsonProperty("inLanguage")]
        public string InLanguage { get; set; }

        /// <summary>
        /// Text - A count of a specific user interactions with this item—for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.
        /// </summary>
        [JsonProperty("interactionCount")]
        public string InteractionCount { get; set; }

        /// <summary>
        /// InteractionCounter - The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [JsonProperty("interactionStatistic")]
        public InteractionCounter InteractionStatistic { get; set; }

        /// <summary>
        /// Text - The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [JsonProperty("interactivityType")]
        public string InteractivityType { get; set; }

        /// <summary>
        /// Claim - Used to indicate a specific claim contained, implied, translated or refined from the content of a CreativeWork. The interpretingPrinciple can be used to indicate at least how the extracted claim relates to the original content.
        /// </summary>
        [JsonProperty("interpretedAsClaim")]
        public Claim InterpretedAsClaim { get; set; }

        /// <summary>
        /// Boolean - A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [JsonProperty("isAccessibleForFree")]
        public bool? IsAccessibleForFree { get; set; }

        private object isBasedOn;
        /// <summary>
        /// CreativeWork, Product, or URL - A resource from which this work is derived or from which it is a modification or adaptation.
        /// </summary>
        [JsonProperty("isBasedOn")]
        public object IsBasedOn
        {
            get { return isBasedOn; }
            set
            {
                var validator = new TypeValidator(new List<Type> { typeof(CreativeWork), typeof(Product), typeof(string) });
                validator.Validate(value);
                isBasedOn = value;
            }
        }

        /// <summary>
        /// URL - A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html
        /// </summary>
        [JsonProperty("isBasedOnUrl")]
        public string IsBasedOnUrl { get; set; }

        /// <summary>
        /// Boolean - Indicates whether this content is family friendly.
        /// </summary>
        [JsonProperty("isFamilyFriendly")]
        public bool? IsFamilyFriendly { get; set; }

        /// <summary>
        /// CreativeWork - Indicates a CreativeWork that this CreativeWork is (in some sense) part of.
        /// Inverse property: hasPart.
        /// </summary>
        [JsonProperty("isPartOf")]
        public CreativeWork IsPartOf { get; set; }

        /// <summary>
        /// Text -	Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Text - The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        [JsonProperty("learningResourceType")]
        public string LearningResourceType { get; set; }

        /// <summary>
        /// URL  or CreativeWork - A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [JsonProperty("license")]
        public Thing License { get; set; }

        /// <summary>
        /// Place - The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        [JsonProperty("locationCreated")]
        public Place LocationCreated { get; set; }

        /// <summary>
        /// Thing - Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [JsonProperty("mainEntity")]
        public Thing MainEntity { get; set; }

        private Thing maintainer;
        /// <summary>
        /// Organization or Person - A maintainer of a CreativeWork, such as a software package or repository. Maintainers are the curators of the package.
        /// </summary>
        [JsonProperty("maintainer")]
        public Thing Maintainer
        {
            get { return maintainer; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                maintainer = value;
            }
        }

        private object material;
        /// <summary>
        /// Product, Text, or URL - A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [JsonProperty("material")]
        public object Material
        {
            get { return material; }
            set
            {
                var validator = new TypeValidator(typeof(Product), typeof(string));
                validator.Validate(value);
                material = value;
            }
        }

        private object materialExtent;
        /// <summary>
        /// QuantitativeValue or Text - The quantity of the materials being described or an expression of the physical space they occupy.
        /// </summary>
        [JsonProperty("materialExtent")]
        public object MaterialExtent
        {
            get { return materialExtent; }
            set
            {
                var validator = new TypeValidator(typeof(QuantitativeValue), typeof(string));
                validator.Validate(value);
                materialExtent = value;
            }
        }

        /// <summary>
        /// Thing - Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        [JsonProperty("mentions")]
        public Thing Mentions { get; set; }

        /// <summary>
        /// Offer - An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        [JsonProperty("offers")]
        public IList<Offer> Offers { get; set; }

        /// <summary>
        /// DefinedTerm or Text - A pattern that something has, for example 'polka dot', 'striped', 'Canadian flag'. Values are typically expressed as text, although links to controlled value schemes are also supported.
        /// </summary>
        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Integer  or Text - The position of an item in a series or sequence of items.
        /// </summary>
        [JsonProperty("position")]
        public Int32? Position { get; set; }

        private Thing producer;
        /// <summary>
        /// Organization or Person - The person or organization who produced the work (e.g. music album, movie, TV/radio series etc.).
        /// </summary>
        [JsonProperty("producer")]
        public Thing Producer
        {
            get { return producer; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                producer = value;
            }
        }

        Thing provider;
        /// <summary>
        /// Person  or  Organization  -	The service provider, service operator, or service performer; 
        /// the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. 
        /// A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        [JsonProperty("provider")]
        public Thing Provider
        {
            get { return this.provider; }
            set
            {
                TypeValidator validator = new TypeValidator(typeof(Organization), typeof(ProgramMembership));
                validator.Validate(value);
                this.provider = value;
            }
        }

        /// <summary>
        /// PublicationEvent - A publication event (e.g. sending out a press release, presenting at a conference, aired on TV) associated with the item.
        /// </summary>
        [JsonProperty("publication")]
        public PublicationEvent Publication { get; set; }

        /// <summary>
        /// Organization - The publisher of the creative work.
        /// </summary>
        [JsonProperty("publisher")]
        public Organization Publisher { get; set; }

        /// <summary>
        /// Organization - The publishing division which released this title.
        /// </summary>
        [JsonProperty("publisherImprint")]
        public Organization PublisherImprint { get; set; }

        /// <summary>
        /// URL - Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
        /// </summary>
        [JsonProperty("publishingPrinciples")]
        public string PublishingPrinciples { get; set; }

        /// <summary>
        /// Event -	The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// Inverse property: recordedIn.
        /// </summary>
        [JsonProperty("recordedAt")]
        public Event RecordedAt { get; set; }

        /// <summary>
        /// PublicationEvent - The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        [JsonProperty("releasedEvent")]
        public PublicationEvent ReleasedEvent { get; set; }

        /// <summary>
        /// Review - A review of the item. Supersedes reviews.
        /// </summary>
        [JsonProperty("review")]
        public Review Review { get; set; }

        /// <summary>
        /// Review of the item. Superseded by <see cref="Review"/>.
        /// </summary>
        [JsonProperty("reviews")]
        public IList<Review> Reviews { get; set; }

        /// <summary>
        /// Text or URL - Indicates (by URL or string) a particular version of a schema used in some CreativeWork.
        /// </summary>
        [JsonProperty("schemaVersion")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Date - Indicates the date on which the current structured data was generated / published. Typically used alongside sdPublisher.
        /// </summary>
        [JsonProperty("sdDatePublished")]
        public DateTime? SdDatePublished { get; set; }

        private object sdLicense;
        /// <summary>
        /// CreativeWork or URL - A license document that applies to this structured data, typically indicated by URL.
        /// </summary>
        [JsonProperty("sdLicense")]
        public object SdLicense
        {
            get { return sdLicense; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                sdLicense = value;
            }
        }

        private Thing sdPublisher;
        /// <summary>
        /// Organization or Person - Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content.
        /// </summary>
        [JsonProperty("sdPublisher")]
        public Thing SdPublisher
        {
            get { return sdPublisher; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                sdPublisher = value;
            }
        }

        private object size;
        /// <summary>
        /// DefinedTerm, QuantitativeValue, SizeSpecification, or Text - A standardized size of a product or creative work, specified either through a simple textual string (for example 'XL', '32Wx34L'), a QuantitativeValue with a unitCode, or a comprehensive and structured SizeSpecification; in other cases, the width, height, depth and weight properties may be more applicable.
        /// </summary>
        [JsonProperty("size")]
        public object Size
        {
            get { return size; }
            set
            {
                var validator = new TypeValidator(typeof(QuantitativeValue), typeof(string));
                validator.Validate(value);
                size = value;
            }
        }

        /// <summary>
        /// Organization - The Organization on whose behalf the creator was working.
        /// </summary>
        [JsonProperty("sourceOrganization")]
        public Organization SourceOrganization { get; set; }

        /// <summary>
        /// Place - The "spatial" property can be used in cases when more specific properties (e.g. contentLocation, locationCreated, publicationLocation) are not known to be appropriate.
        /// </summary>
        [JsonProperty("spatial")]
        public Place Spatial { get; set; }

        /// <summary>
        /// Place - The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of contentLocation intended primarily for more technical and detailed materials.
        /// </summary>
        [JsonProperty("spatialCoverage")]
        public Place SpatialCoverage { get; set; }

        private Thing sponsor;
        /// <summary>
        /// Organization or Person - A person or organization that supports a thing through a pledge, promise, or financial contribution.
        /// </summary>
        [JsonProperty("sponsor")]
        public Thing Sponsor
        {
            get { return sponsor; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                sponsor = value;
            }
        }

        /// <summary>
        /// DefinedTerm or Text - The item being described is intended to assess the competency or learning outcome defined by the referenced term.
        /// </summary>
        [JsonProperty("teaches")]
        public string Teaches { get; set; }

        /// <summary>
        /// DateTime or Text - The "temporal" property can be used in cases where more specific properties (e.g. temporalCoverage, dateCreated, dateModified, datePublished) are not known to be appropriate.
        /// </summary>
        [JsonProperty("temporal")]
        public string Temporal { get; set; }

        /// <summary>
        /// DateTime, Text, or URL - The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in ISO 8601 time interval format.
        /// </summary>
        [JsonProperty("temporalCoverage")]
        public string TemporalCoverage { get; set; }

        /// <summary>
        /// Text -The textual content of this CreativeWork.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// ImageObject - Thumbnail image for an image or video.
        /// </summary>
        [JsonProperty("thumbnail")]
        public ImageObject Thumbnail { get; set; }

        /// <summary>
        /// URL - A thumbnail image relevant to the Thing.
        /// </summary>
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Duration - Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        /// </summary>
        [JsonProperty("timeRequired")]
        public Duration TimeRequired { get; set; }

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species”
        /// Inverse property: <see cref="WorkTranslation"/>.
        /// </summary>
        [JsonProperty("translationOfWork")]
        public CreativeWork TranslationOfWork { get; set; }

        /// <summary>
        /// Person  or Organization - Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market.
        /// </summary>
        [JsonProperty("translator")]
        public Thing Translator { get; set; }

        /// <summary>
        /// Text - The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [JsonProperty("typicalAgeRange")]
        public string TypicalAgeRange { get; set; }

        private object usageInfo;
        /// <summary>
        /// CreativeWork or URL - The schema.org usageInfo property indicates further information about a CreativeWork. This property is applicable both to works that are freely available and to those that require payment or other transactions.
        /// </summary>
        [JsonProperty("usageInfo")]
        public object UsageInfo
        {
            get { return usageInfo; }
            set
            {
                var validator = new TypeValidator(typeof(CreativeWork), typeof(string));
                validator.Validate(value);
                usageInfo = value;
            }
        }

        /// <summary>
        /// Number - The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [JsonProperty("version")]
        public Int32? Version { get; set; }

        /// <summary>
        /// VideoObject - An embedded video object.
        /// </summary>
        [JsonProperty("video")]
        public VideoObject Video { get; set; }

        /// <summary>
        /// Integer - The number of words in the text of the CreativeWork such as an Article, Report or NewsArticle.
        /// </summary>
        [JsonProperty("wordCount")]
        public Int32? WordCount { get; set; }

        /// <summary>
        /// CreativeWork - Example/instance/realization/derivation of the concept of this creative work. eg.
        /// The paperback edition, first edition, or eBook. 
        /// Inverse  property: <see cref="ExampleOfWork"/>.
        /// </summary>
        [JsonProperty("workExample")]
        public CreativeWork WorkExample { get; set; }

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation 
        /// “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese translation Tây du ký bình khảo.
        /// Inverse property: <see cref="TranslationOfWork"/>.
        /// </summary>
        [JsonProperty("workTranslation")]
        public CreativeWork WorkTranslation { get; set; }

        /// <summary>
        /// Date  or DateTime - Date the content expires and is no longer useful or available. 
        /// For example a VideoObject or <seealso cref="NewsArticle"/>  whose availability or relevance is time-limited, 
        /// or a <seealso cref="ClaimReview"/> fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
        /// </summary>
        [JsonProperty("expires")]
        public object Expires { get; set; }
    }
}
 