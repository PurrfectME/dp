using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.Extensions;

internal static class Helpers
{
    public static TokenType ParseTokenTypeValue(string value) => Constants.TokenTypeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static AuthenticationScheme ParseAuthenticationSchemeValue(string value) => Constants.AuthenticationSchemeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static Models.HttpMethod ParseHttpMethodValue(string value) => Constants.HttpMethodMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static ThreeDSecureAuthenticationStatus ParseAuthenticationStatusValue(string value) => Constants.ThreeDSecureAuthenticationStatusMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static ThreeDSecureAuthenticationEligibilityStatus ParseAuthenticationEligibilityStatusValue(string value) => Constants.ThreeDSecureAuthenticationEligibilityStatusMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static LiabilityShift ParseLiabilityShiftValue(string value) => Constants.LiabilityShiftMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static PaymentCardType ParsePaymentCardTypeValue(string value) => Constants.PaymentCardTypeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static CardBrand ParseCardBrandValue(string value) => Constants.CardBrandMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static ItemCategory ParseItemCategoryValue(string value) => Constants.ItemCategoryMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static DisbursementMode ParseDisbursementModeValue(string value) => Constants.DisbursementModeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static AvsCode ParseAvsCodeValue(string value) => Constants.AvsCodeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static CvvCode ParseCvvCodeValue(string value) => Constants.CvvCodeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static PaymentAdviceCode ParsePaymentAdviceCodeValue(string value) => Constants.PaymentAdviceCodeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static PaymentMethodType ParsePaymentMethodTypeValue(string value) => Constants.PaymentMethodTypeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static ProcessorResponseCode ParseProcessorResponseCodeValue(string value) => Constants.ProcessorResponseCodeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static CaptureStatusReason ParseCaptureStatusReasonValue(string value) => Constants.CaptureStatusReasonMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static DisputeCategory ParseDisputeCategoryValue(string value) => Constants.DisputeCategoryMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static SellerProtectionStatus ParseSellerProtectionStatusValue(string value) => Constants.SellerProtectionStatusMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static RefundStatusReason ParseRefundStatusReasonValue(string value) => Constants.RefundStatusReasonMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static ShippingType ParseShippingTypeValue(string value) => Constants.ShippingTypeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static PaypalReferenceIdType ParsePaypalReferenceIdTypeValue(string value) => Constants.PaypalReferenceIdTypeMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static ProtectionEligibility ParseProtectionEligibilityValue(string value) => Constants.ProtectionEligibilityMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static TransactionStatus ParseTransactionStatusValue(string value) => Constants.TransactionStatusMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static Intent ParseIntentValue(string value) => Constants.IntentMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static OrderStatus ParseOrderStatusValue(string value) => Constants.OrderStatusMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static ProcessingInstruction ParseProcessingInstructionValue(string value) => Constants.ProcessingInstructionMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static RefundStatus ParseRefundStatusValue(string value) => Constants.RefundStatusMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static PayerStatus ParsePayerStatusValue(string value) => Constants.PayerStatusMap.FirstOrDefault(pair => pair.Value == value).Key;

    public static Currency ParseCurrencyValue(string value) => Constants.CurrencyCodesMap.FirstOrDefault(pair => pair.Value == value).Key; // returns Currency.None for any invalid value

    public static Country ParseCountryCodeValue(string countryCode) => Constants.CountryAddressOptionsMap.FirstOrDefault(pair => pair.Value.Code == countryCode).Key; // returns Country.None for any invalid value

    public static IEnumerable<string> ConvertToStringEnumerable(Dictionary<string, string> keyValuePairs) => keyValuePairs?.Select((key, value) => $"{key}:{value}") ?? Enumerable.Empty<string>();
}
