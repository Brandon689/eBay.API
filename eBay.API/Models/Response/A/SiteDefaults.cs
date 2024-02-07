using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("SiteDefaults")]
    public class SiteDefaults
    {
        [XmlElement("ShippingTermsRequired")]
        public bool ShippingTermsRequired { get; set; }

        [XmlElement("BestOfferEnabled")]
        public bool BestOfferEnabled { get; set; }

        [XmlElement("DutchBINEnabled")]
        public bool DutchBINEnabled { get; set; }

        [XmlElement("UserConsentRequired")]
        public bool UserConsentRequired { get; set; }

        [XmlElement("HomePageFeaturedEnabled")]
        public bool HomePageFeaturedEnabled { get; set; }

        [XmlElement("ProPackEnabled")]
        public bool ProPackEnabled { get; set; }

        [XmlElement("BasicUpgradePackEnabled")]
        public bool BasicUpgradePackEnabled { get; set; }

        [XmlElement("ValuePackEnabled")]
        public bool ValuePackEnabled { get; set; }

        [XmlElement("ProPackPlusEnabled")]
        public bool ProPackPlusEnabled { get; set; }

        [XmlElement("AdFormatEnabled")]
        public string AdFormatEnabled { get; set; }

        [XmlElement("BestOfferCounterEnabled")]
        public bool BestOfferCounterEnabled { get; set; }

        [XmlElement("BestOfferAutoDeclineEnabled")]
        public bool BestOfferAutoDeclineEnabled { get; set; }

        [XmlElement("LocalMarketSpecialitySubscription")]
        public bool LocalMarketSpecialitySubscription { get; set; }

        [XmlElement("LocalMarketRegularSubscription")]
        public bool LocalMarketRegularSubscription { get; set; }

        [XmlElement("LocalMarketPremiumSubscription")]
        public bool LocalMarketPremiumSubscription { get; set; }

        [XmlElement("LocalMarketNonSubscription")]
        public bool LocalMarketNonSubscription { get; set; }

        [XmlElement("ExpressEnabled")]
        public bool ExpressEnabled { get; set; }

        [XmlElement("ExpressPicturesRequired")]
        public bool ExpressPicturesRequired { get; set; }

        [XmlElement("ExpressConditionRequired")]
        public bool ExpressConditionRequired { get; set; }

        [XmlElement("MinimumReservePrice")]
        public double MinimumReservePrice { get; set; }

        [XmlElement("SellerContactDetailsEnabled")]
        public bool SellerContactDetailsEnabled { get; set; }

        [XmlElement("TransactionConfirmationRequestEnabled")]
        public bool TransactionConfirmationRequestEnabled { get; set; }

        [XmlElement("StoreInventoryEnabled")]
        public bool StoreInventoryEnabled { get; set; }

        [XmlElement("SkypeMeTransactionalEnabled")]
        public bool SkypeMeTransactionalEnabled { get; set; }

        [XmlElement("SkypeMeNonTransactionalEnabled")]
        public bool SkypeMeNonTransactionalEnabled { get; set; }

        [XmlElement("ClassifiedAdPaymentMethodEnabled")]
        public string ClassifiedAdPaymentMethodEnabled { get; set; }

        [XmlElement("ClassifiedAdShippingMethodEnabled")]
        public bool ClassifiedAdShippingMethodEnabled { get; set; }

        [XmlElement("ClassifiedAdBestOfferEnabled")]
        public string ClassifiedAdBestOfferEnabled { get; set; }

        [XmlElement("ClassifiedAdCounterOfferEnabled")]
        public bool ClassifiedAdCounterOfferEnabled { get; set; }

        [XmlElement("ClassifiedAdAutoDeclineEnabled")]
        public bool ClassifiedAdAutoDeclineEnabled { get; set; }

        [XmlElement("ClassifiedAdContactByPhoneEnabled")]
        public bool ClassifiedAdContactByPhoneEnabled { get; set; }

        [XmlElement("ClassifiedAdContactByEmailEnabled")]
        public bool ClassifiedAdContactByEmailEnabled { get; set; }

        [XmlElement("SafePaymentRequired")]
        public bool SafePaymentRequired { get; set; }

        [XmlElement("ItemSpecificsEnabled")]
        public string ItemSpecificsEnabled { get; set; }

        [XmlElement("ClassifiedAdAutoAcceptEnabled")]
        public bool ClassifiedAdAutoAcceptEnabled { get; set; }

        [XmlElement("BestOfferAutoAcceptEnabled")]
        public bool BestOfferAutoAcceptEnabled { get; set; }

        [XmlElement("CrossBorderTradeNorthAmericaEnabled")]
        public bool CrossBorderTradeNorthAmericaEnabled { get; set; }

        [XmlElement("CrossBorderTradeGBEnabled")]
        public bool CrossBorderTradeGBEnabled { get; set; }

        [XmlElement("CrossBorderTradeAustraliaEnabled")]
        public bool CrossBorderTradeAustraliaEnabled { get; set; }

        [XmlElement("PayPalBuyerProtectionEnabled")]
        public bool PayPalBuyerProtectionEnabled { get; set; }

        [XmlElement("BuyerGuaranteeEnabled")]
        public bool BuyerGuaranteeEnabled { get; set; }

        [XmlElement("CombinedFixedPriceTreatmentEnabled")]
        public bool CombinedFixedPriceTreatmentEnabled { get; set; }

        [XmlElement("PayPalRequired")]
        public bool PayPalRequired { get; set; }

        [XmlElement("eBayMotorsProAdFormatEnabled")]
        public string EBayMotorsProAdFormatEnabled { get; set; }

        [XmlElement("eBayMotorsProContactByPhoneEnabled")]
        public bool EBayMotorsProContactByPhoneEnabled { get; set; }

        [XmlElement("eBayMotorsProContactByAddressEnabled")]
        public bool EBayMotorsProContactByAddressEnabled { get; set; }

        [XmlElement("eBayMotorsProCompanyNameEnabled")]
        public bool EBayMotorsProCompanyNameEnabled { get; set; }

        [XmlElement("eBayMotorsProContactByEmailEnabled")]
        public bool EBayMotorsProContactByEmailEnabled { get; set; }

        [XmlElement("eBayMotorsProBestOfferEnabled")]
        public string EBayMotorsProBestOfferEnabled { get; set; }

        [XmlElement("eBayMotorsProAutoAcceptEnabled")]
        public bool EBayMotorsProAutoAcceptEnabled { get; set; }

        [XmlElement("eBayMotorsProAutoDeclineEnabled")]
        public bool EBayMotorsProAutoDeclineEnabled { get; set; }

        [XmlElement("eBayMotorsProPaymentMethodCheckOutEnabled")]
        public string EBayMotorsProPaymentMethodCheckOutEnabled { get; set; }

        [XmlElement("eBayMotorsProShippingMethodEnabled")]
        public bool EBayMotorsProShippingMethodEnabled { get; set; }

        [XmlElement("eBayMotorsProCounterOfferEnabled")]
        public bool EBayMotorsProCounterOfferEnabled { get; set; }

        [XmlElement("eBayMotorsProSellerContactDetailsEnabled")]
        public bool EBayMotorsProSellerContactDetailsEnabled { get; set; }

        [XmlElement("LocalMarketAdFormatEnabled")]
        public string LocalMarketAdFormatEnabled { get; set; }

        [XmlElement("LocalMarketContactByPhoneEnabled")]
        public bool LocalMarketContactByPhoneEnabled { get; set; }

        [XmlElement("LocalMarketContactByAddressEnabled")]
        public bool LocalMarketContactByAddressEnabled { get; set; }

        [XmlElement("LocalMarketCompanyNameEnabled")]
        public bool LocalMarketCompanyNameEnabled { get; set; }

        [XmlElement("LocalMarketContactByEmailEnabled")]
        public bool LocalMarketContactByEmailEnabled { get; set; }

        [XmlElement("LocalMarketBestOfferEnabled")]
        public string LocalMarketBestOfferEnabled { get; set; }

        [XmlElement("LocalMarketAutoAcceptEnabled")]
        public bool LocalMarketAutoAcceptEnabled { get; set; }

        [XmlElement("LocalMarketAutoDeclineEnabled")]
        public bool LocalMarketAutoDeclineEnabled { get; set; }

        [XmlElement("LocalMarketPaymentMethodCheckOutEnabled")]
        public string LocalMarketPaymentMethodCheckOutEnabled { get; set; }

        [XmlElement("LocalMarketShippingMethodEnabled")]
        public bool LocalMarketShippingMethodEnabled { get; set; }

        [XmlElement("LocalMarketCounterOfferEnabled")]
        public bool LocalMarketCounterOfferEnabled { get; set; }

        [XmlElement("LocalMarketSellerContactDetailsEnabled")]
        public bool LocalMarketSellerContactDetailsEnabled { get; set; }

        [XmlElement("ClassifiedAdContactByAddressEnabled")]
        public bool ClassifiedAdContactByAddressEnabled { get; set; }

        [XmlElement("ClassifiedAdCompanyNameEnabled")]
        public bool ClassifiedAdCompanyNameEnabled { get; set; }

        [XmlElement("SpecialitySubscription")]
        public string SpecialitySubscription { get; set; }

        [XmlElement("RegularSubscription")]
        public string RegularSubscription { get; set; }

        [XmlElement("PremiumSubscription")]
        public string PremiumSubscription { get; set; }

        [XmlElement("NonSubscription")]
        public string NonSubscription { get; set; }

        [XmlElement("PayPalRequiredForStoreOwner")]
        public bool PayPalRequiredForStoreOwner { get; set; }

        [XmlElement("ReviseQuantityAllowed")]
        public bool ReviseQuantityAllowed { get; set; }

        [XmlElement("RevisePriceAllowed")]
        public bool RevisePriceAllowed { get; set; }

        [XmlElement("StoreOwnerExtendedListingDurationsEnabled")]
        public bool StoreOwnerExtendedListingDurationsEnabled { get; set; }

        [XmlElement("StoreOwnerExtendedListingDurations")]
        public StoreOwnerExtendedListingDurations StoreOwnerExtendedListingDurations { get; set; }

        [XmlElement("ReturnPolicyEnabled")]
        public bool ReturnPolicyEnabled { get; set; }

        [XmlElement("HandlingTimeEnabled")]
        public bool HandlingTimeEnabled { get; set; }

        [XmlElement("MaxFlatShippingCostCBTExempt")]
        public bool MaxFlatShippingCostCBTExempt { get; set; }

        [XmlElement("PaymentMethod")]
        public List<string> PaymentMethod { get; set; }

        [XmlElement("ZeroInsertionFeeEligible")]
        public bool ZeroInsertionFeeEligible { get; set; }

        [XmlElement("VariationsEnabled")]
        public bool VariationsEnabled { get; set; }

        [XmlElement("AttributeConversionEnabled")]
        public string AttributeConversionEnabled { get; set; }

        [XmlElement("FreeGalleryPlusEnabled")]
        public bool FreeGalleryPlusEnabled { get; set; }

        [XmlElement("FreePicturePackEnabled")]
        public bool FreePicturePackEnabled { get; set; }

        [XmlElement("ItemCompatibilityEnabled")]
        public string ItemCompatibilityEnabled { get; set; }

        [XmlElement("MinItemCompatibility")]
        public int MinItemCompatibility { get; set; }

        [XmlElement("MaxItemCompatibility")]
        public int MaxItemCompatibility { get; set; }

        [XmlElement("ConditionEnabled")]
        public string ConditionEnabled { get; set; }

        [XmlElement("ValueCategory")]
        public bool ValueCategory { get; set; }

        [XmlElement("ProductCreationEnabled")]
        public string ProductCreationEnabled { get; set; }

        [XmlElement("FixedPriceFormatDisabled")]
        public bool FixedPriceFormatDisabled { get; set; }

        [XmlElement("MaxItemSpecificsInClassified")]
        public int MaxItemSpecificsInClassified { get; set; }

        [XmlElement("MaxGranularFitmentCount")]
        public int MaxGranularFitmentCount { get; set; }

        [XmlElement("ShippingProfileCategoryGroup")]
        public string ShippingProfileCategoryGroup { get; set; }

        [XmlElement("PaymentProfileCategoryGroup")]
        public string PaymentProfileCategoryGroup { get; set; }

        [XmlElement("ReturnPolicyProfileCategoryGroup")]
        public string ReturnPolicyProfileCategoryGroup { get; set; }

        [XmlElement("VINSupported")]
        public bool VINSupported { get; set; }

        [XmlElement("VRMSupported")]
        public bool VRMSupported { get; set; }

        [XmlElement("SellerProvidedTitleSupported")]
        public bool SellerProvidedTitleSupported { get; set; }

        [XmlElement("DepositSupported")]
        public bool DepositSupported { get; set; }

        [XmlElement("GlobalShippingEnabled")]
        public bool GlobalShippingEnabled { get; set; }

        [XmlElement("AdditionalCompatibilityEnabled")]
        public bool AdditionalCompatibilityEnabled { get; set; }

        [XmlElement("PickupDropOffEnabled")]
        public bool PickupDropOffEnabled { get; set; }

        [XmlElement("DigitalGoodDeliveryEnabled")]
        public bool DigitalGoodDeliveryEnabled { get; set; }

        [XmlElement("ProductRequiredEnabled")]
        public string ProductRequiredEnabled { get; set; }

        [XmlElement("DomesticReturnsAcceptedValues")]
        public DomesticReturnsAcceptedValues DomesticReturnsAcceptedValues { get; set; }

        [XmlElement("InternationalReturnsAcceptedValues")]
        public InternationalReturnsAcceptedValues InternationalReturnsAcceptedValues { get; set; }

        [XmlElement("DomesticReturnsDurationValues")]
        public DomesticReturnsDurationValues DomesticReturnsDurationValues { get; set; }

        [XmlElement("InternationalReturnsDurationValues")]
        public InternationalReturnsDurationValues InternationalReturnsDurationValues { get; set; }

        [XmlElement("DomesticReturnsShipmentPayeeValues")]
        public DomesticReturnsShipmentPayeeValues DomesticReturnsShipmentPayeeValues { get; set; }

        [XmlElement("InternationalReturnsShipmentPayeeValues")]
        public InternationalReturnsShipmentPayeeValues InternationalReturnsShipmentPayeeValues { get; set; }

        [XmlElement("DomesticRefundMethodValues")]
        public DomesticRefundMethodValues DomesticRefundMethodValues { get; set; }

        [XmlElement("InternationalRefundMethodValues")]
        public InternationalRefundMethodValues InternationalRefundMethodValues { get; set; }

        [XmlElement("ReturnPolicyDescriptionEnabled")]
        public bool ReturnPolicyDescriptionEnabled { get; set; }
    }
}
