using System.Xml.Serialization;

namespace eBay.API.Models
{
    [XmlRoot("PictureData")]
    public class PictureData
    {
        [XmlAttribute(AttributeName = "contentType")]
        public string ContentType { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
