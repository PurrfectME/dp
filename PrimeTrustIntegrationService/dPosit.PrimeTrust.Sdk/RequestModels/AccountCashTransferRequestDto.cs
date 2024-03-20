using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

//TODO: create some generic models for common data
//TODO: add json attributes
public class AccountCashTransferRequestDto
{
    [JsonPropertyName("data")]
    public Data Data { get; set; }
}

public class Data
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("attributes")]
    public Attributes Attributes { get; set; }
}

public class Attributes
{
    [JsonPropertyName("amount")]
    public string Amount { get; set; }

    [JsonPropertyName("from-account-id")]
    public string FromAccountId { get; set; }

    [JsonPropertyName("to-account-id")]
    public string ToAccountId { get; set; }
}
