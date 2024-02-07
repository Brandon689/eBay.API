using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("GetSellerListResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetSellerListResponse : ResponseBase
    {
        public PaginationResult PaginationResult { get; set; }

        public bool HasMoreItems { get; set; }

        public ItemArray ItemArray { get; set; }

        public int ItemsPerPage { get; set; }

        public int PageNumber { get; set; }

        public int ReturnedItemCountActual { get; set; }

        public Seller Seller { get; set; }
    }
}
