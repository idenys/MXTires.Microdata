using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace MXTires.Microdata
{
    [XmlRoot("site")]
    public class SiteAggregateRating
    {
        [XmlElement("site")]
        public string Site { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("review_count")]
        public string ReviewCount { get; set; }

        [XmlElement("average")]
        public string Average { get; set; }

        [XmlElement("active")]
        public string Active { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        public SiteAggregateRating Process(string response)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);
            XmlNode site = xmlDoc.SelectSingleNode("descendant::site");
            XmlSerializer serializer = new XmlSerializer(GetType());
            using (StringReader reader = new StringReader(site.OuterXml))
            {
                return (SiteAggregateRating)serializer.Deserialize(reader);
            }
        }
    }
}