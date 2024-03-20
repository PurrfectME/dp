using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class InternalAssetTransfersRequestDto
{
    public class Attributes
    {
        [JsonPropertyName("unit-count")]
        public string UnitCount { get; set; }

        [JsonPropertyName("asset-id")]
        public string AssetId { get; set; }

        [JsonPropertyName("from-account-id")]
        public string FromAccountId { get; set; }

        [JsonPropertyName("to-account-id")]
        public string ToAccountId { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}
