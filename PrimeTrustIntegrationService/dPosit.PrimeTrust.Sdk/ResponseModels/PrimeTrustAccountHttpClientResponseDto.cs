using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

//todo: will be move to external classes
public class PrimeTrustAccountHttpClientResponseDto
{
    public class Attributes
    {
        [JsonPropertyName("claims")]
        public Claims Claims { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("mfa-types")]
        public List<object> MfaTypes { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Claims
    {
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
        [JsonPropertyName("user-groups")]
        public UserGroups UserGroups { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<object> Included { get; set; }
    }

    public class UserGroups
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
