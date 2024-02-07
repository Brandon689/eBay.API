using System.Xml.Serialization;

namespace eBay.API.Models.Response.A
{
    [XmlRoot("FeatureDefinitions")]
    public class FeatureDefinitions
    {
        [XmlElement("ListingDurations")]
        public ListingDurations ListingDurations { get; set; }

        [XmlElement("ShippingTermsRequired")]
        public object ShippingTermsRequired { get; set; }

        [XmlElement("BestOfferEnabled")]
        public object BestOfferEnabled { get; set; }

        [XmlElement("DutchBINEnabled")]
        public object DutchBINEnabled { get; set; }

        [XmlElement("UserConsentRequired")]
        public object UserConsentRequired { get; set; }

        [XmlElement("HomePageFeaturedEnabled")]
        public object HomePageFeaturedEnabled { get; set; }

        [XmlElement("ProPackEnabled")]
        public object ProPackEnabled { get; set; }

        [XmlElement("BasicUpgradePackEnabled")]
        public object BasicUpgradePackEnabled { get; set; }

        [XmlElement("ValuePackEnabled")]
        public object ValuePackEnabled { get; set; }

        [XmlElement("ProPackPlusEnabled")]
        public object ProPackPlusEnabled { get; set; }

        [XmlElement("AdFormatEnabled")]
        public object AdFormatEnabled { get; set; }

        [XmlElement("BestOfferCounterEnabled")]
        public object BestOfferCounterEnabled { get; set; }

        [XmlElement("BestOfferAutoDeclineEnabled")]
        public object BestOfferAutoDeclineEnabled { get; set; }

        [XmlElement("LocalMarketSpecialitySubscription")]
        public object LocalMarketSpecialitySubscription { get; set; }

        [XmlElement("LocalMarketRegularSubscription")]
        public object LocalMarketRegularSubscription { get; set; }

        [XmlElement("LocalMarketPremiumSubscription")]
        public object LocalMarketPremiumSubscription { get; set; }

        [XmlElement("LocalMarketNonSubscription")]
        public object LocalMarketNonSubscription { get; set; }

        [XmlElement("ExpressEnabled")]
        public object ExpressEnabled { get; set; }

        [XmlElement("ExpressPicturesRequired")]
        public object ExpressPicturesRequired { get; set; }

        [XmlElement("ExpressConditionRequired")]
        public object ExpressConditionRequired { get; set; }

        [XmlElement("MinimumReservePrice")]
        public object MinimumReservePrice { get; set; }

        [XmlElement("TransactionConfirmationRequestEnabled")]
        public object TransactionConfirmationRequestEnabled { get; set; }

        [XmlElement("SellerContactDetailsEnabled")]
        public object SellerContactDetailsEnabled { get; set; }

        [XmlElement("StoreInventoryEnabled")]
        public object StoreInventoryEnabled { get; set; }

        [XmlElement("SkypeMeTransactionalEnabled")]
        public object SkypeMeTransactionalEnabled { get; set; }

        [XmlElement("SkypeMeNonTransactionalEnabled")]
        public object SkypeMeNonTransactionalEnabled { get; set; }

        [XmlElement("ClassifiedAdPaymentMethodEnabled")]
        public object ClassifiedAdPaymentMethodEnabled { get; set; }

        [XmlElement("ClassifiedAdShippingMethodEnabled")]
        public object ClassifiedAdShippingMethodEnabled { get; set; }

        [XmlElement("ClassifiedAdBestOfferEnabled")]
        public object ClassifiedAdBestOfferEnabled { get; set; }

        [XmlElement("ClassifiedAdCounterOfferEnabled")]
        public object ClassifiedAdCounterOfferEnabled { get; set; }

        [XmlElement("ClassifiedAdAutoDeclineEnabled")]
        public object ClassifiedAdAutoDeclineEnabled { get; set; }

        [XmlElement("ClassifiedAdContactByPhoneEnabled")]
        public object ClassifiedAdContactByPhoneEnabled { get; set; }

        [XmlElement("ClassifiedAdContactByEmailEnabled")]
        public object ClassifiedAdContactByEmailEnabled { get; set; }

        [XmlElement("SafePaymentRequired")]
        public object SafePaymentRequired { get; set; }

        [XmlElement("ItemSpecificsEnabled")]
        public object ItemSpecificsEnabled { get; set; }

        [XmlElement("BestOfferAutoAcceptEnabled")]
        public object BestOfferAutoAcceptEnabled { get; set; }

        [XmlElement("ClassifiedAdAutoAcceptEnabled")]
        public object ClassifiedAdAutoAcceptEnabled { get; set; }

        [XmlElement("CrossBorderTradeNorthAmericaEnabled")]
        public object CrossBorderTradeNorthAmericaEnabled { get; set; }

        [XmlElement("CrossBorderTradeGBEnabled")]
        public object CrossBorderTradeGBEnabled { get; set; }

