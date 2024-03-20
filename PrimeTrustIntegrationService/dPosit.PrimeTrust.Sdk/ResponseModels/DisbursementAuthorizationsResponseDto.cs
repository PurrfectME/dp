using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class DisbursementAuthorizationsResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetDisbursement
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetTransfer
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("authorized-at")]
        public DateTime AuthorizedAt { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("last-owner-verification-request-at")]
        public DateTime LastOwnerVerificationRequestAt { get; set; }

        [JsonPropertyName("owner-verification-data")]
        public OwnerVerificationData OwnerVerificationData { get; set; }

        [JsonPropertyName("owner-verification-type")]
        public string OwnerVerificationType { get; set; }

        [JsonPropertyName("owner-verified-at")]
        public DateTime OwnerVerifiedAt { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
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

    public class Disbursement
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class FundsTransfer
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class OwnerVerificationData
    {
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("disbursement")]
        public Disbursement Disbursement { get; set; }

        [JsonPropertyName("asset-disbursement")]
        public AssetDisbursement AssetDisbursement { get; set; }

        [JsonPropertyName("funds-transfer")]
        public FundsTransfer FundsTransfer { get; set; }

        [JsonPropertyName("asset-transfer")]
        public AssetTransfer AssetTransfer { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<object> Included { get; set; }
    }
}
