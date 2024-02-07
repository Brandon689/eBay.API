using eBay.API.Models.Requests.Base;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot("UploadSiteHostedPicturesRequest")]
    public class UploadSiteHostedPicturesRequest : AllBase
    {
        [XmlElement("ExternalPictureURL")]
        public string ExternalPictureURL { get; set; }

        [XmlElement("PictureName")]
        public string PictureName { get; set; }

        [XmlElement("ExtensionInDays")]
        public string ExtensionInDays { get; set; }

        [XmlElement("PictureData")]
        public PictureData PictureData { get; set; }

        [XmlElement("PictureSet")]
        public string PictureSet { get; set; }

        [XmlElement("PictureSystemVersion")]
        public string PictureSystemVersion { get; set; }

        [XmlElement("PictureUploadPolicy")]
        public string PictureUploadPolicy { get; set; }
    }
}
