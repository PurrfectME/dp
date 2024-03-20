using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class CreateEntityAccountResponseDto
{
    public class Account
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountAggregatePolicy
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountAssetTotals
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountCashTotals
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountPolicy
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountQuestionnaire
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Accounts
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountTransferAuthorizations
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountType
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class AssetTransactions
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetTransferMethods
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
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("disbursements-frozen")]
        public bool DisbursementsFrozen { get; set; }

        [JsonPropertyName("organization-label")]
        public string OrganizationLabel { get; set; }

        [JsonPropertyName("statements")]
        public bool Statements { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("account-id")]
        public string AccountId { get; set; }

        [JsonPropertyName("anticipated-monthly-cash-volume")]
        public string AnticipatedMonthlyCashVolume { get; set; }

        [JsonPropertyName("anticipated-monthly-transactions-incoming")]
        public string AnticipatedMonthlyTransactionsIncoming { get; set; }

        [JsonPropertyName("anticipated-monthly-transactions-outgoing")]
        public string AnticipatedMonthlyTransactionsOutgoing { get; set; }

        [JsonPropertyName("anticipated-trading-patterns")]
        public string AnticipatedTradingPatterns { get; set; }

        [JsonPropertyName("anticipated-types-of-assets")]
        public string AnticipatedTypesOfAssets { get; set; }

        [JsonPropertyName("associations-with-other-accounts")]
        public string AssociationsWithOtherAccounts { get; set; }

        [JsonPropertyName("intended-use-of-account")]
        public string IntendedUseOfAccount { get; set; }

        [JsonPropertyName("nature-of-business-of-the-company")]
        public string NatureOfBusinessOfTheCompany { get; set; }

        [JsonPropertyName("purpose-of-account")]
        public string PurposeOfAccount { get; set; }

        [JsonPropertyName("source-of-assets-and-income")]
        public string SourceOfAssetsAndIncome { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("manage-investments")]
        public bool? ManageInvestments { get; set; }

        [JsonPropertyName("owner-role")]
        public string OwnerRole { get; set; }

        [JsonPropertyName("statement-roles")]
        public List<string> StatementRoles { get; set; }

        [JsonPropertyName("tax-form-recipient-role")]
        public string TaxFormRecipientRole { get; set; }

        [JsonPropertyName("trust")]
        public bool? Trust { get; set; }

        [JsonPropertyName("contact-email")]
        public string ContactEmail { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("failures")]
        public int? Failures { get; set; }

        [JsonPropertyName("shared-secret")]
        public string SharedSecret { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class AuthorizedTransferAccounts
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Beneficiaries
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class CashTransactions
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class ContactFundsTransferReferences
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Contacts
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

    public class FundsTransfers
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Grantors
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

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class LatestAgreement
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class Organization
    {
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }

    public class Owners
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class OwnersAndGrantors
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("account-asset-totals")]
        public AccountAssetTotals AccountAssetTotals { get; set; }

        [JsonPropertyName("account-cash-totals")]
        public AccountCashTotals AccountCashTotals { get; set; }

        [JsonPropertyName("account-questionnaire")]
        public AccountQuestionnaire AccountQuestionnaire { get; set; }

        [JsonPropertyName("account-policy")]
        public AccountPolicy AccountPolicy { get; set; }

        [JsonPropertyName("account-aggregate-policy")]
        public AccountAggregatePolicy AccountAggregatePolicy { get; set; }

        [JsonPropertyName("account-transfer-authorizations")]
        public AccountTransferAuthorizations AccountTransferAuthorizations { get; set; }

        [JsonPropertyName("authorized-transfer-accounts")]
        public AuthorizedTransferAccounts AuthorizedTransferAccounts { get; set; }

        [JsonPropertyName("asset-transactions")]
        public AssetTransactions AssetTransactions { get; set; }

        [JsonPropertyName("asset-transfers")]
        public AssetTransfers AssetTransfers { get; set; }

        [JsonPropertyName("asset-transfer-methods")]
        public AssetTransferMethods AssetTransferMethods { get; set; }

        [JsonPropertyName("cash-transactions")]
        public CashTransactions CashTransactions { get; set; }

        [JsonPropertyName("contact-funds-transfer-references")]
        public ContactFundsTransferReferences ContactFundsTransferReferences { get; set; }

        [JsonPropertyName("contacts")]
        public Contacts Contacts { get; set; }

        [JsonPropertyName("latest-agreement")]
        public LatestAgreement LatestAgreement { get; set; }

        [JsonPropertyName("owners")]
        public Owners Owners { get; set; }

        [JsonPropertyName("beneficiaries")]
        public Beneficiaries Beneficiaries { get; set; }

        [JsonPropertyName("grantors")]
        public Grantors Grantors { get; set; }

        [JsonPropertyName("owners-and-grantors")]
        public OwnersAndGrantors OwnersAndGrantors { get; set; }

        [JsonPropertyName("funds-transfers")]
        public FundsTransfers FundsTransfers { get; set; }

        [JsonPropertyName("organization")]
        public Organization Organization { get; set; }

        [JsonPropertyName("uploaded-documents")]
        public UploadedDocuments UploadedDocuments { get; set; }

        [JsonPropertyName("account-type")]
        public AccountType AccountType { get; set; }

        [JsonPropertyName("webhook-config")]
        public WebhookConfig WebhookConfig { get; set; }

        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("accounts")]
        public Accounts Accounts { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<Included> Included { get; set; }
    }

    public class UploadedDocuments
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class WebhookConfig
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}
