using System.Xml.Serialization;

namespace eBay.API.Models.Response.Error
{
    [XmlRoot("ErrorParameters")]
    public class ErrorParameters
    {
        [XmlElement("Value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "ParamID")]
        public int ParamID { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
