using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class AgreementPreviewRequestDto
{
    [JsonPropertyName("data")]
    public AgreementData Data { get; set; }
}

public class AgreementData
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("attributes")]
    public AgreementAttributes Attributes { get; set; }
}

public class AgreementAttributes
{
    [JsonPropertyName("account-type")]
    public string AccountType { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("authorized-signature")]
    public string AuthorizedSignature { get; set; }

    [JsonPropertyName("owner")]
    public Owner Owner { get; set; }
}

public class Owner
{
    [JsonPropertyName("contact-type")]
    public string ContactType { get; set; }

    [JsonPropertyName("first-name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last-name")]
    public string LastName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("tax-id-number")]
    public string TaxIdNumber { get; set; }

    [JsonPropertyName("tax-country")]
    public string TaxCountry { get; set; }

    [JsonPropertyName("date-of-birth")]
    public string DateOfBirth { get; set; }

    [JsonPropertyName("sex")]
    public string Sex { get; set; }

    [JsonPropertyName("primary-phone-number")]
    public PrimaryPhoneNumber PrimaryPhoneNumber { get; set; }

    [JsonPropertyName("primary-address")]
    public PrimaryAddress PrimaryAddress { get; set; }
}

public class PrimaryPhoneNumber
{
    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("number")]
    public string Number { get; set; }

    [JsonPropertyName("sms")]
    public bool Sms { get; set; }
}

public class PrimaryAddress
{
    [JsonPropertyName("street-1")]
    public string Street1 { get; set; }

    [JsonPropertyName("street-2")]
    public string Street2 { get; set; }

    [JsonPropertyName("postal-code")]
    public string PostalCode { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }
}
