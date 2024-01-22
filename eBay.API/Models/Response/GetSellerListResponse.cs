using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    public class PaginationResult
    {
        public int TotalNumberOfPages { get; set; }
        public int TotalNumberOfEntries { get; set; }
    }

    public class ItemArray
    {
        public Item Item { get; set; }
    }

    [XmlRoot("GetSellerListResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetSellerListResponse
    {
        public DateTime Timestamp { get; set; }
        public string Ack { get; set; }
        public int Version { get; set; }
        public string Build { get; set; }
        public PaginationResult PaginationResult { get; set; }
        public bool HasMoreItems { get; set; }
        public ItemArray ItemArray { get; set; }
        public int ItemsPerPage { get; set; }
        public int PageNumber { get; set; }
        public int ReturnedItemCountActual { get; set; }
        public Seller Seller { get; set; }
    }
}
