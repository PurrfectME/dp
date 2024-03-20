using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class ContactReferenceResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("account-id")]
        public string AccountId { get; set; }

        [JsonPropertyName("contact-id")]
        public string ContactId { get; set; }
    }

    public class Contact
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<object> Included { get; set; }
    }
}
