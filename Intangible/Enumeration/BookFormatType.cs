using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    /// <summary>
    /// Enum BookFormatType
    /// </summary>
    public enum BookFormatType
    {
        /// <summary>
        /// The e book
        /// </summary>
        EBook,
        /// <summary>
        /// The hardcover
        /// </summary>
        Hardcover,
        /// <summary>
        /// The paperback
        /// </summary>
        Paperback,
        /// <summary>
        /// Defined in the bib.schema.org extension. (This is an initial exploratory release.)
        /// Canonical URL: http://schema.org/GraphicNovel
        /// </summary>
        GraphicNovel
    }
}
