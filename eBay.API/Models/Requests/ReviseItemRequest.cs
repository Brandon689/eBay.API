using eBay.API.Models.SellerStore;

namespace eBay.API.Models.Requests
{
    public class ReviseItemRequest
    {
        public RequesterCredentials RequesterCredentials { get; set; }

        public string ErrorLanguage { get; set; }

        public string WarningLevel { get; set; } = "High";

        public Item Item { get; set; }
    }
}
