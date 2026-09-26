# MXTires.Microdata
MXTires.Microdata is framework to correspond schema.org object types to .Net classes with conversion to JSON

## Prerequisites
Visual Studio 2008 or higher
[NuGet](https://www.nuget.org/packages/MXTires.Microdata "NuGet")

## Code example of defining a Product:
[https://schema.org/Product](https://schema.org/Product/ "Product")
```
        public void SimpleProduct()
        {
            var product = new Product()
            {
                Name = "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            };
            Review review1 = new Review() { Name = "Review1", ReviewRating = new Rating() { RatingValue = "5" }, ReviewBody = "Best product ever!", Author = new Person() { Name = "Some Guy" } };
            Review review2 = new Review() { Name = "Review2",  ReviewRating = new Rating() { RatingValue = "4" }, ReviewBody = "I've seen better...", Author = new Person() { Name = "Other Guy" } };
            product.Reviews = new List<Review> { review1, review2 };
            System.Diagnostics.Debug.Write(product.ToJson());
        }
```

## Code example of defining an Event:
[https://schema.org/Event](https://schema.org/Event/ "Event")
```
        public void EventTest()
        {
            var baseEvent = new Event();
            baseEvent.Attendee = new Person();
            System.Diagnostics.Debug.WriteLine(baseEvent.ToIndentedJson());
        
        }
```
## Code example for image:
```
        [TestMethod]
        public void TestImageObject()
        {
            var blogPosting = new BlogPosting();
            blogPosting.Image = new ImageObject()
            {
                Url = "http://whatever.com/image.png",
                Width = new QuantitativeValue() { Value = 500 },
                Height = new QuantitativeValue() { Value = 500 }
            };

            System.Diagnostics.Debug.Write(blogPosting.ToIndentedJson());
        }
```
### Output:
```
<script type="application/ld+json">{
  "image": {
    "height": {
      "value": 500.0,
      "@type": "QuantitativeValue"
    },
    "width": {
      "value": 500.0,
      "@type": "QuantitativeValue"
    },
    "url": "http://whatever.com/image.png",
    "@type": "ImageObject"
  },
  "@context": "https://schema.org",
  "@type": "BlogPosting"
}</script>
```
`@context` is written on the root node only; nested nodes inherit it. Setting `Context` explicitly on a nested node still writes it there.

## Enumerations and dates
Enumeration values serialize as their schema.org (or GoodRelations) URI, and a `[Flags]` combination serializes as an array:
```
            var offer = new Offer
            {
                Availability = ItemAvailability.InStock,
                AvailableDeliveryMethod = DeliveryMethod.OnSitePickup | DeliveryMethod.UPS,
                PriceValidUntil = new DateTime(2026, 10, 25)
            };
```
```
{
  "availability": "https://schema.org/InStock",
  "availableDeliveryMethod": ["https://schema.org/OnSitePickup", "http://purl.org/goodrelations/v1#UPS"],
  "priceValidUntil": "2026-10-25",
  "@context": "https://schema.org",
  "@type": "Offer"
}
```
Enumeration and number/boolean properties are nullable, so anything left unset is omitted. Properties whose schema.org range is `Date` are written as `yyyy-MM-dd`.
If you serialize with your own `JsonSerializerSettings`, add `new SchemaEnumConverter()` (namespace `MXTires.Microdata.Serialization`) to its `Converters`.

## Code example with extentions:
```
        public void TestAtlas()
        {
            var atlas = new Atlas();
            atlas.Context = new List<object>() { "https://schema.org", new Extentions.BibNameSpace(), };
            atlas.Name = "Atlas of the world.";
            System.Diagnostics.Debug.WriteLine(atlas.ToIndentedJson());
        }
```
### Output:
```
<script type="application/ld+json">{
  "name": "Atlas of the world.",
  "@context": [
    "https://schema.org",
    {
      "bib": "http://bib.schema.org"
    }
  ],
  "@type": "Atlas"
}</script>
```

## Dependencies
[Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/ "Newtonsoft.Json") (>= 13.0.3)



## License

[1010Tires.com](http://www.1010tires.com/). License - [License.md](https://github.com/idenys/MXTires.Microdata/blob/master/License.md)
