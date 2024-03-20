using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class AccountCashTransferResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("currency-type")]
        public string CurrencyType { get; set; }

        [JsonPropertyName("reference")]
        public object Reference { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("reversal-details")]
        public object ReversalDetails { get; set; }

        [JsonPropertyName("contingent-hold")]
        public int ContingentHold { get; set; }

        [JsonPropertyName("disbursable")]
        public int Disbursable { get; set; }

        [JsonPropertyName("pending-transfer")]
        public int PendingTransfer { get; set; }

        [JsonPropertyName("settled")]
        public int Settled { get; set; }
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

    public class FromAccount
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class FromAccountCashTotals
    {
        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }
    }

    public class FromCashTransaction
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class FromReversedCashTransaction
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
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

    public class Relationships
    {
        [JsonPropertyName("from-account")]
        public FromAccount FromAccount { get; set; }

        [JsonPropertyName("from-account-cash-totals")]
        public FromAccountCashTotals FromAccountCashTotals { get; set; }

        [JsonPropertyName("from-cash-transaction")]
        public FromCashTransaction FromCashTransaction { get; set; }

        [JsonPropertyName("from-reversed-cash-transaction")]
        public FromReversedCashTransaction FromReversedCashTransaction { get; set; }

        [JsonPropertyName("to-account")]
        public ToAccount ToAccount { get; set; }

        [JsonPropertyName("to-account-cash-totals")]
        public ToAccountCashTotals ToAccountCashTotals { get; set; }

        [JsonPropertyName("to-cash-transaction")]
        public ToCashTransaction ToCashTransaction { get; set; }

        [JsonPropertyName("to-reversed-cash-transaction")]
        public ToReversedCashTransaction ToReversedCashTransaction { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("account")]
        public Account Account { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<Included> Included { get; set; }
    }

    public class ToAccount
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ToAccountCashTotals
    {
        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }
    }

    public class ToCashTransaction
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ToReversedCashTransaction
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}
