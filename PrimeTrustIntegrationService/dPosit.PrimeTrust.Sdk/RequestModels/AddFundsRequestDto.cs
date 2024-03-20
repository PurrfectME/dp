using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class AddFundsRequestDto
{
    [JsonPropertyName("data")]
    public FundsData Data { get; set; }
}

public class FundsData
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("attributes")]
    public FundsAttributes Attributes { get; set; }

}

public class FundsAttributes
{
    [JsonPropertyName("amount")]
    public string Amount { get; set; }
}
