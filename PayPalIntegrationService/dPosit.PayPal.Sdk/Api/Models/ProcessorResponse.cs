using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ProcessorResponse
{
    /// <summary>
    /// The address verification code for Visa, Discover, Mastercard, or American Express transactions.
    /// </summary>
    /// <value>
    /// "A" - for Visa, Mastercard, or Discover transactions, the address matches but the zip code does not match. For American Express
    /// transactions, the card holder address is correct.<br/>
    /// "B" - for Visa, Mastercard, or Discover transactions, the address matches. International A.<br/>
    /// "C" - for Visa, Mastercard, or Discover transactions, no values match. International N.<br/>
    /// "D" - for Visa, Mastercard, or Discover transactions, the address and postal code match. International X.<br/>
    /// "E" - for Visa, Mastercard, or Discover transactions, not allowed for Internet or phone transactions. For American Express card
    /// holder, the name is incorrect but the address and postal code match.<br/>
    /// "F" - for Visa, Mastercard, or Discover transactions, the address and postal code match. UK-specific X. For American Express
    /// card holder, the name is incorrect but the address matches.<br/>
    /// "G" - for Visa, Mastercard, or Discover transactions, global is unavailable. Nothing matches.<br/>
    /// "I" - for Visa, Mastercard, or Discover transactions, international is unavailable. Not applicable.<br/>
    /// "M" - for Visa, Mastercard, or Discover transactions, the address and postal code match. For American Express card holder, the
    /// name, address, and postal code match.<br/>
    /// "N" - for Visa, Mastercard, or Discover transactions, nothing matches. For American Express card holder, the address and postal
    /// code are both incorrect.<br/>
    /// "P" - for Visa, Mastercard, or Discover transactions, postal international Z. Postal code only.<br/>
    /// "R" - for Visa, Mastercard, or Discover transactions, re-try the request. For American Express, the system is unavailable.<br/>
    /// "S" - for Visa, Mastercard, Discover, or American Express, the service is not supported.<br/>
    /// "U" - for Visa, Mastercard, or Discover transactions, the service is unavailable. For American Express, information is not
    /// available. For Maestro, the address is not checked or the acquirer had no response. The service is not available.<br/>
    /// "W" - for Visa, Mastercard, or Discover transactions, whole ZIP code. For American Express, the card holder name, address, and
    /// postal code are all incorrect.<br/>
    /// "X" - for Visa, Mastercard, or Discover transactions, exact match of the address and the nine-digit ZIP code. For American
    /// Express, the card holder name, address, and postal code are all incorrect.<br/>
    /// "Y" - for Visa, Mastercard, or Discover transactions, the address and five-digit ZIP code match. For American Express, the
    /// card holder address and postal code are both correct.<br/>
    /// "Z" - for Visa, Mastercard, or Discover transactions, the five-digit ZIP code matches but no address. For American Express,
    /// only the card holder postal code is correct.<br/>
    /// "Null" - for Maestro, no AVS response was obtained.<br/>
    /// "0" - for Maestro, all address information matches.<br/>
    /// "1" - for Maestro, none of the address information matches.<br/>
    /// "2" - for Maestro, part of the address information matches.<br/>
    /// "3" - for Maestro, the merchant did not provide AVS information. It was not processed.<br/>
    /// "4" - for Maestro, the address was not checked or the acquirer had no response. The service is not available.
    /// </value>
    [JsonPropertyName("avs_code")]
    public string AvsCode { get; set; }

    /// <summary>
    /// The card verification value code for for Visa, Discover, Mastercard, or American Express.
    /// </summary>
    /// <value>
    /// "E" - for Visa, Mastercard, Discover, or American Express, error - unrecognized or unknown response.<br/>
    /// "I" - for Visa, Mastercard, Discover, or American Express, invalid or null.<br/>
    /// "M" - for Visa, Mastercard, Discover, or American Express, the CVV2/CSC matches.<br/>
    /// "N" - for Visa, Mastercard, Discover, or American Express, the CVV2/CSC does not match.<br/>
    /// "P" - for Visa, Mastercard, Discover, or American Express, it was not processed.<br/>
    /// "S" - for Visa, Mastercard, Discover, or American Express, the service is not supported.<br/>
    /// "U" - for Visa, Mastercard, Discover, or American Express, unknown - the issuer is not certified.<br/>
    /// "X" - for Visa, Mastercard, Discover, or American Express, no response. For Maestro, the service is not available.<br/>
    /// "All others" - for Visa, Mastercard, Discover, or American Express, error.<br/>
    /// "0" - for Maestro, the CVV2 matched.<br/>
    /// "1" - for Maestro, the CVV2 did not match.<br/>
    /// "2" - for Maestro, the merchant has not implemented CVV2 code handling.<br/>
    /// "3" - for Maestro, the merchant has indicated that CVV2 is not present on card.<br/>
    /// "4" - for Maestro, the service is not available.
    /// </value>
    [JsonPropertyName("cvv_code")]
    public string CvvCode { get; set; }

    /// <summary>
    /// The declined payment transactions might have payment advice codes. The card networks, like Visa and Mastercard, return payment
    /// advice codes.
    /// </summary>
    /// <value>
    /// "01" - for Mastercard, expired card account upgrade or portfolio sale conversion. Obtain new account information before next
    /// billing cycle.<br/>
    /// "02" - for Mastercard, over credit limit or insufficient funds. Retry the transaction 72 hours later. For Visa, the card holder
    /// wants to stop only one specific payment in the recurring payment relationship. The merchant must NOT resubmit the same transaction.
    /// The merchant can continue the billing process in the subsequent billing period.<br/>
    /// "03" - for Mastercard, account closed as fraudulent. Obtain another type of payment from customer due to account being closed or
    /// fraud. Possible reason: Account closed as fraudulent. For Visa, the card holder wants to stop all recurring payment transactions
    /// for a specific merchant. Stop recurring payment requests.<br/>
    /// "21" - for Mastercard, the card holder has been unsuccessful at canceling recurring payment through merchant. Stop recurring
    /// payment requests. For Visa, all recurring payments were canceled for the card number requested. Stop recurring payment requests.
    /// </value>
    [JsonPropertyName("payment_advice_code")]
    public string PaymentAdviceCode { get; set; }

    /// <summary>
    /// Processor response code for the non-PayPal payment processor errors.
    /// </summary>
    /// <value>
    /// "0000" - APPROVED.<br/>
    /// "00N7" - CVV2_FAILURE_POSSIBLE_RETRY_WITH_CVV.<br/>
    /// "0100" - REFERRAL.<br/>
    /// "0390" - ACCOUNT_NOT_FOUND.<br/>
    /// "0500" - DO_NOT_HONOR.<br/>
    /// "0580" - UNAUTHORIZED_TRANSACTION.<br/>
    /// "0800" - BAD_RESPONSE_REVERSAL_REQUIRED.<br/>
    /// "0880" - CRYPTOGRAPHIC_FAILURE.<br/>
    /// "0R00" - CANCELLED_PAYMENT.<br/>
    /// "1000" - PARTIAL_AUTHORIZATION.<br/>
    /// "10BR" - ISSUER_REJECTED.<br/>
    /// "1300" - INVALID_DATA_FORMAT.<br/>
    /// "1310" - INVALID_AMOUNT.<br/>
    /// "1312" - INVALID_TRANSACTION_CARD_ISSUER_ACQUIRER.<br/>
    /// "1317" - INVALID_CAPTURE_DATE.<br/>
    /// "1320" - INVALID_CURRENCY_CODE.<br/>
    /// "1330" - INVALID_ACCOUNT.<br/>
    /// "1335" - INVALID_ACCOUNT_RECURRING.<br/>
    /// "1340" - INVALID_TERMINAL.<br/>
    /// "1350" - INVALID_MERCHANT.<br/>
    /// "1360" - BAD_PROCESSING_CODE.<br/>
    /// "1370" - INVALID_MCC.<br/>
    /// "1380" - INVALID_EXPIRATION.<br/>
    /// "1382" - INVALID_CARD_VERIFICATION_VALUE.<br/>
    /// "1384" - INVALID_LIFE_CYCLE_OF_TRANSACTION.<br/>
    /// "1390" - INVALID_ORDER.<br/>
    /// "1393" - TRANSACTION_CANNOT_BE_COMPLETED.<br/>
    /// "5100" - GENERIC_DECLINE.<br/>
    /// "5110" - CVV2_FAILURE.<br/>
    /// "5120" - INSUFFICIENT_FUNDS.<br/>
    /// "5130" - INVALID_PIN.<br/>
    /// "5135" - DECLINED_PIN_TRY_EXCEEDED.<br/>
    /// "5140" - CARD_CLOSED.<br/>
    /// "5150" - PICKUP_CARD_SPECIAL_CONDITIONS. Try using another card. Do not retry the same card.<br/>
    /// "5160" - UNAUTHORIZED_USER.<br/>
    /// "5170" - AVS_FAILURE.<br/>
    /// "5180" - INVALID_OR_RESTRICTED_CARD. Try using another card. Do not retry the same card.<br/>
    /// "5190" - SOFT_AVS.<br/>
    /// "5200" - DUPLICATE_TRANSACTION.<br/>
    /// "5210" - INVALID_TRANSACTION.<br/>
    /// "5400" - EXPIRED_CARD.<br/>
    /// "5500" - INCORRECT_PIN_REENTER.<br/>
    /// "5650" - DECLINED_SCA_REQUIRED.<br/>
    /// "5700" - TRANSACTION_NOT_PERMITTED. Outside of scope of accepted business.<br/>
    /// "5710" - TX_ATTEMPTS_EXCEED_LIMIT.<br/>
    /// "5800" - REVERSAL_REJECTED.<br/>
    /// "5900" - INVALID_ISSUE.<br/>
    /// "5910" - ISSUER_NOT_AVAILABLE_NOT_RETRIABLE.<br/>
    /// "5920" - ISSUER_NOT_AVAILABLE_RETRIABLE.<br/>
    /// "5930" - CARD_NOT_ACTIVATED.<br/>
    /// "6300" - ACCOUNT_NOT_ON_FILE.<br/>
    /// "7600" - APPROVED_NON_CAPTURE.<br/>
    /// "7700" - ERROR_3DS.<br/>
    /// "7710" - AUTHENTICATION_FAILED.<br/>
    /// "7800" - BIN_ERROR.<br/>
    /// "7900" - PIN_ERROR.<br/>
    /// "8000" - PROCESSOR_SYSTEM_ERROR.<br/>
    /// "8010" - HOST_KEY_ERROR.<br/>
    /// "8020" - CONFIGURATION_ERROR.<br/>
    /// "8030" - UNSUPPORTED_OPERATION.<br/>
    /// "8100" - FATAL_COMMUNICATION_ERROR.<br/>
    /// "8110" - RETRIABLE_COMMUNICATION_ERROR.<br/>
    /// "8220" - SYSTEM_UNAVAILABLE.<br/>
    /// "9100" - DECLINED_PLEASE_RETRY. Retry.<br/>
    /// "9500" - SUSPECTED_FRAUD. Try using another card. Do not retry the same card.<br/>
    /// "9510" - SECURITY_VIOLATION.<br/>
    /// "9520" - LOST_OR_STOLEN. Try using another card. Do not retry the same card.<br/>
    /// "9530" - HOLD_CALL_CENTER. The merchant must call the number on the back of the card. POS scenario.<br/>
    /// "9540" - REFUSED_CARD.<br/>
    /// "9600" - UNRECOGNIZED_RESPONSE_CODE.<br/>
    /// "PCNR" - CONTINGENCIES_NOT_RESOLVED.<br/>
    /// "PCVV" - CVV_FAILURE.<br/>
    /// "PPAD" - BILLING_ADDRESS.<br/>
    /// "PPAE" - AMEX_DISABLED.<br/>
    /// "PPAG" - ADULT_GAMING_UNSUPPORTED.<br/>
    /// "PPAI" - AMOUNT_INCOMPATIBLE.<br/>
    /// "PPAR" - AUTH_RESULT.<br/>
    /// "PPAU" - MCC_CODE.<br/>
    /// "PPAV" - ARC_AVS.<br/>
    /// "PPAX" - AMOUNT_EXCEEDED.<br/>
    /// "PPBG" - BAD_GAMING.<br/>
    /// "PPC2" - ARC_CVV.<br/>
    /// "PPCE" - CE_REGISTRATION_INCOMPLETE.<br/>
    /// "PPCO" - COUNTRY.<br/>
    /// "PPCR" - CREDIT_ERROR.<br/>
    /// "PPCT" - CARD_TYPE_UNSUPPORTED.<br/>
    /// "PPCU" - CURRENCY_USED_INVALID.<br/>
    /// "PPD3" - SECURE_ERROR_3DS.<br/>
    /// "PPDC" - DCC_UNSUPPORTED.<br/>
    /// "PPDI" - DINERS_REJECT.<br/>
    /// "PPDV" - AUTH_MESSAGE.<br/>
    /// "PPEF" - EXPIRED_FUNDING_INSTRUMENT.<br/>
    /// "PPEL" - EXCEEDS_FREQUENCY_LIMIT.<br/>
    /// "PPER" - INTERNAL_SYSTEM_ERROR.<br/>
    /// "PPEX" - EXPIRY_DATE.<br/>
    /// "PPFE" - FUNDING_SOURCE_ALREADY_EXISTS.<br/>
    /// "PPFI" - INVALID_FUNDING_INSTRUMENT.<br/>
    /// "PPFR" - RESTRICTED_FUNDING_INSTRUMENT.<br/>
    /// "PPFV" - FIELD_VALIDATION_FAILED.<br/>
    /// "PPGR" - GAMING_REFUND_ERROR.<br/>
    /// "PPH1" - H1_ERROR.<br/>
    /// "PPIF" - IDEMPOTENCY_FAILURE.<br/>
    /// "PPII" - INVALID_INPUT_FAILURE.<br/>
    /// "PPIM" - ID_MISMATCH.<br/>
    /// "PPIT" - INVALID_TRACE_ID.<br/>
    /// "PPLR" - LATE_REVERSAL.<br/>
    /// "PPLS" - LARGE_STATUS_CODE.<br/>
    /// "PPMB" - MISSING_BUSINESS_RULE_OR_DATA.<br/>
    /// "PPMC" - BLOCKED_Mastercard.<br/>
    /// "PPMD" - PPMD.<br/>
    /// "PPNC" - NOT_SUPPORTED_NRC.
    /// </value>
    [JsonPropertyName("response_code")]
    public string ResponseCode { get; set; }
}
