using System;
using System.Runtime.Serialization;

//Acknowledgements
//This class is derived from the GoodRelations Vocabulary for E-Commerce, created by Martin Hepp. GoodRelations is a data model for sharing e-commerce data on the Web that can be expressed in a variety of syntaxes, including RDFa and HTML5 Microdata. More information about GoodRelations can be found at http://purl.org/goodrelations/

namespace MXTires.Microdata
{
    /// <summary>
    /// A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product. Commonly used values: http://purl.org/goodrelations/v1#Labor-BringIn http://purl.org/goodrelations/v1#PartsAndLabor-BringIn http://purl.org/goodrelations/v1#PartsAndLabor-PickUp
    /// </summary>
    [Flags]
    public enum WarrantyScope
    {
        [EnumMember(Value = "http://purl.org/goodrelations/v1#Labor-BringIn")]
        LaborBringIn = 1 << 0,
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PartsAndLabor-BringIn")]
        PartsAndLaborBringIn = 1 << 1,
        [EnumMember(Value = "http://purl.org/goodrelations/v1#PartsAndLabor-PickUp")]
        PartsAndLaborPickUp = 1 << 2,

    }
}