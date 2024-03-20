using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class AssetContributionRequestDto
{
    public class Attributes
    {
        [JsonPropertyName("unit-count")]
        public int UnitCount { get; set; }

        [JsonPropertyName("asset-id")]
        public string AssetId { get; set; }

        [JsonPropertyName("account-id")]
        public string AccountId { get; set; }

        [JsonPropertyName("contact-id")]
        public string ContactId { get; set; }

        [JsonPropertyName("asset-transfer-method-id")]
        public string AssetTransferMethodId { get; set; }

        [JsonPropertyName("acquisition-on")]
        public string AcquisitionOn { get; set; }

        [JsonPropertyName("cost-basis")]
        public string CostBasis { get; set; }

        [JsonPropertyName("currency-type")]
        public string CurrencyType { get; set; }
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
