using System.Xml.Serialization;

namespace eBay.API.Models.Response.Error
{
    [XmlRoot("Errors")]
    public class Errors
    {
        [XmlElement("ShortMessage")]
        public string ShortMessage { get; set; }

        [XmlElement("LongMessage")]
        public string LongMessage { get; set; }

        [XmlElement("ErrorCode")]
        public int ErrorCode { get; set; }

        [XmlElement("SeverityCode")]
        public string SeverityCode { get; set; }

        [XmlElement("ErrorParameters")]
        public List<ErrorParameters> ErrorParameters { get; set; }

        [XmlElement("ErrorClassification")]
        public string ErrorClassification { get; set; }
    }
}
