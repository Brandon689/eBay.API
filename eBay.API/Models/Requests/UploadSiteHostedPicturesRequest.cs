using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    //[XmlRoot("UploadSiteHostedPicturesRequest")]
    public class UploadSiteHostedPicturesRequest
    {
        [XmlElement("RequesterCredentials")]
        public RequesterCredentials RequesterCredentials { get; set; }

        [XmlElement("ErrorLanguage")]
        public string ErrorLanguage { get; set; }

        [XmlElement("WarningLevel")]
        public string WarningLevel { get; set; }

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

        [XmlElement("MessageID")]
        public string MessageID { get; set; }

        [XmlElement("Version")]
        public string Version { get; set; }
    }
}
