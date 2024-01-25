using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("SiteHostedPictureDetails")]
    public class SiteHostedPictureDetails
    {
        [XmlElement("PictureSet")]
        public string PictureSet { get; set; }

        [XmlElement("PictureFormat")]
        public string PictureFormat { get; set; }

        [XmlElement("FullURL")]
        public string FullURL { get; set; }

        [XmlElement("BaseURL")]
        public string BaseURL { get; set; }

        [XmlElement("PictureSetMember")]
        public List<PictureSetMember> PictureSetMember { get; set; }

        [XmlElement("UseByDate")]
        public DateTime UseByDate { get; set; }
    }
}