        [XmlElement("CrossBorderTradeAustraliaEnabled")]
        public object CrossBorderTradeAustraliaEnabled { get; set; }

        [XmlElement("PayPalBuyerProtectionEnabled")]
        public object PayPalBuyerProtectionEnabled { get; set; }

        [XmlElement("BuyerGuaranteeEnabled")]
        public object BuyerGuaranteeEnabled { get; set; }

        [XmlElement("CombinedFixedPriceTreatmentEnabled")]
        public object CombinedFixedPriceTreatmentEnabled { get; set; }

        [XmlElement("PayPalRequired")]
        public object PayPalRequired { get; set; }

        [XmlElement("eBayMotorsProAdFormatEnabled")]
        public object EBayMotorsProAdFormatEnabled { get; set; }

        [XmlElement("eBayMotorsProContactByPhoneEnabled")]
        public object EBayMotorsProContactByPhoneEnabled { get; set; }

        [XmlElement("eBayMotorsProPhoneCount")]
        public object EBayMotorsProPhoneCount { get; set; }

        [XmlElement("eBayMotorsProContactByAddressEnabled")]
        public object EBayMotorsProContactByAddressEnabled { get; set; }

        [XmlElement("eBayMotorsProStreetCount")]
        public object EBayMotorsProStreetCount { get; set; }

        [XmlElement("eBayMotorsProCompanyNameEnabled")]
        public object EBayMotorsProCompanyNameEnabled { get; set; }

        [XmlElement("eBayMotorsProContactByEmailEnabled")]
        public object EBayMotorsProContactByEmailEnabled { get; set; }

        [XmlElement("eBayMotorsProBestOfferEnabled")]
        public object EBayMotorsProBestOfferEnabled { get; set; }

        [XmlElement("eBayMotorsProAutoAcceptEnabled")]
        public object EBayMotorsProAutoAcceptEnabled { get; set; }

        [XmlElement("eBayMotorsProAutoDeclineEnabled")]
        public object EBayMotorsProAutoDeclineEnabled { get; set; }

        [XmlElement("eBayMotorsProPaymentMethodCheckOutEnabled")]
        public object EBayMotorsProPaymentMethodCheckOutEnabled { get; set; }

        [XmlElement("eBayMotorsProShippingMethodEnabled")]
        public object EBayMotorsProShippingMethodEnabled { get; set; }

        [XmlElement("eBayMotorsProCounterOfferEnabled")]
        public object EBayMotorsProCounterOfferEnabled { get; set; }

        [XmlElement("eBayMotorsProSellerContactDetailsEnabled")]
        public object EBayMotorsProSellerContactDetailsEnabled { get; set; }

        [XmlElement("LocalMarketAdFormatEnabled")]
        public object LocalMarketAdFormatEnabled { get; set; }

        [XmlElement("LocalMarketContactByPhoneEnabled")]
        public object LocalMarketContactByPhoneEnabled { get; set; }

        [XmlElement("LocalMarketPhoneCount")]
        public object LocalMarketPhoneCount { get; set; }

        [XmlElement("LocalMarketContactByAddressEnabled")]
        public object LocalMarketContactByAddressEnabled { get; set; }

        [XmlElement("LocalMarketStreetCount")]
        public object LocalMarketStreetCount { get; set; }

        [XmlElement("LocalMarketCompanyNameEnabled")]
        public object LocalMarketCompanyNameEnabled { get; set; }

        [XmlElement("LocalMarketContactByEmailEnabled")]
        public object LocalMarketContactByEmailEnabled { get; set; }

        [XmlElement("LocalMarketBestOfferEnabled")]
        public object LocalMarketBestOfferEnabled { get; set; }

        [XmlElement("LocalMarketAutoAcceptEnabled")]
        public object LocalMarketAutoAcceptEnabled { get; set; }

        [XmlElement("LocalMarketAutoDeclineEnabled")]
        public object LocalMarketAutoDeclineEnabled { get; set; }

        [XmlElement("LocalMarketPaymentMethodCheckOutEnabled")]
        public object LocalMarketPaymentMethodCheckOutEnabled { get; set; }

        [XmlElement("LocalMarketShippingMethodEnabled")]
        public object LocalMarketShippingMethodEnabled { get; set; }

        [XmlElement("LocalMarketCounterOfferEnabled")]
        public object LocalMarketCounterOfferEnabled { get; set; }

        [XmlElement("LocalMarketSellerContactDetailsEnabled")]
        public object LocalMarketSellerContactDetailsEnabled { get; set; }

        [XmlElement("ClassifiedAdPhoneCount")]
        public object ClassifiedAdPhoneCount { get; set; }

        [XmlElement("ClassifiedAdContactByAddressEnabled")]
        public object ClassifiedAdContactByAddressEnabled { get; set; }

        [XmlElement("ClassifiedAdStreetCount")]
        public object ClassifiedAdStreetCount { get; set; }

        [XmlElement("ClassifiedAdCompanyNameEnabled")]
        public object ClassifiedAdCompanyNameEnabled { get; set; }

