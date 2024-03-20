using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class TrackDepositResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("amount-expected")]
        public double AmountExpected { get; set; }

        [JsonPropertyName("cancelled-at")]
        public object CancelledAt { get; set; }

        [JsonPropertyName("clears-on")]
        public string ClearsOn { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("contingencies-cleared-on")]
        public object ContingenciesClearedOn { get; set; }

        [JsonPropertyName("currency-type")]
        public string CurrencyType { get; set; }

        [JsonPropertyName("funds-source-name")]
        public string FundsSourceName { get; set; }

        [JsonPropertyName("funds-transfer-type")]
        public string FundsTransferType { get; set; }

        [JsonPropertyName("reference")]
        public object Reference { get; set; }

        [JsonPropertyName("reversal-details")]
        public object ReversalDetails { get; set; }

        [JsonPropertyName("settlement-details")]
        public string SettlementDetails { get; set; }

        [JsonPropertyName("special-instructions")]
        public object SpecialInstructions { get; set; }

        [JsonPropertyName("special-type")]
        public object SpecialType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
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
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class FundsTransferMethod
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
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

    public class Refund
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("children")]
        public Children Children { get; set; }

        [JsonPropertyName("contingent-holds")]
        public ContingentHolds ContingentHolds { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("contribution")]
        public Contribution Contribution { get; set; }

        [JsonPropertyName("disbursement")]
        public Disbursement Disbursement { get; set; }

        [JsonPropertyName("disbursement-authorization")]
        public DisbursementAuthorization DisbursementAuthorization { get; set; }

        [JsonPropertyName("funds-transfer-method")]
        public FundsTransferMethod FundsTransferMethod { get; set; }

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
        public List<object> Included { get; set; }
    }

    public class SettledCashTransaction
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
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
