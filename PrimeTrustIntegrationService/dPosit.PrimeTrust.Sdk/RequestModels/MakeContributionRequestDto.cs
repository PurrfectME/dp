using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class MakeContributionRequestDto
{
    public class Attributes
    {
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("contact-id")]
        public string ContactId { get; set; }

        [JsonPropertyName("funds-transfer-method-id")]
        public string FundsTransferMethodId { get; set; }

        [JsonPropertyName("account-id")]
        public string AccountId { get; set; }
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
