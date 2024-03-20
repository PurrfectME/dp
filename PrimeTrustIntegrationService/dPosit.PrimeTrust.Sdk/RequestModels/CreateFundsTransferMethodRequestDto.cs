using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class CreateFundsTransferMethodRequestDto
{
    public class Attributes
    {
        [JsonPropertyName("contact-id")]
        public string ContactId { get; set; }

        [JsonPropertyName("bank-account-name")]
        public string BankAccountName { get; set; }

        [JsonPropertyName("bank-account-number")]
        public string BankAccountNumber { get; set; }

        [JsonPropertyName("routing-number")]
        public string RoutingNumber { get; set; }

        [JsonPropertyName("funds-transfer-type")]
        public string FundsTransferType { get; set; }
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
