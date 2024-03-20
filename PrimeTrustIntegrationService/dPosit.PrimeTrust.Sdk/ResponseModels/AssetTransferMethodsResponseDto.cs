﻿using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class AssetTransferMethodsResponseDto
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

    public class AssetTransfers
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("acquisition-on")]
        public string AcquisitionOn { get; set; }

        [JsonPropertyName("asset-transfer-type")]
        public string AssetTransferType { get; set; }

        [JsonPropertyName("cost-basis")]
        public double CostBasis { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("currency-type")]
        public string CurrencyType { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("inactive")]
        public bool Inactive { get; set; }

        [JsonPropertyName("single-use")]
        public bool SingleUse { get; set; }

        [JsonPropertyName("transfer-direction")]
        public string TransferDirection { get; set; }

        [JsonPropertyName("wallet-address")]
        public string WalletAddress { get; set; }
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

        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }

        [JsonPropertyName("asset-transfers")]
        public AssetTransfers AssetTransfers { get; set; }

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
