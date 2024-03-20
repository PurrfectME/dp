using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.RequestModels;

public class CreateEntityAccountRequestDto
{
    public class AccountQuestionnaire
    {
        [JsonPropertyName("nature-of-business-of-the-company")]
        public string NatureOfBusinessOfTheCompany { get; set; }

        [JsonPropertyName("purpose-of-account")]
        public string PurposeOfAccount { get; set; }

        [JsonPropertyName("source-of-assets-and-income")]
        public string SourceOfAssetsAndIncome { get; set; }

        [JsonPropertyName("intended-use-of-account")]
        public string IntendedUseOfAccount { get; set; }

        [JsonPropertyName("anticipated-monthly-cash-volume")]
        public string AnticipatedMonthlyCashVolume { get; set; }

        [JsonPropertyName("anticipated-monthly-transactions-incoming")]
        public string AnticipatedMonthlyTransactionsIncoming { get; set; }

        [JsonPropertyName("anticipated-monthly-transactions-outgoing")]
        public string AnticipatedMonthlyTransactionsOutgoing { get; set; }

        [JsonPropertyName("anticipated-types-of-assets")]
        public string AnticipatedTypesOfAssets { get; set; }

        [JsonPropertyName("anticipated-trading-patterns")]
        public string AnticipatedTradingPatterns { get; set; }

        [JsonPropertyName("associations-with-other-accounts")]
        public string AssociationsWithOtherAccounts { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("account-type")]
        public string AccountType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("authorized-signature")]
        public string AuthorizedSignature { get; set; }

        [JsonPropertyName("owner")]
        public Owner Owner { get; set; }

        [JsonPropertyName("webhook-config")]
        public WebhookConfig WebhookConfig { get; set; }

        [JsonPropertyName("account-questionnaire")]
        public AccountQuestionnaire AccountQuestionnaire { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }
    }

    public class Owner
    {
        [JsonPropertyName("contact-type")]
        public string ContactType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("geolocation")]
        public string Geolocation { get; set; }

        [JsonPropertyName("ip-address")]
        public string IpAddress { get; set; }

        [JsonPropertyName("tax-id-number")]
        public string TaxIdNumber { get; set; }

        [JsonPropertyName("tax-country")]
        public string TaxCountry { get; set; }

        [JsonPropertyName("region-of-formation")]
        public string RegionOfFormation { get; set; }

        [JsonPropertyName("primary-phone-number")]
        public PrimaryPhoneNumber PrimaryPhoneNumber { get; set; }

        [JsonPropertyName("primary-address")]
        public PrimaryAddress PrimaryAddress { get; set; }

        [JsonPropertyName("related-contacts")]
        public List<RelatedContact> RelatedContacts { get; set; }
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

    public class PrimaryPhoneNumber
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("sms")]
        public bool Sms { get; set; }
    }

    public class RelatedContact
    {
        [JsonPropertyName("contact-type")]
        public string ContactType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("geolocation")]
        public string Geolocation { get; set; }

        [JsonPropertyName("ip-address")]
        public string IpAddress { get; set; }

        [JsonPropertyName("tax-id-number")]
        public string TaxIdNumber { get; set; }

        [JsonPropertyName("tax-country")]
        public string TaxCountry { get; set; }

        [JsonPropertyName("date-of-birth")]
        public string DateOfBirth { get; set; }

        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("primary-phone-number")]
        public PrimaryPhoneNumber PrimaryPhoneNumber { get; set; }

        [JsonPropertyName("primary-address")]
        public PrimaryAddress PrimaryAddress { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class WebhookConfig
    {
        [JsonPropertyName("contact-email")]
        public string ContactEmail { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