        [XmlElement("SpecialitySubscription")]
        public object SpecialitySubscription { get; set; }

        [XmlElement("RegularSubscription")]
        public object RegularSubscription { get; set; }

        [XmlElement("PremiumSubscription")]
        public object PremiumSubscription { get; set; }

        [XmlElement("NonSubscription")]
        public object NonSubscription { get; set; }

        [XmlElement("ReturnPolicyEnabled")]
        public object ReturnPolicyEnabled { get; set; }

        [XmlElement("HandlingTimeEnabled")]
        public object HandlingTimeEnabled { get; set; }

        [XmlElement("PayPalRequiredForStoreOwner")]
        public object PayPalRequiredForStoreOwner { get; set; }

        [XmlElement("ReviseQuantityAllowed")]
        public object ReviseQuantityAllowed { get; set; }

        [XmlElement("RevisePriceAllowed")]
        public object RevisePriceAllowed { get; set; }

        [XmlElement("StoreOwnerExtendedListingDurationsEnabled")]
        public object StoreOwnerExtendedListingDurationsEnabled { get; set; }

        [XmlElement("StoreOwnerExtendedListingDurations")]
        public object StoreOwnerExtendedListingDurations { get; set; }

        [XmlElement("PaymentMethod")]
        public object PaymentMethod { get; set; }

        [XmlElement("Group1MaxFlatShippingCost")]
        public object Group1MaxFlatShippingCost { get; set; }

        [XmlElement("Group2MaxFlatShippingCost")]
        public object Group2MaxFlatShippingCost { get; set; }

        [XmlElement("Group3MaxFlatShippingCost")]
        public object Group3MaxFlatShippingCost { get; set; }

        [XmlElement("MaxFlatShippingCostCBTExempt")]
        public object MaxFlatShippingCostCBTExempt { get; set; }

        [XmlElement("MaxFlatShippingCost")]
        public object MaxFlatShippingCost { get; set; }

        [XmlElement("ZeroInsertionFeeEligible")]
        public object ZeroInsertionFeeEligible { get; set; }

        [XmlElement("VariationsEnabled")]
        public object VariationsEnabled { get; set; }

        [XmlElement("AttributeConversionEnabled")]
        public object AttributeConversionEnabled { get; set; }

        [XmlElement("FreeGalleryPlusEnabled")]
        public object FreeGalleryPlusEnabled { get; set; }

        [XmlElement("FreePicturePackEnabled")]
        public object FreePicturePackEnabled { get; set; }

        [XmlElement("ItemCompatibilityEnabled")]
        public object ItemCompatibilityEnabled { get; set; }

        [XmlElement("MaxItemCompatibility")]
        public object MaxItemCompatibility { get; set; }

        [XmlElement("MinItemCompatibility")]
        public object MinItemCompatibility { get; set; }

        [XmlElement("ConditionEnabled")]
        public object ConditionEnabled { get; set; }

        [XmlElement("ConditionValues")]
        public object ConditionValues { get; set; }

        [XmlElement("ValueCategory")]
        public object ValueCategory { get; set; }

        [XmlElement("ProductCreationEnabled")]
        public object ProductCreationEnabled { get; set; }

        [XmlElement("FixedPriceFormatDisabled")]
        public object FixedPriceFormatDisabled { get; set; }

        [XmlElement("MaxItemSpecificsInClassified")]
        public object MaxItemSpecificsInClassified { get; set; }

        [XmlElement("CompatibleVehicleType")]
        public object CompatibleVehicleType { get; set; }

        [XmlElement("MaxGranularFitmentCount")]
        public object MaxGranularFitmentCount { get; set; }

        [XmlElement("ShippingProfileCategoryGroup")]
        public object ShippingProfileCategoryGroup { get; set; }

        [XmlElement("PaymentProfileCategoryGroup")]
        public object PaymentProfileCategoryGroup { get; set; }

        [XmlElement("ReturnPolicyProfileCategoryGroup")]
        public object ReturnPolicyProfileCategoryGroup { get; set; }

        [XmlElement("VINSupported")]
        public object VINSupported { get; set; }

        [XmlElement("VRMSupported")]
        public object VRMSupported { get; set; }

        [XmlElement("SellerProvidedTitleSupported")]
        public object SellerProvidedTitleSupported { get; set; }

        [XmlElement("DepositSupported")]
        public object DepositSupported { get; set; }

        [XmlElement("GlobalShippingEnabled")]
        public object GlobalShippingEnabled { get; set; }

        [XmlElement("AdditionalCompatibilityEnabled")]
        public object AdditionalCompatibilityEnabled { get; set; }

        [XmlElement("PickupDropOffEnabled")]
        public object PickupDropOffEnabled { get; set; }

        [XmlElement("DigitalGoodDeliveryEnabled")]
        public object DigitalGoodDeliveryEnabled { get; set; }

        [XmlElement("ProductRequiredEnabled")]
        public object ProductRequiredEnabled { get; set; }
    }
}
