using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class MakeDisbursementRequestDto
{
    public class Attributes
    {
        [JsonPropertyName("account-id")]
        public string AccountId { get; set; }

        [JsonPropertyName("funds-transfer-method-id")]
        public string FundsTransferMethodId { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

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
