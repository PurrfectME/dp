using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;
public class UsersResponseDto
{
    public class Attributes
    {
        [JsonPropertyName("claims")]
        public string Claims { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("mfa-types")]
        public List<string> MfaTypes { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Included
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("first")]
        public string First { get; set; }

        [JsonPropertyName("last")]
        public string Last { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("prev")]
        public string Prev { get; set; }

        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("page-count")]
        public int PageCount { get; set; }

        [JsonPropertyName("resource-count")]
        public int ResourceCount { get; set; }
    }

    public class Referrals
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("user-groups")]
        public UserGroups UserGroups { get; set; }

        [JsonPropertyName("referrals")]
        public Referrals Referrals { get; set; }

        [JsonPropertyName("users")]
        public Users Users { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }

        [JsonPropertyName("included")]
        public List<Included> Included { get; set; }
    }

    public class UserGroups
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Users
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
