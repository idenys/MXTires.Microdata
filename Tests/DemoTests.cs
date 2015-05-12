using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MXTires.Microdata;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Intangible.StructuredValue;

namespace MXTires.Microdata.Tests
{
    [TestClass]
    public class DemoTests
    {
        [TestMethod]
        public void SimpleProductTest()
        {
            var product = new Product()
            {
                Name = "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            };

            System.Diagnostics.Debug.Write(product.ToJson());
        }

        [TestMethod]
        public void LocalBusinessTest()
        {
            LocalBusiness shop = new LocalBusiness()
            {
                Name = "1010Tires.com",
                Description = "Sell Wheels and Tires.",
                CurrenciesAccepted = "USD, CAD",
            };

            Language language = new Language() { Name = "English, French" }; //may need more differentiation
            shop.Address = new PostalAddress()
            {
                AddressCountry = "CA",
                AddressRegion = "BC",
                AddressLocality = "Vancouver",
                PostalCode = "V5X 2T7",
                StreetAddress = "732 Southeast Marine Drive",
                AreaServed = "Vancouver",
                AvailableLanguage = language,
                Email = "supposrt@1010tires.com",
                Telephone = "604-324-5999",
            };
            shop.Location = new Place();
            shop.Location.Geo = new GeoCoordinates("49.210978", "-123.089581");           

            OpeningHoursSpecification mondayHours = new OpeningHoursSpecification("5:30 PM", DaysOfWeek.Mo,"9:00 AM");
            
            shop.Location.OpeningHoursSpecification = new List<OpeningHoursSpecification>();
            shop.Location.OpeningHoursSpecification.Add(mondayHours);

            System.Diagnostics.Debug.Write(shop.ToJson());
        }

        [TestMethod]
        public void SimpleOfferTest()
        {
            var offer = new Offer()
            {
                Name = "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            };
            offer.Availability = ItemAvailability.InStock | ItemAvailability.Discontinued;
            offer.Reviews = new List<Review>();
            offer.Reviews.Add(new Review() {  ItemReviewed = new Thing(), });
            offer.AcceptedPaymentMethod = PaymentMethod.VisaCheckout | PaymentMethod.PayPal;
            System.Diagnostics.Debug.WriteLine(offer.ToIndentedJson());

            // <script type="application/ld+json">{
            //  "reviews": [
            //    {
            //      "itemReviewed": {
            //        "@context": "http://schema.org",
            //        "@type": "Thing"
            //      },
            //      "author": {
            //        "name": "a guy",
            //        "@context": "http://schema.org",
            //        "@type": "Person"
            //      },
            //      "@context": "http://schema.org",
            //      "@type": "Review"
            //    }
            //  ],
            //  "availability": "http://schema.org/Discontinued, http://schema.org/InStock",
            //  "businessFunction": "http://purl.org/goodrelations/v1#Sell",
            //  "itemCondition": "NewCondition",
            //  "name": "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            //  "@context": "http://schema.org",
            //  "@type": "Offer"
            //}</script>
        }

        [TestMethod]
        public void BreadcrumbListTest()
        {
            var breadcrumbList = new BreadcrumbList();
            breadcrumbList.ItemListElement = new LinkedList<ListItem>();
            breadcrumbList.ItemListElement.AddLast(new ListItem()
            {
                Item = new Thing() { Name = "Home", Url = "http://www.1010tires.com/", Id = "http://www.1010tires.com/" },

            });
            breadcrumbList.ItemListElement.AddLast(new ListItem()
            {
                Item = new Thing() { Name = "Tires by Brand", Url = "http://www.1010tires.com/Tires/Search", Id = "http://www.1010tires.com/Tires/Search", },
            });

            if (breadcrumbList.ItemListOrder == ItemListOrderType.ItemListOrderAscending)
            {
                var i = 1;
                for (LinkedListNode<ListItem> currentNode = breadcrumbList.ItemListElement.First; currentNode != null; currentNode = currentNode.Next)
                {
                    currentNode.Value.Position = i++;
                    //currentNode.Value.Type = currentNode.Value.Url;                    
                    //currentNode.Value.NextItem = currentNode.Next == null ? null : currentNode.Next.Value;
                    //currentNode.Value.PreviousItem = currentNode.Previous == null ? null : currentNode.Previous.Value;
                }
            }

            System.Diagnostics.Debug.WriteLine(breadcrumbList.ToIndentedJson());

            //<script type="application/ld+json">{
            //  "itemListElement": [
            //    {
            //      "item": {
            //        "additionalType": null,
            //        "alternateName": null,
            //        "description": null,
            //        "image": null,
            //        "name": "Home",
            //        "potentialAction": null,
            //        "sameAs": null,
            //        "url": "http://www.1010tires.com/",
            //        "@context": "http://schema.org",
            //        "@type": "Thing"
            //      },
            //      "nextItem": null,
            //      "position": 1,
            //      "previousItem": null,
            //      "additionalType": null,
            //      "alternateName": null,
            //      "description": null,
            //      "image": null,
            //      "name": null,
            //      "potentialAction": null,
            //      "sameAs": null,
            //      "url": null,
            //      "@context": "http://schema.org",
            //      "@type": "ListItem"
            //    },
            //    {
            //      "item": {
            //        "additionalType": null,
            //        "alternateName": null,
            //        "description": null,
            //        "image": null,
            //        "name": "Tires by Brand",
            //        "potentialAction": null,
            //        "sameAs": null,
            //        "url": "http://www.1010tires.com/Tires/Search",
            //        "@context": "http://schema.org",
            //        "@type": "Thing"
            //      },
            //      "nextItem": null,
            //      "position": 2,
            //      "previousItem": null,
            //      "additionalType": null,
            //      "alternateName": null,
            //      "description": null,
            //      "image": null,
            //      "name": null,
            //      "potentialAction": null,
            //      "sameAs": null,
            //      "url": null,
            //      "@context": "http://schema.org",
            //      "@type": "ListItem"
            //    }
            //  ],
            //  "itemListOrder": "ItemListOrderAscending",
            //  "numberOfItems": 0,
            //  "additionalType": null,
            //  "alternateName": null,
            //  "description": null,
            //  "image": null,
            //  "name": null,
            //  "potentialAction": null,
            //  "sameAs": null,
            //  "url": null,
            //  "@context": "http://schema.org",
            //  "@type": "BreadcrumbList"
            //}</script>
        }

        [TestMethod]
        public void TireTest()
        {
            var tire = new Tire() { Name = "T3 Tire" };
            System.Diagnostics.Debug.WriteLine(tire.ToIndentedJson());

            //<script type="application/ld+json">{
            //  "additionalType": "http://www.productontology.org/id/Tire",
            //  "name": "T3 Tire",
            //  "sameAs": [
            //    "http://en.wikipedia.org/wiki/Tire",
            //    "http://www.1010tires.com/About/Tire-Tech"
            //  ],
            //  "@context": "http://schema.org",
            //  "@type": "Product/Tire"
            //}</script>
        }

        [TestMethod]
        public void EventTest()
        {
            var baseEvent = new Event();
            baseEvent.Attendee = new Person();
            System.Diagnostics.Debug.WriteLine(baseEvent.ToIndentedJson());
        
        }
    }
}
