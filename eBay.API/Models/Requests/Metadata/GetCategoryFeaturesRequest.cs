using System.Xml.Serialization;

namespace eBay.API.Models.Requests.Metadata
{
    [XmlRoot("GetCategoryFeaturesRequest")]
    public class GetCategoryFeaturesRequest : GetBase
    {
        [XmlElement("AllFeaturesForCategory")]
        public bool AllFeaturesForCategory { get; set; }

        [XmlElement("CategoryID")]
        public string CategoryID { get; set; }

        [XmlElement("FeatureID")]
        public string FeatureID { get; set; }

        [XmlElement("LevelLimit")]
        public string LevelLimit { get; set; }

        [XmlElement("ViewAllNodes")]
        public bool ViewAllNodes { get; set; }
    }
}
