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
using MXTires.Microdata.Organizations.PerformingGroups;
using MXTires.Microdata.CreativeWorks;

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
        /// Person - Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [JsonProperty("accountablePerson")]
        public Person AccountablePerson { get; set; }

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
        /// Place - The location of the content.
        /// </summary>
        [JsonProperty("contentLocation")]
        public Place ContentLocation { get; set; }

        /// <summary>
        /// Text - Official rating of a piece of content—for example,'MPAA PG-13'.
        /// </summary>
        [JsonProperty("contentRating")]
        public string ContentRating { get; set; }

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
        /// Number - The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [JsonProperty("copyrightYear")]
        public Int32? CopyrightYear { get; set; }

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
        ///  URL - A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [JsonProperty("discussionUrl")]
        public string DiscussionUrl { get; set; }

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
        /// CreativeWork - A creative work that this work is an example/instance/realization/derivation of. Inverse property: workExample.
        /// </summary>
        [JsonProperty("exampleOfWork")]
        public CreativeWork ExampleOfWork { get; set; }

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
        /// Text - The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [JsonProperty("interactivityType")]
        public string InteractivityType { get; set; }

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
        /// Thing - Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [JsonProperty("mainEntity")]
        public Thing MainEntity { get; set; }

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
        /// Integer  or Text - The position of an item in a series or sequence of items.
        /// </summary>
        [JsonProperty("position")]
        public Int32? Position { get; set; }

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
        /// Organization - The publisher of the creative work.
        /// </summary>
        [JsonProperty("publisher")]
        public Organization Publisher { get; set; }

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
        /// Organization - The Organization on whose behalf the creator was working.
        /// </summary>
        [JsonProperty("sourceOrganization")]
        public Organization SourceOrganization { get; set; }

        /// <summary>
        /// Text -The textual content of this CreativeWork.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

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
 