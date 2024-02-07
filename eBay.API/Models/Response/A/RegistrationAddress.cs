using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("RegistrationAddress")]
    public class RegistrationAddress
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Street")]
        public string Street { get; set; }

        [XmlElement("Street1")]
        public string Street1 { get; set; }

        [XmlElement("CityName")]
        public string CityName { get; set; }

        [XmlElement("StateOrProvince")]
        public string StateOrProvince { get; set; }

        [XmlElement("Country")]
        public string Country { get; set; }

        [XmlElement("CountryName")]
        public string CountryName { get; set; }

        [XmlElement("Phone")]
        public int Phone { get; set; }

        [XmlElement("PostalCode")]
        public int PostalCode { get; set; }

        [XmlElement("CompanyName")]
        public string CompanyName { get; set; }
    }
}
