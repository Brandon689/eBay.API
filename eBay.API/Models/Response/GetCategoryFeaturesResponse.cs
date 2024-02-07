using eBay.API.Models.Response.A;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetCategoryFeaturesResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetCategoryFeaturesResponse : ResponseBase
    {
        [XmlElement("CategoryVersion")]
        public int CategoryVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement("SiteDefaults")]
        public SiteDefaults SiteDefaults { get; set; }

        [XmlElement("FeatureDefinitions")]
        public FeatureDefinitions FeatureDefinitions { get; set; }
    }
}
