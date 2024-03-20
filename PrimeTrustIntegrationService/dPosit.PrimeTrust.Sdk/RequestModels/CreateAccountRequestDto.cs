using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class CreateAccountRequestDto
{
    [JsonPropertyName("data")]
    public CreateAccountData Data { get; set; }
}

public class CreateAccountData
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("attributes")]
    public CreateAccountAttributes Attributes { get; set; }
}

public class CreateAccountAttributes
{
    [JsonPropertyName("account-type")]
    public string AccountType { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("authorized-signature")]
    public string AuthorizedSignature { get; set; }

    [JsonPropertyName("owner")]
    public AccountOwner Owner { get; set; }
}

public class AccountOwner
{
    [JsonPropertyName("contact-type")]
    public string ContactType { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("tax-id-number")]
    public string TaxIdNumber { get; set; }

    [JsonPropertyName("geolocation")]
    public string Geolocation { get; set; }

    [JsonPropertyName("ip-address")]
    public string IpAddress { get; set; }

    [JsonPropertyName("tax-country")]
    public string TaxCountry { get; set; }

    [JsonPropertyName("date-of-birth")]
    public string DateOfBirth { get; set; }

    [JsonPropertyName("sex")]
    public string Sex { get; set; }

    //TODO: select common models and move them to shared folder
    [JsonPropertyName("primary-phone-number")]
    public PrimaryPhoneNumber PrimaryPhoneNumber { get; set; }

    [JsonPropertyName("primary-address")]
    public PrimaryAddress PrimaryAddress { get; set; }
}
