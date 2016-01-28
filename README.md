# MXTires.Microdata
MXTires.Microdata is framework to correspond schema.org object types to .Net classes with conversion to JSON

## Prerequisites
Visual Studio 2008 or higher
[NuGet](https://github.com/paypal/rest-api-sdk-dotnet#nuget "NuGet")

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
## Dependencies
[Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/ "Newtonsoft.Json")(>= 7.0.0)