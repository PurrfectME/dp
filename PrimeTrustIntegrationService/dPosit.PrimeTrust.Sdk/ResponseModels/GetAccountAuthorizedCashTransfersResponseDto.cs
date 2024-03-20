using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class GetAccountAuthorizedCashTransfersResponseDto
{
    public class Attributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }
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
    }

    public class Meta
    {
        [JsonPropertyName("page-count")]
        public int PageCount { get; set; }

        [JsonPropertyName("resource-count")]
        public int ResourceCount { get; set; }
    }

    public class Relationships
    {
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
        public List<object> Included { get; set; }
    }
}
