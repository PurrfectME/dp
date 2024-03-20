using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class WithdrawAssetRequestDto
{
    public class AssetTransfer
    {
        [JsonPropertyName("asset-transfer-method-id")]
        public string AssetTransferMethodId { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("asset-id")]
        public string AssetId { get; set; }

        [JsonPropertyName("asset-transfer")]
        public AssetTransfer AssetTransfer { get; set; }

        [JsonPropertyName("unit-count")]
        public string UnitCount { get; set; }

        [JsonPropertyName("account-id")]
        public string AccountId { get; set; }

        [JsonPropertyName("contact-id")]
        public string ContactId { get; set; }
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
