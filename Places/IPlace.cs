using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Places
{
    /// <summary>
    /// Interface IPlace
    /// </summary>
    public interface IPlace
    {
        /// <summary>
        /// Gets or sets the additional property.
        /// </summary>
        /// <value>The additional property.</value>
        object AdditionalProperty { get; set; }
        /// <summary>
        /// Sets a single address.
        /// </summary>
        /// <value>The address.</value>
        PostalAddress Address { set; }

        /// <summary>
        /// Gets or sets a collection of addresses
        /// </summary>
        List<PostalAddress> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the aggregate rating.
        /// </summary>
        /// <value>The aggregate rating.</value>
        MXTires.Microdata.Intangible.AggregateRating AggregateRating { get; set; }
        /// <summary>
        /// Gets or sets the contained in.
        /// </summary>
        /// <value>The contained in.</value>
        Place ContainedIn { get; set; }
        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        /// <value>The event.</value>
        Event Event { get; set; }
        /// <summary>
        /// Gets or sets the fax number.
        /// </summary>
        /// <value>The fax number.</value>
        string FaxNumber { get; set; }
        /// <summary>
        /// Gets or sets the geo.
        /// </summary>
        /// <value>The geo.</value>
        MXTires.Microdata.Intangible.StructuredValues.GeoCoordinates Geo { get; set; }
        /// <summary>
        /// Gets or sets the global location number.
        /// </summary>
        /// <value>The global location number.</value>
        string GlobalLocationNumber { get; set; }
        /// <summary>
        /// Gets or sets the has map.
        /// </summary>
        /// <value>The has map.</value>
        object HasMap { get; set; }
        /// <summary>
        /// Gets or sets the interaction count.
        /// </summary>
        /// <value>The interaction count.</value>
        string InteractionCount { get; set; }
        /// <summary>
        /// Gets or sets the isic v4.
        /// </summary>
        /// <value>The isic v4.</value>
        string IsicV4 { get; set; }
        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>The logo.</value>
        object Logo { get; set; }
        /// <summary>
        /// Gets or sets the opening hours specification.
        /// </summary>
        /// <value>The opening hours specification.</value>
        System.Collections.Generic.List<MXTires.Microdata.Intangible.StructuredValues.OpeningHoursSpecification> OpeningHoursSpecification { get; set; }
        /// <summary>
        /// Gets or sets the photo.
        /// </summary>
        /// <value>The photo.</value>
        Thing Photo { get; set; }
        /// <summary>
        /// Gets or sets the photos.
        /// </summary>
        /// <value>The photos.</value>
        System.Collections.Generic.IList<Thing> Photos { get; set; }
        /// <summary>
        /// Gets or sets the review.
        /// </summary>
        /// <value>The review.</value>
        Review Review { get; set; }
        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        /// <value>The reviews.</value>
        System.Collections.Generic.IList<Review> Reviews { get; set; }
        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        /// <value>The telephone.</value>
        string Telephone { get; set; }
    }
}
