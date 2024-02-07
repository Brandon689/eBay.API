using eBay.API.Models.Customer.Transaction;
using eBay.API.Models.Requests;
using eBay.API.Models.Response;
using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models
{
    [XmlRoot("ActiveList")]
    public class ActiveList
    {
        [XmlElement("ItemArray")]
        public ItemArray ItemArray { get; set; }

        [XmlElement("Include")]
        public bool Include { get; set; }

        [XmlElement("IncludeNotes")]
        public bool IncludeNotes { get; set; }

        [XmlElement("ListingType")]
        public string ListingType { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        [XmlElement("Sort")]
        public string Sort { get; set; }
    }

    [XmlRoot("DeletedFromSoldList")]
    public class DeletedFromSoldList
    {
        [XmlElement("DurationInDays")]
        public string DurationInDays { get; set; }

        [XmlElement("Include")]
        public bool Include { get; set; }

        [XmlElement("IncludeNotes")]
        public bool IncludeNotes { get; set; }

        [XmlElement("Sort")]
        public string Sort { get; set; }

        [XmlElement("ItemArray")]
        public ItemArray ItemArray { get; set; }
    }

    [XmlRoot("DeletedFromUnsoldList")]
    public class DeletedFromUnsoldList
    {
        [XmlElement("DurationInDays")]
        public string DurationInDays { get; set; }

        [XmlElement("Include")]
        public bool Include { get; set; }

        [XmlElement("IncludeNotes")]
        public bool IncludeNotes { get; set; }

        [XmlElement("Sort")]
        public string Sort { get; set; }

        [XmlElement("ItemArray")]
        public ItemArray ItemArray { get; set; }
    }

    [XmlRoot("ScheduledList")]
    public class ScheduledList
    {
        [XmlElement("Include")]
        public bool Include { get; set; }

        [XmlElement("IncludeNotes")]
        public bool IncludeNotes { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        [XmlElement("Sort")]
        public string Sort { get; set; }

        [XmlElement("ItemArray")]
        public ItemArray ItemArray { get; set; }
    }

    [XmlRoot("SellingSummary")]
    public class SellingSummary
    {
        [XmlElement("Include")]
        public bool Include { get; set; }
    }

    [XmlRoot("OrderTransactionArray")]
    public class OrderTransactionArray
    {

        [XmlElement("OrderTransaction")]
        public List<OrderTransaction> OrderTransaction { get; set; }
    }

    [XmlRoot("OrderTransaction")]
    public class OrderTransaction
    {

        [XmlElement("Transaction")]
        public Transaction Transaction { get; set; }
    }

    [XmlRoot("SoldList")]
    public class SoldList
    {
        [XmlElement("OrderTransactionArray")]
        public OrderTransactionArray OrderTransactionArray { get; set; }

        [XmlElement("PaginationResult")]
        public PaginationResult PaginationResult { get; set; }

        [XmlElement("DurationInDays")]
        public string DurationInDays { get; set; }

        [XmlElement("Include")]
        public bool Include { get; set; }

        [XmlElement("IncludeNotes")]
        public bool IncludeNotes { get; set; }

        [XmlElement("OrderStatusFilter")]
        public string OrderStatusFilter { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        [XmlElement("Sort")]
        public string Sort { get; set; }
    }

    [XmlRoot("UnsoldList")]
    public class UnsoldList
    {
        [XmlElement("ItemArray")]
        public ItemArray ItemArray { get; set; }

        [XmlElement("DurationInDays")]
        public string DurationInDays { get; set; }

        [XmlElement("Include")]
        public bool Include { get; set; }

        [XmlElement("IncludeNotes")]
        public bool IncludeNotes { get; set; }

        [XmlElement("Pagination")]
        public Pagination Pagination { get; set; }

        [XmlElement("Sort")]
        public string Sort { get; set; }
    }

    [XmlRoot("GetMyeBaySellingRequest")]
    public class GetMyeBaySellingRequest : GetBase
    {

        [XmlElement("ActiveList")]
        public ActiveList ActiveList { get; set; }

        [XmlElement("DeletedFromSoldList")]
        public DeletedFromSoldList DeletedFromSoldList { get; set; }

        [XmlElement("DeletedFromUnsoldList")]
        public DeletedFromUnsoldList DeletedFromUnsoldList { get; set; }

        [XmlElement("HideVariations")]
        public string HideVariations { get; set; }

        [XmlElement("ScheduledList")]
        public ScheduledList ScheduledList { get; set; }

        [XmlElement("SellingSummary")]
        public SellingSummary SellingSummary { get; set; }

        [XmlElement("SoldList")]
        public SoldList SoldList { get; set; }

        [XmlElement("UnsoldList")]
        public UnsoldList UnsoldList { get; set; }

        [XmlElement("DetailLevel")]
        public string DetailLevel { get; set; }
    }
}
