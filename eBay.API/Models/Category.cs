using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot(ElementName = "Category")]
    public class Category
    {
        [XmlElement("BestOfferEnabled")]
        public bool BestOfferEnabled { get; set; }

        [XmlElement("AutoPayEnabled")]
        public bool AutoPayEnabled { get; set; }

        [XmlElement("CategoryID")]
        public int CategoryID { get; set; }

        [XmlElement("CategoryLevel")]
        public int CategoryLevel { get; set; }

        [XmlElement("CategoryName")]
        public string CategoryName { get; set; }

        [XmlElement("CategoryParentID")]
        public int CategoryParentID { get; set; }

        [XmlElement("LeafCategory")]
        public bool LeafCategory { get; set; }
    }
}
