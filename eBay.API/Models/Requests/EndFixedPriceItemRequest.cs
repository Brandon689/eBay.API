﻿using eBay.API.Models.SellerStore;
using System.Xml.Serialization;

namespace eBay.API.Models.Requests
{
    [XmlRoot("EndFixedPriceItemRequest")]
    public class EndFixedPriceItemRequest : AllBase
    {
        [XmlElement("ItemID")]
        public string ItemID { get; set; }

        [XmlElement("EndingReason")]
        public string EndingReason { get; set; }
    }
}
