using System.Xml.Serialization;

namespace eBay.API.Models.Response
{
    [XmlRoot("SellerInfo")]
    public class SellerInfo
    {
        [XmlElement("AllowPaymentEdit")]
        public bool AllowPaymentEdit { get; set; }

        [XmlElement("CheckoutEnabled")]
        public bool CheckoutEnabled { get; set; }

        [XmlElement("CIPBankAccountStored")]
        public bool CIPBankAccountStored { get; set; }

        [XmlElement("GoodStanding")]
        public bool GoodStanding { get; set; }

        [XmlElement("LiveAuctionAuthorized")]
        public bool LiveAuctionAuthorized { get; set; }

        [XmlElement("MerchandizingPref")]
        public string MerchandizingPref { get; set; }

        [XmlElement("QualifiesForB2BVAT")]
        public bool QualifiesForB2BVAT { get; set; }

        [XmlElement("SellerGuaranteeLevel")]
        public string SellerGuaranteeLevel { get; set; }

        [XmlElement("SellerPaymentAddress")]
        public object SellerPaymentAddress { get; set; }

        [XmlElement("SchedulingInfo")]
        public SchedulingInfo SchedulingInfo { get; set; }

        [XmlElement("StoreOwner")]
        public bool StoreOwner { get; set; }

        [XmlElement("SellerBusinessType")]
        public string SellerBusinessType { get; set; }

        [XmlElement("PaymentMethod")]
        public string PaymentMethod { get; set; }

        [XmlElement("CharityRegistered")]
        public bool CharityRegistered { get; set; }

        [XmlElement("SafePaymentExempt")]
        public bool SafePaymentExempt { get; set; }

        [XmlElement("TransactionPercent")]
        public double TransactionPercent { get; set; }

        [XmlElement("RecoupmentPolicyConsent")]
        public object RecoupmentPolicyConsent { get; set; }

        [XmlElement("DomesticRateTable")]
        public bool DomesticRateTable { get; set; }

        [XmlElement("InternationalRateTable")]
        public bool InternationalRateTable { get; set; }
    }
}
