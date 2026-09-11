# MXTires.Microdata release notes
##Release v. 1.0.4.8
<i>Thing.SubjectOf</i> validator now accepts <i>Event</i> in addition to <i>CreativeWork</i>, matching schema.org's <i>CreativeWork | Event</i> union. Fixed <i>IBook.Isbn</i>/<i>Audiobook.Isbn</i> type mismatch (now <i>string</i>, matching <i>Book.Isbn</i>). Added <i>Thing.Owner</i> (<i>Organization</i> or <i>Person</i>), matching schema.org. Added <i>Action.ActionProcess</i> (<i>HowTo</i>) and <i>Action.Provider</i> (<i>Organization</i> or <i>Person</i>); <i>Action.Location</i> now also accepts Text and <i>VirtualLocation</i>. <i>CreativeWork</i> now models 47 additional schema.org properties (<i>abstract</i>, <i>accessMode</i>, <i>funder</i>, <i>funding</i>, <i>isAccessibleForFree</i>, <i>isBasedOn</i>, <i>size</i>, <i>spatial</i>, <i>thumbnail</i>, <i>wordCount</i>, and more); added new <i>Grant</i> and <i>InteractionCounter</i> types. <i>Organization</i> now models 35 additional schema.org properties (<i>acceptedPaymentMethod</i>, <i>areaServed</i>, <i>hasCertification</i>, <i>hasCredential</i>, <i>hasMemberProgram</i>, <i>knowsAbout</i>, <i>numberOfEmployees</i>, <i>parentOrganization</i>, <i>sponsor</i>, and more); added new <i>Certification</i>, <i>Credential</i>, <i>MemberProgram</i>, and <i>ShippingService</i> types. <i>Place</i> now models 25 additional schema.org properties (<i>amenityFeature</i>, <i>containedInPlace</i>, <i>containsPlace</i>, the <i>geoContains</i>/<i>geoWithin</i>/etc. topology relations, <i>hasCertification</i>, <i>latitude</i>, <i>longitude</i>, <i>maximumAttendeeCapacity</i>, <i>slogan</i>, <i>smokingAllowed</i>, <i>tourBookingPage</i>, and more). <i>Product</i> now models 26 additional schema.org properties (<i>asin</i>, <i>colorSwatch</i>, <i>countryOfOrigin</i>, <i>funding</i>, <i>gtin</i>, <i>hasCertification</i>, <i>isFamilyFriendly</i>, <i>isVariantOf</i>, <i>keywords</i>, <i>material</i>, <i>size</i>, <i>slogan</i>, and more). Removed 9 redundant property overrides now inherited from the base classes above (<i>MediaObject.EncodingFormat</i>/<i>InterpretedAsClaim</i>, <i>Article.WordCount</i>, <i>EducationalOrganization.Alumni</i>, <i>VideoObject.Thumbnail</i>, <i>ImageObject.Thumbnail</i>, <i>Episode.IsAccessibleForFree</i>, <i>TVSeason</i>/<i>TVSeries.CountryOfOrigin</i>). <i>Offer</i> now models 14 additional schema.org properties (<i>additionalProperty</i>, <i>aggregateRating</i>, <i>areaServed</i>, <i>gtin</i>, <i>hasMeasurement</i>, <i>isFamilyFriendly</i>, <i>leaseLength</i>, <i>offeredBy</i>, <i>validForMemberTier</i>, and more). <i>Person</i> now models 14 additional schema.org properties (<i>agentInteractionStatistic</i>, <i>callSign</i>, <i>children</i>, <i>funding</i>, <i>hasCertification</i>, <i>hasCredential</i>, <i>hasOccupation</i>, <i>interactionStatistic</i>, <i>knowsAbout</i>, <i>knowsLanguage</i>, <i>lifeEvent</i>, <i>pronouns</i>, <i>publishingPrinciples</i>, <i>skills</i>); added new <i>Occupation</i> type. Fixed <i>Person.Address</i> (was incorrectly typed <i>Organization</i>, now <i>PostalAddress</i>). Fixed two copy-paste bugs where <i>Person.Height</i>'s getter returned <i>WorkLocation</i> and <i>Person.Sponsor</i>'s getter/setter read/wrote <i>HomeLocation</i> instead of their own backing fields.

##Release v. 1.0.4.7
Added net10.0 target framework. Fixed duplicate <i>identifier</i> serialization on <i>JobPosting</i>. <i>PriceSpecification.MembershipPointsEarned</i> now accepts a Number (any numeric type) or <i>QuantitativeValue</i>, matching schema.org. <i>TypeValidator</i> now checks type assignability instead of exact type equality, so list-typed union properties (e.g. <i>Offer.PriceSpecification</i>) correctly accept concrete list implementations like <i>List&lt;T&gt;</i>.

##Release v. 1.0.2.8
Fixed Local Business properties

##Release v. 1.0.2.6
Birth date optional for a <i>Person</i>

##Release v. 1.0.2.6
ToString() method that converts every Thing to JSON-LD without surrounding script tags. Logo in <i>Organization</i> accepts <i>ImageObject</i>.

##Release v. 1.0.2.5
Changed Image property of Thing to generic object type so it would be capable of taking ImageObject type.

##Release v. 1.0.2.3
Compatibility is broken. Name space <i>MXTires.Microdata.Intangible.StructuredValue</i> changed to <i>MXTires.Microdata.Intangible.StructuredValues</i> for consistency

##Release v. 1.0.2.2
Added more LocalBusinesses and Intangibles