using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class TrackAssetTransfersResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Asset
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetContribution
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

    public class AssetTransferMethod
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("cancelled-at")]
        public object CancelledAt { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("contingencies-cleared-on")]
        public object ContingenciesClearedOn { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("unit-count")]
        public int UnitCount { get; set; }

        [JsonPropertyName("unit-count-expected")]
        public int UnitCountExpected { get; set; }

        [JsonPropertyName("settlement-details")]
        public object SettlementDetails { get; set; }

        [JsonPropertyName("authorized-at")]
        public object AuthorizedAt { get; set; }

        [JsonPropertyName("last-owner-verification-request-at")]
        public DateTime LastOwnerVerificationRequestAt { get; set; }

        [JsonPropertyName("owner-verification-data")]
        public object OwnerVerificationData { get; set; }

        [JsonPropertyName("owner-verification-type")]
        public string OwnerVerificationType { get; set; }

        [JsonPropertyName("owner-verified-at")]
        public object OwnerVerifiedAt { get; set; }
    }

    public class Contact
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ContingentHolds
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

    public class Disbursement
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class DisbursementAuthorization
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class FundsTransfer
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Included
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

        [JsonPropertyName("first")]
        public string First { get; set; }

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

    public class Relationships
    {
        [JsonPropertyName("contingent-holds")]
        public ContingentHolds ContingentHolds { get; set; }

        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }

        [JsonPropertyName("asset-contribution")]
        public AssetContribution AssetContribution { get; set; }

        [JsonPropertyName("asset-disbursement")]
        public AssetDisbursement AssetDisbursement { get; set; }

        [JsonPropertyName("asset-transfer-method")]
        public AssetTransferMethod AssetTransferMethod { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("disbursement-authorization")]
        public DisbursementAuthorization DisbursementAuthorization { get; set; }

        [JsonPropertyName("settled-asset-transaction")]
        public SettledAssetTransaction SettledAssetTransaction { get; set; }

        [JsonPropertyName("disbursement")]
        public Disbursement Disbursement { get; set; }

        [JsonPropertyName("funds-transfer")]
        public FundsTransfer FundsTransfer { get; set; }

        [JsonPropertyName("asset-transfer")]
        public AssetTransfer AssetTransfer { get; set; }
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

    public class SettledAssetTransaction
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}
