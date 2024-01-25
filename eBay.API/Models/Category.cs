using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot(ElementName = "Category")]
    public class Category
    {
        [XmlElement(ElementName = "BestOfferEnabled")]
        public bool BestOfferEnabled { get; set; }

        [XmlElement(ElementName = "AutoPayEnabled")]
        public bool AutoPayEnabled { get; set; }

        [XmlElement(ElementName = "CategoryID")]
        public int CategoryID { get; set; }

        [XmlElement(ElementName = "CategoryLevel")]
        public int CategoryLevel { get; set; }

        [XmlElement(ElementName = "CategoryName")]
        public string CategoryName { get; set; }

        [XmlElement(ElementName = "CategoryParentID")]
        public int CategoryParentID { get; set; }

        [XmlElement(ElementName = "LeafCategory")]
        public bool LeafCategory { get; set; }
    }
}
