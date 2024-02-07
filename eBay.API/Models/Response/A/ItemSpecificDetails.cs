using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("ItemSpecificDetails")]
    public class ItemSpecificDetails
    {
        [XmlElement("MaxItemSpecificsPerItem")]
        public int MaxItemSpecificsPerItem { get; set; }

        [XmlElement("MaxValuesPerName")]
        public int MaxValuesPerName { get; set; }

        [XmlElement("MaxCharactersPerValue")]
        public int MaxCharactersPerValue { get; set; }

        [XmlElement("MaxCharactersPerName")]
        public int MaxCharactersPerName { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
