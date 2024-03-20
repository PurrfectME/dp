using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class AddFundsResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountCashTransferFrom
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountCashTransferTo
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("comments-1")]
        public string Comments1 { get; set; }

        [JsonPropertyName("comments-2")]
        public object Comments2 { get; set; }

        [JsonPropertyName("comments-3")]
        public object Comments3 { get; set; }

        [JsonPropertyName("comments-4")]
        public object Comments4 { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("currency-type")]
        public string CurrencyType { get; set; }

        [JsonPropertyName("effective-at")]
        public DateTime EffectiveAt { get; set; }

        [JsonPropertyName("funds-transfer-type")]
        public string FundsTransferType { get; set; }

        [JsonPropertyName("ops-reference")]
        public object OpsReference { get; set; }

        [JsonPropertyName("reconciled")]
        public bool Reconciled { get; set; }

        [JsonPropertyName("settled-on")]
        public string SettledOn { get; set; }

        [JsonPropertyName("special-type")]
        public object SpecialType { get; set; }
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

    public class FundsTransfer
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class ReconcileItem
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("funds-transfer")]
        public FundsTransfer FundsTransfer { get; set; }

        [JsonPropertyName("account-cash-transfer-from")]
        public AccountCashTransferFrom AccountCashTransferFrom { get; set; }

        [JsonPropertyName("account-cash-transfer-to")]
        public AccountCashTransferTo AccountCashTransferTo { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("reconcile-item")]
        public ReconcileItem ReconcileItem { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<object> Included { get; set; }
    }
}
