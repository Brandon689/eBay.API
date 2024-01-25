using System.Xml.Serialization;

namespace eBay.API.Models
{
    [XmlRoot("AmountType")]
    public class AmountType
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
