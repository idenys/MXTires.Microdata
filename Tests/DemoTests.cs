using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MXTires.Microdata;

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

            System.Diagnostics.Debug.Write(product.ToJason());
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

            OpeningHoursSpecification mondayHours = new OpeningHoursSpecification()
            {
                 DayOfWeek = MXTires.Microdata.DaysOfWeek.Mo.ToString(),
                 Opens = "9:00 AM",
                 Closes = "5:30 PM",
            };

            shop.Location.OpeningHoursSpecification = new List<OpeningHoursSpecification>();
            shop.Location.OpeningHoursSpecification.Add(mondayHours);

            System.Diagnostics.Debug.Write(shop.ToJason());
        }

        [TestMethod]
        public void SimpleOfferTest()
        {
            var offer = new Offer()
            {
                Name = "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            };
            offer.Availability = ItemAvailability.InStock | ItemAvailability.Discontinued;

            System.Diagnostics.Debug.Write(offer.ToJason());

            //Note: does not work as expected
            //<script type="application/ld+json">{
            //  "price": null,
            //  "priceCurrency": null,
            //  "priceSpecification": null,
            //  "acceptedPaymentMethod": null,
            //  "category": null,
            //  "validFrom": null,
            //  "validThrough": null,
            //  "addOn": null,
            //  "sku": null,
            //  "serialNumber": null,
            //  "seller": null,
            //  "review": null,
            //  "availability": "http://schema.org/InStock",
            //  "additional@type": null,
            //  "alternateName": null,
            //  "description": null,
            //  "image": null,
            //  "name": "T3 REPLICA NISSAN ALTIMA, MAXIMA (PAINTED/SILVER)",
            //  "potentialAction": null,
            //  "sameAs": null,
            //  "url": null,
            //  "@context": "http://schema.org",
            //  "@type": "Offer"
            //}</script>
        }
    }
}
