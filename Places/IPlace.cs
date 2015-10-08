using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Places
{
    public interface IPlace
    {
        MXTires.Microdata.Intangible.StructuredValue.PropertyValue AdditionalProperty { get; set; }
        PostalAddress address { get; set; }
        MXTires.Microdata.Intangible.AggregateRating aggregateRating { get; set; }
        Place containedIn { get; set; }
        Event Event { get; set; }
        string FaxNumber { get; set; }
        MXTires.Microdata.Intangible.StructuredValue.GeoCoordinates Geo { get; set; }
        string GlobalLocationNumber { get; set; }
        Map HasMap { get; set; }
        string InteractionCount { get; set; }
        string IsicV4 { get; set; }
        object Logo { get; set; }
        System.Collections.Generic.List<MXTires.Microdata.Intangible.StructuredValue.OpeningHoursSpecification> OpeningHoursSpecification { get; set; }
        Thing Photo { get; set; }
        System.Collections.Generic.IList<Thing> Photos { get; set; }
        Review Review { get; set; }
        System.Collections.Generic.IList<Review> Reviews { get; set; }
        string Telephone { get; set; }
    }
}
