using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Intangible.Enumeration
{
    public enum BookFormatType
    {
        EBook,
        Hardcover,
        Paperback,
        /// <summary>
        /// Defined in the bib.schema.org extension. (This is an initial exploratory release.)
        /// Canonical URL: http://schema.org/GraphicNovel
        /// </summary>
        GraphicNovel
    }
}
