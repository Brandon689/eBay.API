using System.Xml.Serialization;

namespace eBay.API.Models.Product
{
    public class PictureDetails
    {
        public string GalleryType { get; set; }

        public string PhotoDisplay { get; set; }

        [XmlElement("PictureURL")]
        public string[] PictureURL { get; set; }

        public string PictureSource { get; set; }
    }
}
