using eBay.API.Models.Response.Error;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("UploadSiteHostedPicturesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class UploadSiteHostedPicturesResponse
    {
        [XmlElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement("Ack")]
        public string Ack { get; set; }

        [XmlElement("Errors")]
        public Errors Errors { get; set; }

        [XmlElement("Version")]
        public int Version { get; set; }

        [XmlElement("Build")]
        public string Build { get; set; }

        [XmlElement("HardExpirationWarning")]
        public string HardExpirationWarning { get; set; }

        [XmlElement("PictureSystemVersion")]
        public int PictureSystemVersion { get; set; }

        [XmlElement("SiteHostedPictureDetails")]
        public SiteHostedPictureDetails SiteHostedPictureDetails { get; set; }
    }
}
