using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class ApproveAmlChecksResponseModel
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

    public class AccountHistories
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
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AccountSubType
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
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetTransactions
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class AssetTransfer
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
        [JsonPropertyName("created-at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("exceptions")]
        public List<string> Exceptions { get; set; }

        [JsonPropertyName("exception-details")]
        public string ExceptionDetails { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("updated-at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("socure-reference-id")]
        public string SocureReferenceId { get; set; }

        [JsonPropertyName("manual-review-result")]
        public string ManualReviewResult { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("contributions-frozen")]
        public bool ContributionsFrozen { get; set; }

        [JsonPropertyName("disbursements-frozen")]
        public bool DisbursementsFrozen { get; set; }

        [JsonPropertyName("organization-label")]
        public string OrganizationLabel { get; set; }

        [JsonPropertyName("statements")]
        public bool Statements { get; set; }

        [JsonPropertyName("solid-freeze")]
        public bool SolidFreeze { get; set; }

        [JsonPropertyName("freeze-required-actions")]
        public string FreezeRequiredActions { get; set; }

        [JsonPropertyName("freeze-not-required-actions")]
        public string FreezeNotRequiredActions { get; set; }

        [JsonPropertyName("uploaded-document-ids")]
        public List<string> UploadedDocumentIds { get; set; }
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

    public class Contact
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

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class FundsTransfer
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
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

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class LatestAgreement
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("related")]
        public string Related { get; set; }

        [JsonPropertyName("self")]
        public string Self { get; set; }
    }

    public class Organization
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
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
        [JsonPropertyName("account")]
        public Account Account { get; set; }

        [JsonPropertyName("asset-transfer")]
        public AssetTransfer AssetTransfer { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("funds-transfer")]
        public FundsTransfer FundsTransfer { get; set; }

        [JsonPropertyName("account-asset-totals")]
        public AccountAssetTotals AccountAssetTotals { get; set; }

        [JsonPropertyName("account-cash-totals")]
        public AccountCashTotals AccountCashTotals { get; set; }

        [JsonPropertyName("account-transfer-authorizations")]
        public AccountTransferAuthorizations AccountTransferAuthorizations { get; set; }

        [JsonPropertyName("asset-transactions")]
        public AssetTransactions AssetTransactions { get; set; }

        [JsonPropertyName("asset-transfers")]
        public AssetTransfers AssetTransfers { get; set; }

        [JsonPropertyName("asset-transfer-methods")]
        public AssetTransferMethods AssetTransferMethods { get; set; }

        [JsonPropertyName("authorized-transfer-accounts")]
        public AuthorizedTransferAccounts AuthorizedTransferAccounts { get; set; }

        [JsonPropertyName("beneficiaries")]
        public Beneficiaries Beneficiaries { get; set; }

        [JsonPropertyName("cash-transactions")]
        public CashTransactions CashTransactions { get; set; }

        [JsonPropertyName("contact-funds-transfer-references")]
        public ContactFundsTransferReferences ContactFundsTransferReferences { get; set; }

        [JsonPropertyName("contacts")]
        public Contacts Contacts { get; set; }

        [JsonPropertyName("funds-transfers")]
        public FundsTransfers FundsTransfers { get; set; }

        [JsonPropertyName("grantors")]
        public Grantors Grantors { get; set; }

        [JsonPropertyName("owners")]
        public Owners Owners { get; set; }

        [JsonPropertyName("owners-and-grantors")]
        public OwnersAndGrantors OwnersAndGrantors { get; set; }

        [JsonPropertyName("account-histories")]
        public AccountHistories AccountHistories { get; set; }

        [JsonPropertyName("uploaded-documents")]
        public UploadedDocuments UploadedDocuments { get; set; }

        [JsonPropertyName("account-aggregate-policy")]
        public AccountAggregatePolicy AccountAggregatePolicy { get; set; }

        [JsonPropertyName("account-policy")]
        public AccountPolicy AccountPolicy { get; set; }

        [JsonPropertyName("account-questionnaire")]
        public AccountQuestionnaire AccountQuestionnaire { get; set; }

        [JsonPropertyName("account-type")]
        public AccountType AccountType { get; set; }

        [JsonPropertyName("account-sub-type")]
        public AccountSubType AccountSubType { get; set; }

        [JsonPropertyName("latest-agreement")]
        public LatestAgreement LatestAgreement { get; set; }

        [JsonPropertyName("organization")]
        public Organization Organization { get; set; }

        [JsonPropertyName("rule-group")]
        public RuleGroup RuleGroup { get; set; }

        [JsonPropertyName("webhook-config")]
        public WebhookConfig WebhookConfig { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("included")]
        public List<Included> Included { get; set; }
    }

    public class RuleGroup
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class UploadedDocuments
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class WebhookConfig
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
