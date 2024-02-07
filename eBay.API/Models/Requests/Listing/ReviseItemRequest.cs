using eBay.API.Models.Items;
using eBay.API.Models.Requests.Base;

namespace eBay.API.Models.Requests
{
    public class ReviseItemRequest : ReviseBase
    {
        public Item Item { get; set; }
    }
}
