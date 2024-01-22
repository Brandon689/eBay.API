using System.Xml.Serialization;

namespace eBay.API.Models.SellerStore
{
    [XmlRoot("Pagination")]
    public class Pagination
    {
        [XmlElement("EntriesPerPage")]
        public int EntriesPerPage { get; set; }

        [XmlElement("PageNumber")]
        public int PageNumber { get; set; }
    }
}
