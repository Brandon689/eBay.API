using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot(ElementName = "GetCategoriesRequest")]
    public class GetCategoriesRequest : GetBase
    {
        [XmlElement("CategoryParent")]
        public string CategoryParent { get; set; }

        [XmlElement("CategorySiteID")]
        public string CategorySiteID { get; set; }

        [XmlElement("LevelLimit")]
        public string LevelLimit { get; set; }

        [XmlElement("ViewAllNodes")]
        public bool ViewAllNodes { get; set; }
    }
}
