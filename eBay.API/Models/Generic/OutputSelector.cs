using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    public class OutputSelector
    {
        [XmlText]
        public string Value { get; set; }

        public OutputSelector() { }

        public OutputSelector(string value)
        {
            Value = value;
        }
    }
}
