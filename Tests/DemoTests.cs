using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MXTires.Microdata;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Events;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace MXTires.Microdata.Tests
{
    [TestClass]
    public class DemoTests
    {
        /// <summary>
        /// Product to JSON-LD 
        /// </summary>
        [TestMethod]
        public void SimpleProductTest()
        {
            var product = new Product()
            {
                Name = "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            };
            Review review1 = new Review() { Name = "Review1", ReviewRating = new Rating() { RatingValue = "5" }, ReviewBody = "Best product ever!", Author = new Person() { Name = "Some Guy" } };
            Review review2 = new Review() { Name = "Review2", ReviewRating = new Rating() { RatingValue = "4" }, ReviewBody = "I've seen better...", Author = new Person() { Name = "Other Guy" } };
            product.Reviews = new List<Review> { review1, review2 };
            System.Diagnostics.Debug.Write(product.ToJson());
        }

        /// <summary>
        /// Organization with Multiple Addresses to JSON-LD
        /// </summary>
        [TestMethod]
        public void OrganizationMultipleAddresses()
        {
            var org = new Organization()
            {
                Name = "My Test Organization",
                Addresses = new List<PostalAddress>()
                {
                    new PostalAddress()
                    {
                        Name = "Location 1",
                        StreetAddress = "123 Somewhere Road",
                        AddressRegion = "Liverpool",
                        AddressCountry = "United Kingdom"
                    },
                    new PostalAddress()
                    {
                        Name = "Location 2",
                        AddressLocality = "Mountain View",
                        AddressRegion = "Califronia",
                        AddressCountry = "USA"
                    },
                }

            };

            System.Diagnostics.Debug.Write(org.ToIndentedJson());
        }

        /// <summary>
        /// Organization with Single Address to JSON-LD
        /// </summary>
        [TestMethod]
        public void OrganizationSingleAddress()
        {
            var org = new Organization()
            {
                Name = "My Test Organization",
                Address = new PostalAddress()
                {
                    Name = "Location 1",
                    StreetAddress = "123 Somewhere Road",
                    AddressRegion = "Liverpool",
                    AddressCountry = "United Kingdom"
                }
            };

            System.Diagnostics.Debug.Write(org.ToIndentedJson());
        }

        /// <summary>
        /// JobPosting with multiple locations to JSON-LD
        /// </summary>
        [TestMethod]
        public void JobPostingMultipleLocation()
        {
            var posting = new JobPosting()
            {
                Name = "My Job Posting",
                DatePosted = DateTime.Now,
                Description = "This is my job description",
                JobLocations = new List<Place>()
                {
                    new Place()
                    {
                        Name = "Location 1",
                        Address = new PostalAddress()
                        {
                            Name = "Location 1 House",
                            AddressRegion = "Liverpool",
                            AddressCountry = "United Kingdom"
                        }
                    },
                    new Place()
                    {
                        Name = "Location 2",
                        Address = new PostalAddress()
                        {
                            Name = "Location 2 House",
                            AddressRegion = "New York",
                            AddressCountry = "USA"
                        }
                    }
                }
            };

            System.Diagnostics.Debug.Write(posting.ToIndentedJson());
        }

        /// <summary>
        /// JobPosting with single location to JSON-LD
        /// </summary>
        [TestMethod]
        public void JobPostingSingleLocation()
        {
            var posting = new JobPosting()
            {
                Name = "My Job Posting",
                DatePosted = DateTime.Now,
                Description = "This is my job description",
                JobLocation = new Place()
                {
                    Name = "Location 1",
                    Address = new PostalAddress()
                    {
                        Name = "Location 1 House",
                        AddressRegion = "Liverpool",
                        AddressCountry = "United Kingdom"
                    }
                }

            };

            System.Diagnostics.Debug.Write(posting.ToIndentedJson());
        }

        [TestMethod]
        public void JobPostingIdentifierSerializesOnce()
        {
            var posting = new JobPosting()
            {
                Identifier = new List<PropertyValue>
                {
                    new PropertyValue("identifier", "job-123")
                }
            };

            var json = JObject.Parse(posting.ToString());

            Assert.AreEqual(1, json.Properties().Count(property => property.Name == "identifier"));
            Assert.AreEqual("job-123", (string)json["identifier"][0]["value"]);
        }

        /// <summary>
        /// LocalBusiness to JSON-LD 
        /// </summary>
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

            OpeningHoursSpecification mondayHours = new OpeningHoursSpecification("5:30 PM", DaysOfWeek.Mo, "9:00 AM");

            shop.Location.OpeningHoursSpecification = new List<OpeningHoursSpecification>();
            shop.Location.OpeningHoursSpecification.Add(mondayHours);

            System.Diagnostics.Debug.Write(shop.ToJson());
        }

        /// <summary>
        /// Offer to JSON-LD 
        /// </summary>
        [TestMethod]
        public void SimpleOfferTest()
        {
            var offer = new Offer()
            {
                Name = "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            };
            offer.Availability = ItemAvailability.InStock | ItemAvailability.Discontinued;
            offer.Reviews = new List<Review>();
            offer.Reviews.Add(new Review() { ItemReviewed = new Thing(), });
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
        public void MembershipPointsEarnedAcceptsNumberAndQuantitativeValue()
        {
            var specification = new PriceSpecification
            {
                MembershipPointsEarned = 10
            };

            Assert.AreEqual(10, specification.MembershipPointsEarned);

            var points = new QuantitativeValue() { Value = 10, UnitCode = "miles" };
            specification.MembershipPointsEarned = points;

            Assert.AreSame(points, specification.MembershipPointsEarned);
        }

        [TestMethod]
        public void MembershipPointsEarnedRejectsInvalidTypes()
        {
            var specification = new PriceSpecification();

            Assert.ThrowsExactly<ArgumentException>(() => specification.MembershipPointsEarned = "10");
        }

        [TestMethod]
        public void OfferPriceSpecificationAcceptsListOfPriceSpecification()
        {
            var offer = new Offer();
            var specifications = new List<PriceSpecification> { new PriceSpecification { Price = "10" } };

            offer.PriceSpecification = specifications;

            Assert.AreSame(specifications, offer.PriceSpecification);
        }

        [TestMethod]
        public void ThingSubjectOfAcceptsEvent()
        {
            var thing = new Product();
            var subjectEvent = new Event { Name = "Launch Event" };

            thing.SubjectOf = subjectEvent;

            Assert.AreSame(subjectEvent, thing.SubjectOf);
        }

        [TestMethod]
        public void ThingOwnerAcceptsOrganizationAndPerson()
        {
            var thing = new Product();
            var org = new Organization { Name = "1010Tires.com" };

            thing.Owner = org;
            Assert.AreSame(org, thing.Owner);

            var person = new Person { Name = "Some Guy" };
            thing.Owner = person;
            Assert.AreSame(person, thing.Owner);
        }

        [TestMethod]
        public void ThingOwnerRejectsInvalidTypes()
        {
            var thing = new Product();

            Assert.ThrowsExactly<ArgumentException>(() => thing.Owner = "not an owner");
        }

        [TestMethod]
        public void ActionProviderAcceptsOrganizationAndPerson()
        {
            var action = new Action();
            var provider = new Organization { Name = "1010Tires.com" };

            action.Provider = provider;

            Assert.AreSame(provider, action.Provider);
        }

        [TestMethod]
        public void ActionLocationAcceptsPlacePostalAddressTextAndVirtualLocation()
        {
            var action = new Action();

            action.Location = new Place { Name = "Venue" };
            Assert.IsInstanceOfType(action.Location, typeof(Place));

            action.Location = new PostalAddress { StreetAddress = "123 Somewhere Road" };
            Assert.IsInstanceOfType(action.Location, typeof(PostalAddress));

            action.Location = "Online";
            Assert.AreEqual("Online", action.Location);

            var virtualLocation = new VirtualLocation();
            action.Location = virtualLocation;
            Assert.AreSame(virtualLocation, action.Location);
        }

        [TestMethod]
        public void ActionLocationRejectsInvalidTypes()
        {
            var action = new Action();

            Assert.ThrowsExactly<ArgumentException>(() => action.Location = 42);
        }

        [TestMethod]
        public void CreativeWorkIsBasedOnAcceptsCreativeWorkProductAndText()
        {
            var work = new Article();

            var basis = new Article { Name = "Original" };
            work.IsBasedOn = basis;
            Assert.AreSame(basis, work.IsBasedOn);

            var product = new Product { Name = "Kit" };
            work.IsBasedOn = product;
            Assert.AreSame(product, work.IsBasedOn);

            work.IsBasedOn = "http://example.com/original";
            Assert.AreEqual("http://example.com/original", work.IsBasedOn);
        }

        [TestMethod]
        public void CreativeWorkIsBasedOnRejectsInvalidTypes()
        {
            var work = new Article();

            Assert.ThrowsExactly<ArgumentException>(() => work.IsBasedOn = 42);
        }

        [TestMethod]
        public void CreativeWorkSizeAcceptsQuantitativeValueAndText()
        {
            var work = new Article();

            work.Size = "XL";
            Assert.AreEqual("XL", work.Size);

            var quantitativeValue = new QuantitativeValue { Value = 10, UnitCode = "CMT" };
            work.Size = quantitativeValue;
            Assert.AreSame(quantitativeValue, work.Size);
        }

        [TestMethod]
        public void CreativeWorkFunderAndFundingAcceptDocumentedTypes()
        {
            var work = new Article();
            var funder = new Organization { Name = "Funding Org" };

            work.Funder = funder;
            Assert.AreSame(funder, work.Funder);

            var grant = new Grant { Funder = funder };
            work.Funding = grant;
            Assert.AreSame(grant, work.Funding);
        }

        [TestMethod]
        public void OrganizationAreaServedAcceptsDocumentedTypes()
        {
            var org = new Organization();

            org.AreaServed = "Worldwide";
            Assert.AreEqual("Worldwide", org.AreaServed);

            var place = new Place { Name = "Vancouver" };
            org.AreaServed = place;
            Assert.AreSame(place, org.AreaServed);
        }

        [TestMethod]
        public void OrganizationAreaServedRejectsInvalidTypes()
        {
            var org = new Organization();

            Assert.ThrowsExactly<ArgumentException>(() => org.AreaServed = 42);
        }

        [TestMethod]
        public void OrganizationKnowsAboutAcceptsThingAndText()
        {
            var org = new Organization();

            org.KnowsAbout = "Tires";
            Assert.AreEqual("Tires", org.KnowsAbout);

            var topic = new Product { Name = "All-season tires" };
            org.KnowsAbout = topic;
            Assert.AreSame(topic, org.KnowsAbout);
        }

        [TestMethod]
        public void OrganizationSponsorAcceptsOrganizationAndPerson()
        {
            var org = new Organization();
            var sponsor = new Person { Name = "Some Guy" };

            org.Sponsor = sponsor;

            Assert.AreSame(sponsor, org.Sponsor);
        }

        [TestMethod]
        public void OrganizationAcceptedPaymentMethodAcceptsEnum()
        {
            var org = new Organization
            {
                AcceptedPaymentMethod = PaymentMethod.VisaCheckout | PaymentMethod.PayPal
            };

            Assert.AreEqual(PaymentMethod.VisaCheckout | PaymentMethod.PayPal, org.AcceptedPaymentMethod);
        }

        [TestMethod]
        public void PlaceContainmentAndTopologyPropertiesRoundTrip()
        {
            var place = new Place { Name = "Store" };
            var container = new Place { Name = "Mall" };
            var contained = new Place { Name = "Kiosk" };

            place.ContainedInPlace = container;
            place.ContainsPlace = contained;
            place.GeoWithin = container;

            Assert.AreSame(container, place.ContainedInPlace);
            Assert.AreSame(contained, place.ContainsPlace);
            Assert.AreSame(container, place.GeoWithin);
        }

        [TestMethod]
        public void PlaceHasCertificationAndAmenityFeature()
        {
            var place = new Place { Name = "Hotel" };
            var certification = new Certification { Name = "ISO 9001" };
            var amenity = new LocationFeatureSpecification("Free WiFi", true, null, null, null);

            place.HasCertification = certification;
            place.AmenityFeature = new List<LocationFeatureSpecification> { amenity };

            Assert.AreSame(certification, place.HasCertification);
            Assert.AreEqual(1, place.AmenityFeature.Count);
            Assert.AreSame(amenity, place.AmenityFeature[0]);
        }

        [TestMethod]
        public void ProductIsVariantOfAcceptsProductModelAndText()
        {
            var product = new Product();

            product.IsVariantOf = "https://example.com/models/base-model";
            Assert.AreEqual("https://example.com/models/base-model", product.IsVariantOf);

            var model = new ProductModel { Name = "Base Model" };
            product.IsVariantOf = model;
            Assert.AreSame(model, product.IsVariantOf);
        }

        [TestMethod]
        public void ProductNegativeAndPositiveNotesAcceptDocumentedTypes()
        {
            var product = new Product();

            product.PositiveNotes = "Great value";
            Assert.AreEqual("Great value", product.PositiveNotes);

            var notes = new ItemList();
            product.NegativeNotes = notes;
            Assert.AreSame(notes, product.NegativeNotes);
        }

        [TestMethod]
        public void ProductNegativeNotesRejectsInvalidTypes()
        {
            var product = new Product();

            Assert.ThrowsExactly<ArgumentException>(() => product.NegativeNotes = 42);
        }

        [TestMethod]
        public void ProductColorSwatchAndCertification()
        {
            var product = new Product();
            var certification = new Certification { Name = "Energy Star" };

            product.ColorSwatch = "https://example.com/swatch.png";
            product.HasCertification = certification;

            Assert.AreEqual("https://example.com/swatch.png", product.ColorSwatch);
            Assert.AreSame(certification, product.HasCertification);
        }

        /// <summary>
        /// BreadcrumbList to JSON-LD
        /// </summary>
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

        /// <summary>
        /// Tire object to JSON-LD 
        /// </summary>
        [TestMethod]
        public void TireTest()
        {
            var tire = new Tire() { Name = "T3 Tire" };

            PropertyValue additionalProperty = new PropertyValue(name: "Specs", value: "265/60R18");
            IList<PropertyValue> additionalProperties = new List<PropertyValue>();
            additionalProperties.Add(additionalProperty);
            additionalProperties.Add(new PropertyValue("SpeedRating", "Q"));
            additionalProperties.Add(new PropertyValue("LoadIndex", "116"));
            additionalProperties.Add(new PropertyValue("SideWall", "BLK"));

            tire.AdditionalProperty = additionalProperties;

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

        /// <summary>
        /// Event object to JSON-LD 
        /// </summary>
        [TestMethod]
        public void EventTest()
        {
            WebPage webPage = new WebPage();
            webPage.Id = "/events";
            webPage.Url = "http://www.1010tires.com/";

            var baseEvent = new Event();
            baseEvent.Attendee = new Person();
            System.Diagnostics.Debug.WriteLine(baseEvent.ToIndentedJson());

            var eventsList = new ItemList();
            eventsList.ItemListElement = new LinkedList<ListItem>();
            eventsList.ItemListElement.AddLast(new ListItem()
            {
                Item = new MusicEvent()
                {
                    Name = "Boz Scaggs",
                    StartDate = "2014-10-10T19:30",
                    Location = new Place() { Name = "Warner Theatre", Address = new PostalAddress() { AddressLocality = "Washington, DC" } },
                    Offers = new List<Offer>() { new Offer() { Url = "https://www.etix.com/ticket/1771656" } }
                },
                Position = 1
            });
            eventsList.ItemListElement.AddLast(new ListItem()
            {
                Item = new MusicEvent()
                {
                    Name = "Boz Scaggs",
                    StartDate = "2015-05-02T20:00",
                    Location = new Place() { Name = "Coral Springs Center for the Performing Arts", Address = new PostalAddress() { AddressLocality = "Coral Springs, FL" } },
                    Offers = new List<Offer>() { new Offer() { Url = "http://frontgatetickets.com/venue.php?id=11766" } }
                },
                Position = 2

            });

            System.Diagnostics.Debug.WriteLine(eventsList.ToIndentedJson());

            var musicEvent = new MusicEvent()
            {
                Name = "Boz Scaggs",
                StartDate = "2015-05-02T20:00",
                Location = new Place() { Name = "Coral Springs Center for the Performing Arts", Address = new PostalAddress() { AddressLocality = "Coral Springs, FL" } },
                Offers = new List<Offer>() { new Offer() { Url = "http://frontgatetickets.com/venue.php?id=11766" } },
                MainEntityOfPage = webPage
            };
            System.Diagnostics.Debug.WriteLine(musicEvent.ToString());
        }

        /// <summary>
        /// WebSite object to JSON-LD 
        /// </summary>
        [TestMethod]
        public void WebSiteTest()
        {
            WebSite webSite = new WebSite();
            webSite.Id = "/";
            webSite.Url = "http://www.1010tires.com/";
            webSite.PotentialAction = new SearchAction()
            {
                Target = new MXTires.Microdata.Intangible.EntryPoint() { UrlTemplate = "http://www.1010tires.com/Products/Search/?q={q}", },
                //Query = "required name=q",
                QueryInput = new PropertyValueSpecification() { ValueName = "q", ValueRequired = true, MultipleValues = true },
                ActionStatus = MXTires.Microdata.Intangible.Enumeration.ActionStatusType.PotentialActionStatus,
            };
            webSite.AggregateRating = new AggregateRating()
            {
                Id = "/SiteAggregateRating",
                BestRating = "5",
                WorstRating = "1",
                RatingValue = "4.6",
                ReviewCount = "3500",
                Description = "1010tires.com Reviews and Customer Ratings by Shopper Approved.",
                Url = "http://www.shopperapproved.com/reviews/1010tires.com/"
            };
            System.Diagnostics.Debug.WriteLine(webSite.ToIndentedJson());
        }

        /// <summary>
        /// WebPage object to JSON-LD 
        /// </summary>
        [TestMethod]
        public void WebPageTest()
        {
            WebSite webSite = new WebSite();
            webSite.Id = "/";
            webSite.Url = "http://www.1010tires.com/";
            webSite.PotentialAction = new SearchAction()
            {
                Target = new MXTires.Microdata.Intangible.EntryPoint() { UrlTemplate = "http://www.1010tires.com/Products/Search/?q={q}", },
                //Query = "required name=q",
                QueryInput = new PropertyValueSpecification() { ValueName = "q", ValueRequired = true, MultipleValues = true },
                ActionStatus = MXTires.Microdata.Intangible.Enumeration.ActionStatusType.PotentialActionStatus,
            };
            webSite.AggregateRating = new AggregateRating()
            {
                Id = "/SiteAggregateRating",
                BestRating = "5",
                WorstRating = "1",
                RatingValue = "4.6",
                ReviewCount = "3500",
                Description = "1010tires.com Reviews and Customer Ratings by Shopper Approved.",
                Url = "http://www.shopperapproved.com/reviews/1010tires.com/"
            };

            WebPage webPage = new WebPage();
            webPage.Id = "/events";
            webPage.Url = "http://www.1010tires.com/";
            webPage.MainEntityOfPage = webSite;
            System.Diagnostics.Debug.WriteLine(webPage.ToIndentedJson());
        }

        /// <summary>
        /// WebPage object with mainEntity set to JSON-LD 
        /// </summary>
        [TestMethod]
        public void WebPageMainEntityTest()
        {
            WebPage webPage = new WebPage();
            webPage.Id = "/";
            webPage.Url = "http://www.1010tires.com/";
            webPage.MainEntity = new MusicEvent()
            {
                Name = "Boz Scaggs",
                StartDate = "2015-05-02T20:00",
                Location = new Place() { Name = "Coral Springs Center for the Performing Arts", Address = new PostalAddress() { AddressLocality = "Coral Springs, FL" } },
                Offers = new List<Offer>() { new Offer() { Url = "http://frontgatetickets.com/venue.php?id=11766" } }
            };
            System.Diagnostics.Debug.WriteLine(webPage.ToIndentedJson());
        }


        /// <summary>
        /// To test Action
        /// </summary>
        [TestMethod]
        public void TestChooseAction()
        {
            var action = new ChooseAction();
            action.Option = "text";
            action.Option = new Thing();
            action.Option = new Object();
            action.Option = new Person();
        }

        /// <summary>
        /// Test Atlas
        /// </summary>
        [TestMethod]
        public void TestAtlas()
        {
            var atlas = new Atlas();
            atlas.Context = new List<object>() { "http://schema.org", new Extentions.BibNameSpace(), };
            atlas.Name = "Atlas of the world.";
            System.Diagnostics.Debug.WriteLine(atlas.ToIndentedJson());
        }

        /// <summary>
        /// Test converts Car to JSON-LD
        /// </summary>
        [TestMethod]
        public void TestCar()
        {
            var car = new Car()
            {
                Name = "2015 Honda Civic 2 Dr Coupe EX 205/55R16 (89H)",
                Brand = new Brand() { Name = "Honda" },
                Model = new ProductModel() { Name = "Civic" },
                ProductId = "123456",
                ReleaseDate = new DateTime(2015, 1, 1).ToString(),
            };

            System.Diagnostics.Debug.Write(car.ToIndentedJson());
        }

        /// <summary>
        /// Test to assign ImageObject to the image property
        /// </summary>
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

        [TestMethod]
        public void TireShopTest()
        {
            TireShop shop = new TireShop();

            shop.AggregateRating = new AggregateRating()
            {
                ReviewCount = "5",
                RatingValue = "5",
                Description = "Company Name",
            };
            shop.Url = "http://www.1010Tires.com/About/Installers/BC/Richmond/8";
            shop.CurrenciesAccepted = "USD";


            System.Diagnostics.Debug.Write(shop.ToIndentedJson());
        }
    }
}
