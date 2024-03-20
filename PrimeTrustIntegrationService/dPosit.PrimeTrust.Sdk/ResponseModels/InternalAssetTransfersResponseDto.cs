using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class InternalAssetTransfersResponseDto
{
    public class Asset
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("preserve-tax-lots")]
        public bool PreserveTaxLots { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("unit-count")]
        public int UnitCount { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime UpdatedAt { get; set; }
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

    public class FromAssetTransaction
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
        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }

        [JsonPropertyName("from-account")]
        public FromAccount FromAccount { get; set; }

        [JsonPropertyName("from-asset-transaction")]
        public FromAssetTransaction FromAssetTransaction { get; set; }

        [JsonPropertyName("to-account")]
        public ToAccount ToAccount { get; set; }

        [JsonPropertyName("to-asset-transaction")]
        public ToAssetTransaction ToAssetTransaction { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<object> Included { get; set; }
    }

    public class ToAccount
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ToAssetTransaction
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
