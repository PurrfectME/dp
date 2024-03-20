using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class GetAccountInternalAssetTransfersResponseDto
{
    public class Asset
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("preserve-tax-lots")]
        public bool PreserveTaxLots { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("unit-count")]
        public string UnitCount { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("asset-transfer-types")]
        public List<string> AssetTransferTypes { get; set; }

        [JsonPropertyName("asset-type")]
        public string AssetType { get; set; }

        [JsonPropertyName("blockchain-id")]
        public string BlockchainId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("fireblocks-asset-id")]
        public string FireblocksAssetId { get; set; }

        [JsonPropertyName("globally-available")]
        public bool GloballyAvailable { get; set; }

        [JsonPropertyName("innotrust-id")]
        public string InnotrustId { get; set; }

        [JsonPropertyName("internal")]
        public bool Internal { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("max-decimal-precision")]
        public string MaxDecimalPrecision { get; set; }

        [JsonPropertyName("minimum-disbursement-unit-count")]
        public string MinimumDisbursementUnitCount { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("requires-manual-deposit")]
        public bool RequiresManualDeposit { get; set; }

        [JsonPropertyName("requires-tag")]
        public bool RequiresTag { get; set; }

        [JsonPropertyName("single-unit")]
        public bool SingleUnit { get; set; }

        [JsonPropertyName("sub-type")]
        public string SubType { get; set; }

        [JsonPropertyName("support-fireblocks-incoming-address")]
        public bool SupportFireblocksIncomingAddress { get; set; }

        [JsonPropertyName("transferable")]
        public bool Transferable { get; set; }

        [JsonPropertyName("unit-name")]
        public string UnitName { get; set; }

        [JsonPropertyName("withdrawal-fee")]
        public string WithdrawalFee { get; set; }
    }

    public class Datum
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

    public class FromAccount
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class FromAssetTransaction
    {
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

    public class Relationships
    {
        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }

        [JsonPropertyName("from-account")]
        public FromAccount FromAccount { get; set; }

        [JsonPropertyName("from-asset-transaction")]
        public FromAssetTransaction FromAssetTransaction { get; set; }

        [JsonPropertyName("to-account")]
        public ToAccount ToAccount { get; set; }

        [JsonPropertyName("to-asset-transaction")]
        public ToAssetTransaction ToAssetTransaction { get; set; }

        [JsonPropertyName("token-asset")]
        public TokenAsset TokenAsset { get; set; }

        [JsonPropertyName("security")]
        public Security Security { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }

        [JsonPropertyName("included")]
        public List<Included> Included { get; set; }
    }

    public class Security
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ToAccount
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ToAssetTransaction
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class TokenAsset
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
