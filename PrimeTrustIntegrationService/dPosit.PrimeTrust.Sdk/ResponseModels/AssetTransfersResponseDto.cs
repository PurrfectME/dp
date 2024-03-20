using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class AssetTransfersResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Asset
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetContribution
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetDisbursement
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetTransferMethod
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("cancelled-at")]
        public object CancelledAt { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("contingencies-cleared-on")]
        public string ContingenciesClearedOn { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("unit-count")]
        public int UnitCount { get; set; }

        [JsonPropertyName("unit-count-expected")]
        public int UnitCountExpected { get; set; }

        [JsonPropertyName("settlement-details")]
        public string SettlementDetails { get; set; }
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

    public class DisbursementAuthorization
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

    public class Relationships
    {
        [JsonPropertyName("contingent-holds")]
        public ContingentHolds ContingentHolds { get; set; }

        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }

        [JsonPropertyName("asset-contribution")]
        public AssetContribution AssetContribution { get; set; }

        [JsonPropertyName("asset-disbursement")]
        public AssetDisbursement AssetDisbursement { get; set; }

        [JsonPropertyName("asset-transfer-method")]
        public AssetTransferMethod AssetTransferMethod { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("disbursement-authorization")]
        public DisbursementAuthorization DisbursementAuthorization { get; set; }

        [JsonPropertyName("settled-asset-transaction")]
        public SettledAssetTransaction SettledAssetTransaction { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<object> Included { get; set; }
    }

    public class SettledAssetTransaction
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
