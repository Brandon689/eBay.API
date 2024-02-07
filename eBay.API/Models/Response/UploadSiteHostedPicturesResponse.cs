using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("UploadSiteHostedPicturesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class UploadSiteHostedPicturesResponse : ResponseBase
    {
        [XmlElement("HardExpirationWarning")]
        public string HardExpirationWarning { get; set; }

        [XmlElement("PictureSystemVersion")]
        public int PictureSystemVersion { get; set; }

        [XmlElement("SiteHostedPictureDetails")]
        public SiteHostedPictureDetails SiteHostedPictureDetails { get; set; }
    }
}
