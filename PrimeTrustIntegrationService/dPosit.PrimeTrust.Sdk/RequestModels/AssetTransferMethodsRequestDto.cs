using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class AssetTransferMethodsRequestDto
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Attributes
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("cost-basis")]
        public string CostBasis { get; set; }

        [JsonPropertyName("acquisition-on")]
        public string AcquisitionOn { get; set; }

        [JsonPropertyName("currency-type")]
        public string CurrencyType { get; set; }

        [JsonPropertyName("asset-id")]
        public string AssetId { get; set; }

        [JsonPropertyName("contact-id")]
        public string ContactId { get; set; }

        [JsonPropertyName("account-id")]
        public string AccountId { get; set; }

        [JsonPropertyName("transfer-direction")]
        public string TransferDirection { get; set; }

        [JsonPropertyName("single-use")]
        public string SingleUse { get; set; }

        [JsonPropertyName("asset-transfer-type")]
        public string AssetTransferType { get; set; }
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
