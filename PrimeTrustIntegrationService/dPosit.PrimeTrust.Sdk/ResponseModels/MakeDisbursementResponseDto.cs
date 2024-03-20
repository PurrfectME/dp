using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class MakeDisbursementResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetDisbursement
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class AssetTransfer
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("customer-reference")]
        public string CustomerReference { get; set; }

        [JsonPropertyName("currency-type")]
        public string CurrencyType { get; set; }

        [JsonPropertyName("payment-details")]
        public object PaymentDetails { get; set; }

        [JsonPropertyName("reference-number")]
        public object ReferenceNumber { get; set; }

        [JsonPropertyName("special-type")]
        public object SpecialType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("transaction-number")]
        public object TransactionNumber { get; set; }

        [JsonPropertyName("amount-expected")]
        public object AmountExpected { get; set; }

        [JsonPropertyName("cancelled-at")]
        public object CancelledAt { get; set; }

        [JsonPropertyName("clears-on")]
        public object ClearsOn { get; set; }

        [JsonPropertyName("contingencies-cleared-on")]
        public object ContingenciesClearedOn { get; set; }

        [JsonPropertyName("funds-source-name")]
        public object FundsSourceName { get; set; }

        [JsonPropertyName("funds-transfer-type")]
        public string FundsTransferType { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("reversal-details")]
        public object ReversalDetails { get; set; }

        [JsonPropertyName("settlement-details")]
        public object SettlementDetails { get; set; }

        [JsonPropertyName("special-instructions")]
        public object SpecialInstructions { get; set; }

        [JsonPropertyName("authorized-at")]
        public object AuthorizedAt { get; set; }

        [JsonPropertyName("last-owner-verification-request-at")]
        public DateTime? LastOwnerVerificationRequestAt { get; set; }

        [JsonPropertyName("owner-verification-data")]
        public object OwnerVerificationData { get; set; }

        [JsonPropertyName("owner-verification-type")]
        public string OwnerVerificationType { get; set; }

        [JsonPropertyName("owner-verified-at")]
        public object OwnerVerifiedAt { get; set; }
    }

    public class Children
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Contact
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ContingentHolds
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Contribution
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Currency
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class Disbursement
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class DisbursementAuthorization
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class FundsTransfer
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class FundsTransferMethod
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Included
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class Parent
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class PaymentMethod
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Refund
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("disbursement-authorization")]
        public DisbursementAuthorization DisbursementAuthorization { get; set; }

        [JsonPropertyName("funds-transfer")]
        public FundsTransfer FundsTransfer { get; set; }

        [JsonPropertyName("funds-transfer-method")]
        public FundsTransferMethod FundsTransferMethod { get; set; }

        [JsonPropertyName("payment-method")]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonPropertyName("children")]
        public Children Children { get; set; }

        [JsonPropertyName("contingent-holds")]
        public ContingentHolds ContingentHolds { get; set; }

        [JsonPropertyName("contribution")]
        public Contribution Contribution { get; set; }

        [JsonPropertyName("disbursement")]
        public Disbursement Disbursement { get; set; }

        [JsonPropertyName("parent")]
        public Parent Parent { get; set; }

        [JsonPropertyName("refund")]
        public Refund Refund { get; set; }

        [JsonPropertyName("reversed-cash-transaction")]
        public ReversedCashTransaction ReversedCashTransaction { get; set; }

        [JsonPropertyName("settled-cash-transaction")]
        public SettledCashTransaction SettledCashTransaction { get; set; }

        [JsonPropertyName("shortage-from-child")]
        public ShortageFromChild ShortageFromChild { get; set; }

        [JsonPropertyName("surplus-to-child")]
        public SurplusToChild SurplusToChild { get; set; }

        [JsonPropertyName("asset-disbursement")]
        public AssetDisbursement AssetDisbursement { get; set; }

        [JsonPropertyName("asset-transfer")]
        public AssetTransfer AssetTransfer { get; set; }
    }

    public class ReversedCashTransaction
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<Included> Included { get; set; }
    }

    public class SettledCashTransaction
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class ShortageFromChild
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class SurplusToChild
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}
