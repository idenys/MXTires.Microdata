using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.OrganizeActions
{
    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// <example><code> <script type="application/ld+json">
    /// // John bookmarked a photo using instagram.
    /// {
      /// "@context": "http://schema.org",
    /// "@type": "BookmarkAction",
    /// "agent": {
    /// "@type": "Person",
    /// "name": "John"
    /// },
    /// "object": {
    /// "@type": "ImageObject",
    /// "name": "Steve",
    /// "url": "http://john.com/steve.jpg"
    /// },
    /// "instrument": {
    /// "@type": "Product",
    /// "name": "Instagram"
    /// }
    /// }
    /// </script></code> </example>
    /// </summary>
    public class BookmarkAction : Action
    {
    }
}
