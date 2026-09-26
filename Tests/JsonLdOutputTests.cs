using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MXTires.Microdata.Actions.FindActions;
using MXTires.Microdata.CreativeWorks;
using MXTires.Microdata.Intangible;
using MXTires.Microdata.Intangible.Enumeration;
using MXTires.Microdata.Intangible.Quantities;
using MXTires.Microdata.Intangible.StructuredValues;
using MXTires.Microdata.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MXTires.Microdata.Tests
{
    [TestClass]
    public class JsonLdOutputTests
    {
        private static readonly Assembly Library = typeof(Thing).Assembly;

        private static JObject Json(Thing thing) => JObject.Parse(thing.ToString());

        private static void AssertJson(string expected, JToken actual)
        {
            Assert.IsTrue(JToken.DeepEquals(JToken.Parse(expected), actual), $"Expected {expected} but was {actual.ToString(Formatting.None)}");
        }

        [TestMethod]
        public void ReadmeOfferExampleMatchesOutput()
        {
            var offer = new Offer
            {
                Availability = ItemAvailability.InStock,
                AvailableDeliveryMethod = DeliveryMethod.OnSitePickup | DeliveryMethod.UPS,
                PriceValidUntil = new DateTime(2026, 10, 25)
            };

            AssertJson(@"{
                ""availability"": ""https://schema.org/InStock"",
                ""availableDeliveryMethod"": [""https://schema.org/OnSitePickup"", ""http://purl.org/goodrelations/v1#UPS""],
                ""priceValidUntil"": ""2026-10-25"",
                ""@context"": ""https://schema.org"",
                ""@type"": ""Offer""
            }", Json(offer));
        }

        [TestMethod]
        public void ProductWithNestedNodesMatchesExpectedDocument()
        {
            var product = new Product
            {
                Name = "Touring Tire",
                Brand = new Brand { Name = "Acme" },
                Offers = new List<Offer>
                {
                    new Offer
                    {
                        Price = "100.00",
                        PriceCurrency = "USD",
                        ItemCondition = OfferItemCondition.NewCondition,
                        Availability = ItemAvailability.InStock,
                        PriceSpecification = new PriceSpecification { ValueAddedTaxIncluded = true },
                        ShippingDetails = new OfferShippingDetails { ShippingRate = new MonetaryAmount { Value = 0, Currency = "USD" } },
                    }
                }
            };

            AssertJson(@"{
                ""brand"": { ""name"": ""Acme"", ""@type"": ""Brand"" },
                ""offers"": [{
                    ""price"": ""100.00"",
                    ""priceCurrency"": ""USD"",
                    ""availability"": ""https://schema.org/InStock"",
                    ""itemCondition"": ""https://schema.org/NewCondition"",
                    ""priceSpecification"": { ""valueAddedTaxIncluded"": true, ""@type"": ""PriceSpecification"" },
                    ""shippingDetails"": {
                        ""shippingRate"": { ""currency"": ""USD"", ""value"": 0, ""@type"": ""MonetaryAmount"" },
                        ""@type"": ""OfferShippingDetails""
                    },
                    ""@type"": ""Offer""
                }],
                ""name"": ""Touring Tire"",
                ""@context"": ""https://schema.org"",
                ""@type"": ""Product""
            }", Json(product));
        }

        #region 1. Enum converter

        [TestMethod]
        public void FlagsCombinationSerializesAsArray()
        {
            var offer = new Offer { AvailableDeliveryMethod = DeliveryMethod.OnSitePickup | DeliveryMethod.FederalExpress };

            AssertJson(@"[""https://schema.org/OnSitePickup"", ""http://purl.org/goodrelations/v1#FederalExpress""]", Json(offer)["availableDeliveryMethod"]);
        }

        [TestMethod]
        public void SingleEnumValueSerializesAsUriString()
        {
            var policy = new MerchantReturnPolicy { RefundType = RefundTypeEnumeration.FullRefund, ReturnFees = ReturnFeesEnumeration.FreeReturn };

            var json = Json(policy);

            Assert.AreEqual("https://schema.org/FullRefund", (string)json["refundType"]);
            Assert.AreEqual("https://schema.org/FreeReturn", (string)json["returnFees"]);
        }

        [TestMethod]
        public void EnumInsideObjectTypedPropertyUsesConverter()
        {
            var hours = new OpeningHoursSpecification("17:00", Intangible.Enumeration.DayOfWeek.Monday | Intangible.Enumeration.DayOfWeek.Tuesday, "09:00");

            AssertJson(@"[""https://schema.org/Monday"", ""https://schema.org/Tuesday""]", Json(hours)["dayOfWeek"]);
        }

        [TestMethod]
        public void MemberWithoutUriThrows()
        {
#pragma warning disable CS0618
            var offer = new Offer { AcceptedPaymentMethod = PaymentMethod.VisaCheckout };
#pragma warning restore CS0618

            var ex = Assert.ThrowsExactly<JsonSerializationException>(() => offer.ToString());
            StringAssert.Contains(ex.Message, "VisaCheckout");
        }

        [TestMethod]
        public void UndefinedValueThrows()
        {
            var offer = new Offer { ItemCondition = (OfferItemCondition)42 };

            Assert.ThrowsExactly<JsonSerializationException>(() => offer.ToString());
        }

        [TestMethod]
        public void RootContextStillWrittenAfterFailedSerialization()
        {
#pragma warning disable CS0618
            var bad = new Offer { AcceptedPaymentMethod = PaymentMethod.VisaCheckout };
#pragma warning restore CS0618
            Assert.ThrowsExactly<JsonSerializationException>(() => bad.ToString());

            Assert.AreEqual("https://schema.org", (string)Json(new Offer())["@context"]);
        }

        [TestMethod]
        public void EveryLibraryEnumMemberHasAnAbsoluteUri()
        {
            var problems = new List<string>();
            foreach (var type in Library.GetTypes().Where(t => t.IsEnum && t.IsPublic))
            {
                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    if (field.IsDefined(typeof(ObsoleteAttribute)) && field.GetCustomAttribute<EnumMemberAttribute>() == null)
                    {
                        continue;
                    }
                    var uri = field.GetCustomAttribute<EnumMemberAttribute>()?.Value;
                    if (uri == null || uri.Trim() != uri || !Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                    {
                        problems.Add($"{type.Name}.{field.Name} => '{uri}'");
                    }
                    else if (uri.StartsWith("http://schema.org/"))
                    {
                        problems.Add($"{type.Name}.{field.Name} uses http: '{uri}'");
                    }
                }
            }

            Assert.IsEmpty(problems, string.Join(Environment.NewLine, problems));
        }

        [TestMethod]
        public void EnumsRoundTripThroughConverter()
        {
            var settings = new JsonSerializerSettings { Converters = { new SchemaEnumConverter() } };
            var original = DeliveryMethod.DeliveryModeMail | DeliveryMethod.UPS;

            var json = JsonConvert.SerializeObject(original, settings);
            var back = JsonConvert.DeserializeObject<DeliveryMethod?>(json, settings);

            Assert.AreEqual(original, back);
        }

        #endregion

        #region 2 and 9. Unset properties are not written

        [TestMethod]
        public void NewObjectsWriteOnlyContextAndType()
        {
            var allowed = new HashSet<string> { "@context", "@type", "additionalType" };
            var problems = new List<string>();

            var thingTypes = Library.GetTypes()
                .Where(t => t.IsPublic && !t.IsAbstract && typeof(Thing).IsAssignableFrom(t) && t.GetConstructor(Type.EmptyTypes) != null);

            foreach (var type in thingTypes)
            {
                string json;
                try
                {
                    json = ((Thing)Activator.CreateInstance(type)).ToString();
                }
                catch (Exception ex)
                {
                    problems.Add($"{type.Name}: {ex.GetType().Name} {ex.Message}");
                    continue;
                }

                var extra = JObject.Parse(json).Properties().Select(p => p.Name).Where(n => !allowed.Contains(n)).ToList();
                if (extra.Count > 0)
                {
                    problems.Add($"{type.Name}: {string.Join(", ", extra)}");
                }
            }

            Assert.IsEmpty(problems, string.Join(Environment.NewLine, problems));
        }

        [TestMethod]
        public void RangeOnlyQuantitativeValueHasNoValue()
        {
            var json = Json(new QuantitativeValue { MinValue = 1, MaxValue = 3, UnitCode = "DAY" });

            Assert.IsNull(json["value"]);
            Assert.AreEqual(1, (int)json["minValue"]);
        }

        [TestMethod]
        public void ShippingRateHasNoMinOrMaxValue()
        {
            var details = new OfferShippingDetails { ShippingRate = new MonetaryAmount { Value = 5, Currency = "USD" } };

            var rate = Json(details)["shippingRate"];

            Assert.IsNull(rate["minValue"]);
            Assert.IsNull(rate["maxValue"]);
        }

        #endregion

        #region 3, 4 and 5. URIs

        [TestMethod]
        public void MerchantReturnPolicyEnumsUseFullUris()
        {
            var policy = new MerchantReturnPolicy
            {
                ReturnPolicyCategory = MerchantReturnEnumeration.MerchantReturnFiniteReturnWindow,
                ItemCondition = OfferItemCondition.NewCondition,
                ReturnLabelSource = ReturnLabelSourceEnumeration.ReturnLabelDownloadAndPrint,
            };

            var json = Json(policy);

            Assert.AreEqual("https://schema.org/MerchantReturnFiniteReturnWindow", (string)json["returnPolicyCategory"]);
            Assert.AreEqual("https://schema.org/NewCondition", (string)json["itemCondition"]);
            Assert.AreEqual("https://schema.org/ReturnLabelDownloadAndPrint", (string)json["returnLabelSource"]);
        }

        [TestMethod]
        public void ReturnMethodMembersAreDistinct()
        {
            Assert.AreEqual("https://schema.org/ReturnByMail", (string)Json(new MerchantReturnPolicy { ReturnMethod = ReturnMethodEnumeration.ReturnByMail })["returnMethod"]);
            Assert.AreEqual("https://schema.org/ReturnAtKiosk", (string)Json(new MerchantReturnPolicy { ReturnMethod = ReturnMethodEnumeration.ReturnAtKiosk })["returnMethod"]);
            Assert.AreEqual("https://schema.org/ReturnInStore", (string)Json(new MerchantReturnPolicy { ReturnMethod = ReturnMethodEnumeration.ReturnInStore })["returnMethod"]);
        }

        [TestMethod]
        public void SchemaOrgUrisUseHttps()
        {
            Assert.AreEqual("https://schema.org", new Thing().Context);
            Assert.AreEqual("https://schema.org/InStock", (string)Json(new Offer { Availability = ItemAvailability.InStock })["availability"]);
            Assert.AreEqual("https://schema.org/Online", (string)Json(new GameServer { ServerStatus = GameServerStatus.Online })["serverStatus"]);
            Assert.AreEqual("https://schema.org/CoOp", (string)Json(new VideoGame { PlayMode = GamePlayMode.CoOp })["playMode"]);
            Assert.AreEqual("https://schema.org/CreditCard", (string)Json(new Offer { AcceptedPaymentMethod = PaymentMethod.CreditCard })["acceptedPaymentMethod"]);
        }

        [TestMethod]
        public void GoodRelationsUrisHaveNoTrailingSpace()
        {
            var hours = new OpeningHoursSpecification("17:00", DaysOfWeek.Tu, "09:00");
            var offer = new Offer { AvailableDeliveryMethod = DeliveryMethod.DeliveryModePickUp };

            Assert.AreEqual("http://purl.org/goodrelations/v1#Tuesday", (string)Json(hours)["dayOfWeek"]);
            Assert.AreEqual("http://purl.org/goodrelations/v1#DeliveryModePickUp", (string)Json(offer)["availableDeliveryMethod"]);
        }

        [TestMethod]
        public void PurolatorSerializesAsParcelService()
        {
            Assert.AreEqual("https://schema.org/ParcelService", (string)Json(new Offer { AvailableDeliveryMethod = DeliveryMethod.Purolator })["availableDeliveryMethod"]);
        }

        #endregion

        #region 6. @context on the root only

        [TestMethod]
        public void ContextIsWrittenOnRootOnly()
        {
            var product = new Product
            {
                Name = "Tire",
                Brand = new Brand { Name = "Acme" },
                AggregateRating = new AggregateRating { RatingValue = "4.5", ReviewCount = "10" },
                Offers = new List<Offer> { new Offer { Price = "100", PriceCurrency = "USD" } },
            };

            var json = Json(product);

            Assert.AreEqual("https://schema.org", (string)json["@context"]);
            Assert.AreEqual(1, json.DescendantsAndSelf().OfType<JProperty>().Count(p => p.Name == "@context"));
        }

        [TestMethod]
        public void ContextIsWrittenOnRootWhenSerializedDirectly()
        {
            var product = new Product { Brand = new Brand { Name = "Acme" } };

            var json = JObject.Parse(JsonConvert.SerializeObject(product, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            Assert.AreEqual("https://schema.org", (string)json["@context"]);
            Assert.IsNull(json["brand"]["@context"]);
        }

        [TestMethod]
        public void ExplicitNestedContextIsKept()
        {
            var product = new Product { Brand = new Brand { Name = "Acme", Context = "https://example.org/context" } };

            Assert.AreEqual("https://example.org/context", (string)Json(product)["brand"]["@context"]);
        }

        [TestMethod]
        public void ToJsonWrapsInScriptTag()
        {
            var html = new Offer().ToJson();

            Assert.StartsWith("<script type=\"application/ld+json\">", html);
            StringAssert.Contains(html, "\"@context\":\"https://schema.org\"");
        }

        #endregion

        #region 7. ToJson is virtual

        private class CustomOffer : Offer
        {
            public override string ToJson() => "custom";
        }

        [TestMethod]
        public void ToJsonOverrideIsUsedThroughBaseReference()
        {
            Thing thing = new CustomOffer();

            Assert.AreEqual("custom", thing.ToJson());
        }

        #endregion

        #region 8. Date-only values

        [TestMethod]
        public void DateOnlyPropertiesSerializeWithoutTimeOrZone()
        {
            var offer = new Offer { PriceValidUntil = new DateTime(2026, 10, 25, 13, 45, 0, DateTimeKind.Local) };
            var person = new Person { BirthDate = new DateTime(1980, 1, 2) };

            Assert.AreEqual("2026-10-25", Json(offer)["priceValidUntil"].ToString());
            Assert.AreEqual("1980-01-02", Json(person)["birthDate"].ToString());
        }

        #endregion

        #region 10 and 11. Tire

        [TestMethod]
        public void TireHasNoHardcodedSameAs()
        {
            var json = Json(new Tire { Name = "Tire" });

            Assert.IsNull(json["sameAs"]);
            Assert.AreEqual("Product", (string)json["@type"]);
            Assert.AreEqual("http://www.productontology.org/id/Tire", (string)json["additionalType"]);
        }

        [TestMethod]
        public void WheelIsAValidProductWithoutSameAs()
        {
            var json = Json(new Wheel());

            Assert.AreEqual("Product", (string)json["@type"]);
            Assert.IsNull(json["sameAs"]);
        }

        [TestMethod]
        public void TireSpecsSerializeAsAdditionalProperties()
        {
            var tire = new Tire
            {
                AdditionalProperty = new PropertyValue { Name = "Warranty", Value = "60000 mi" },
                SpeedRating = "H",
                LoadIndex = "94",
                RunFlat = false,
            };

            var properties = (JArray)Json(tire)["additionalProperty"];

            Assert.HasCount(4, properties);
            Assert.AreEqual("Warranty", (string)properties[0]["name"]);
            Assert.AreEqual("speedRating", (string)properties[1]["propertyID"]);
            Assert.AreEqual("H", (string)properties[1]["value"]);
            Assert.AreEqual("94", (string)properties[2]["value"]);
            Assert.IsFalse((bool)properties[3]["value"]);
            Assert.IsNull(properties[1]["@context"]);
        }

        [TestMethod]
        public void TireWithoutSpecsKeepsItsOwnAdditionalProperty()
        {
            var tire = new Tire { AdditionalProperty = new PropertyValue("Warranty", "60000 mi") };

            Assert.AreEqual("Warranty", (string)Json(tire)["additionalProperty"]["name"]);
        }

        #endregion

        #region 12. Minor

        [TestMethod]
        public void MerchantReturnPolicyAcceptsSeveralAdditionalProperties()
        {
            var policy = new MerchantReturnPolicy
            {
                AdditionalProperty = new List<PropertyValue>
                {
                    new PropertyValue { Name = "a", Value = 1 },
                    new PropertyValue { Name = "b", Value = 2 },
                }
            };

            Assert.HasCount(2, (JArray)Json(policy)["additionalProperty"]);
            Assert.ThrowsExactly<ArgumentException>(() => policy.AdditionalProperty = "text");
        }

        #endregion

        #region Related fixes

        [TestMethod]
        public void VehicleSteeringPositionUsesSchemaEnumeration()
        {
            var vehicle = new Vehicle { SteeringPosition = SteeringPositionValue.RightHandDriving };

            Assert.AreEqual("https://schema.org/RightHandDriving", (string)Json(vehicle)["steeringPosition"]);
        }

        [TestMethod]
        public void FlightDurationAcceptsTextOrDuration()
        {
            var flight = new Flight { EstimatedFlightDuration = "PT2H30M" };

            Assert.AreEqual("PT2H30M", (string)Json(flight)["estimatedFlightDuration"]);
            flight.EstimatedFlightDuration = new Duration();
            Assert.ThrowsExactly<ArgumentException>(() => flight.EstimatedFlightDuration = DateTime.Now);
        }

        [TestMethod]
        public void TrackActionDeliveryMethodIsSerialized()
        {
            var action = new TrackAction { DeliveryMethod = DeliveryMethod.UPS };

            Assert.AreEqual("http://purl.org/goodrelations/v1#UPS", (string)Json(action)["deliveryMethod"]);
        }

        #endregion
    }
}
