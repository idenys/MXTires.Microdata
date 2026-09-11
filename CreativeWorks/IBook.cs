using System;
namespace MXTires.Microdata.CreativeWorks
{
    interface IBook
    {
        string BookEdition { get; set; }
        MXTires.Microdata.Intangible.Enumeration.BookFormatType BookFormat { get; set; }
        MXTires.Microdata.Person Illustrator { get; set; }
        string Isbn { get; set; }
        int? NumberOfPages { get; set; }
    }
}
