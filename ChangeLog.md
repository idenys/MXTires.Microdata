# MXTires.Microdata release notes
##Release v. 1.0.4.8
<i>Thing.SubjectOf</i> validator now accepts <i>Event</i> in addition to <i>CreativeWork</i>, matching schema.org's <i>CreativeWork | Event</i> union. Fixed <i>IBook.Isbn</i>/<i>Audiobook.Isbn</i> type mismatch (now <i>string</i>, matching <i>Book.Isbn</i>). Added <i>Thing.Owner</i> (<i>Organization</i> or <i>Person</i>), matching schema.org. Added <i>Action.ActionProcess</i> (<i>HowTo</i>) and <i>Action.Provider</i> (<i>Organization</i> or <i>Person</i>); <i>Action.Location</i> now also accepts Text and <i>VirtualLocation</i>. <i>CreativeWork</i> now models 47 additional schema.org properties (<i>abstract</i>, <i>accessMode</i>, <i>funder</i>, <i>funding</i>, <i>isAccessibleForFree</i>, <i>isBasedOn</i>, <i>size</i>, <i>spatial</i>, <i>thumbnail</i>, <i>wordCount</i>, and more); added new <i>Grant</i> and <i>InteractionCounter</i> types.

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