using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MXTires.Microdata
{
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
        public string accessibilityAPI { get; set; }
        /// <summary>
        /// Text 	Identifies input methods that are sufficient to fully control the described resource (WebSchemas wiki lists possible values).
        /// </summary>
        public string accessibilityControl { get; set; }

        /// <summary>
        /// Text 	Content features of the resource, such as accessible media, alternatives and supported enhancements for 
        /// accessibility (WebSchemas wiki lists possible values).
        /// </summary>
        public string accessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. 
        /// Related to WCAG 2.0 guideline 2.3. (WebSchemas wiki lists possible values)
        /// </summary>
        public string accessibilityHazard { get; set; }
        /// <summary>
        /// Person 	Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        public Person accountablePerson { get; set; }

        /// <summary>
        /// AggregateRating 	The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        public AggregateRating aggregateRating { get; set; }
        /// <summary>
        /// Text 	A secondary title of the CreativeWork.
        /// </summary>
        public string alternativeHeadline { get; set; }

        /// <summary>
        /// MediaObject 	A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        public MediaObject associatedMedia { get; set; }
        /// <summary>
        /// Audience 	The intended audience of the item, i.e. the group for whom the item was created.
        /// </summary>
        public Audience audience { get; set; }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        public AudioObject audio { get; set; }
        /// <summary>
        /// Person  or 
        /// Organization 	The author of this content. 
        /// Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. 
        /// That is equivalent to this and may be used interchangeably.
        /// </summary>
        public Author author { get; set; }
        /// <summary>
        /// Text 	An award won by this person or for this creative work. Supersedes awards.
        /// </summary>
        public string award { get; set; }
        /// <summary>
        /// Person 	Fictional person connected with a creative work.
        /// </summary>
        public Person character { get; set; }

        /// <summary>
        /// 	CreativeWork  {get;set;} or 
        ///     Text 	A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [JsonProperty("citation")]
        public CreativeWork Citation { get; set; }
        /// <summary>
        /// UserComments  or Comment - Comments, typically from users, on this CreativeWork.
        /// </summary>
        public Event comment { get; set; }

        /// <summary>
        /// Integer 	The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        public Int32? commentCount { get; set; }
        /// <summary>
        /// Place - The location of the content.
        /// </summary>
        public Place contentLocation { get; set; }
        /// <summary>
        /// Text 	Official rating of a piece of content—for example,'MPAA PG-13'.
        /// </summary>
        public string contentRating { get; set; }
        /// <summary>
        /// Person  or Organization - A secondary contributor to the CreativeWork.
        /// </summary>
        public Thing contributor { get; set; }
        /// <summary>
        /// Person  or Organization - The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [JsonProperty("copyrightHolder")]
        public Thing CopyrightHolder { get; set; }

        /// <summary>
        /// Number 	The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [JsonProperty("copyrightYear")]
        public Int32? CopyrightYear { get; set; }

        /// <summary>
        /// Person  or Organization - The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
        /// </summary>
        public Thing creator { get; set; }

        /// <summary>
        /// Date 	The date on which the CreativeWork was created.
        /// </summary>
        public DateTime? dateCreated { get; set; }
        /// <summary>
        /// Date 	The date on which the CreativeWork was most recently modified.
        /// </summary>
        public DateTime? dateModified { get; set; }
        /// <summary>
        /// Date 	Date of first broadcast/publication.
        /// </summary>
        public DateTime? datePublished { get; set; }

        /// <summary>
        ///  URL 	A link to the page containing the comments of the CreativeWork.
        /// </summary>
        public URL discussionUrl { get; set; }

        /// <summary>
        /// Person 	Specifies the Person who edited the CreativeWork.
        /// </summary>
        public Person editor { get; set; }

        /// <summary>
        /// AlignmentObject 	An alignment to an established educational framework.
        /// </summary>
        public AlignmentObject educationalAlignment { get; set; }
        /// <summary>
        /// Text 	The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        public string educationalUse { get; set; }
        /// <summary>
        /// MediaObject 	A media object that encodes this CreativeWork. This property is a synonym for associatedMedia. Supersedes encodings.
        /// </summary>
        public MediaObject encoding { get; set; }

        /// <summary>
        /// CreativeWork - A creative work that this work is an example/instance/realization/derivation of. Inverse property: workExample.
        /// </summary>
        public CreativeWork exampleOfWork { get; set; }
        /// <summary>
        /// Text - Genre of the creative work or group.
        /// </summary>
        public string genre { get; set; }

        /// <summary>
        /// CreativeWork - Indicates a CreativeWork that is (in some sense) a part of this CreativeWork. Inverse property: isPartOf.
        /// </summary>
        public CreativeWork hasPart { get; set; }

        /// <summary>
        /// Text -	Headline of the article
        /// </summary>
        public string headline { get; set; }

        /// <summary>
        /// Text - The language of the content. please use one of the language codes from the IETF BCP 47 standard.
        /// </summary>
        public string inLanguage { get; set; }

        /// <summary>
        /// Text 	A count of a specific user interactions with this item—for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.
        /// </summary>
        public string interactionCount { get; set; }

        /// <summary>
        /// Text - The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        public string interactivityType { get; set; }

        /// <summary>
        /// URL 	A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html
        /// </summary>
        public URL isBasedOnUrl { get; set; }

        /// <summary>
        /// Boolean 	Indicates whether this content is family friendly.
        /// </summary>
        public bool? isFamilyFriendly { get; set; }
        /// <summary>
        /// CreativeWork 	Indicates a CreativeWork that this CreativeWork is (in some sense) part of.
        /// Inverse property: hasPart.
        /// </summary>
        public CreativeWork isPartOf { get; set; }

        /// <summary>
        /// Text -	Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Text - The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        public string learningResourceType { get; set; }

        /// <summary>
        /// URL  or CreativeWork - A license document that applies to this content, typically indicated by URL.
        /// </summary>
        public Thing license { get; set; }
        /// <summary>
        /// Thing 	Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        public Thing mentions { get; set; }
        /// <summary>
        /// Offer 	An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        public Offer offers { get; set; }
        /// <summary>
        /// Integer  or Text - The position of an item in a series or sequence of items.
        /// </summary>
        public Int32? position { get; set; }

        /// <summary>
        /// Person  or  Organization  -	The service provider, service operator, or service performer; 
        /// the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. 
        /// A provider may also serve as the seller. Supersedes carrier.
        /// </summary>
        public Thing provider { get; set; }

        /// <summary>
        /// Organization - The publisher of the creative work.
        /// </summary>
        public Organization publisher { get; set; }
        /// <summary>
        /// URL - Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
        /// </summary>
        public URL publishingPrinciples { get; set; }

        /// <summary>
        /// Event -	The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// Inverse property: recordedIn.
        /// </summary>
        public Event recordedAt { get; set; }

        /// <summary>
        /// PublicationEvent 	The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        public PublicationEvent releasedEvent { get; set; }

        /// <summary>
        /// Review 	A review of the item. Supersedes reviews.
        /// </summary>
        public Review review { get; set; }
        /// <summary>
        /// Organization - The Organization on whose behalf the creator was working.
        /// </summary>
        public Organization sourceOrganization { get; set; }
        /// <summary>
        /// Text -The textual content of this CreativeWork.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// URL - A thumbnail image relevant to the Thing.
        /// </summary>
        public URL thumbnailUrl { get; set; }

        /// <summary>
        /// Duration 	Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        /// </summary>
        public Duration timeRequired { get; set; }

        /// <summary>
        /// Person  or Organization - Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market.
        /// </summary>
        public Thing translator { get; set; }

        /// <summary>
        /// Text 	The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        public string typicalAgeRange { get; set; }

        /// <summary>
        /// Number - The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        public Int32? version { get; set; }

        /// <summary>
        /// VideoObject 	An embedded video object.
        /// </summary>
        public VideoObject video { get; set; }

        /// <summary>
        /// CreativeWork 	Example/instance/realization/derivation of the concept of this creative work. eg. 
        /// The paperback edition, first edition, or eBook. 
        /// Inverse  property: exampleOfWork.
        /// </summary>
        public CreativeWork workExample { get; set; }
    }
}