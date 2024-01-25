using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot(ElementName = "GetCategoriesRequest")]
    public class GetCategoriesRequest : GetBase
    {
        [XmlElement(ElementName = "CategoryParent")]
        public string CategoryParent { get; set; }

        [XmlElement(ElementName = "CategorySiteID")]
        public string CategorySiteID { get; set; }

        [XmlElement(ElementName = "LevelLimit")]
        public string LevelLimit { get; set; }

        [XmlElement(ElementName = "ViewAllNodes")]
        public bool ViewAllNodes { get; set; }
    }
}
