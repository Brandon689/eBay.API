using System.Xml.Serialization;

namespace eBay.API.Models.Response.NewFolder
{
    [XmlRoot("VariationDetails")]
    public class VariationDetails
    {
        [XmlElement("MaxVariationsPerItem")]
        public int MaxVariationsPerItem { get; set; }

        [XmlElement("MaxNamesPerVariationSpecificsSet")]
        public int MaxNamesPerVariationSpecificsSet { get; set; }

        [XmlElement("MaxValuesPerVariationSpecificsSetName")]
        public int MaxValuesPerVariationSpecificsSetName { get; set; }

        [XmlElement("DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement("UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
