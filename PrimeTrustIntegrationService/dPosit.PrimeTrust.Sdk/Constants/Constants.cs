namespace dPosit.PrimeTrust.Sdk.Settings;

public sealed class Constants
{
    public class Accounts
    {
        public const string CREATE_INDIVIDUAL_ACCOUNT = "v2/accounts?include=latest-agreement,account-type,webhook-config";
        public const string POST_AGREEMENT_PREVIEW = "v2/agreement-previews";
        public const string CREATE_ENTITY_ACCOUNT = "v2/accounts?include=account-questionnaire,account-type,webhook-config";
        public const string OPEN_ACCOUNT_URL = "v2/accounts/{0}/sandbox/open";
        public const string GET_ACCOUNT_CASH_TRANSFERS = "/v2/accounts/{0}/account-cash-transfers";
        public const string GET_ACCOUNT_AUTHORIZED_ACCOUNTS = "/v2/accounts/{0}/authorized-transfer-accounts";
        public const string GET_ACCOUNT_INTERNAL_ASSET_TRANSFERS = "/v2/accounts/{0}/internal-asset-transfers";
    }

    public class Funds
    {
        public const string ADD_FUNDS = "v2/accounts/{0}/sandbox/fund";
        public const string CREATE_CONTACT_REFERENCE = "v2/contact-funds-transfer-references";
        public const string CREATE_FUNDS_TRANSFER_METHOD = "v2/funds-transfer-methods";
        public const string CREATE_BANK_FUNDS_TRANSFER_METHOD = "v2/funds-transfer-methods?include=bank";
        public const string MAKE_CONTRIBUTION = "v2/contributions?include=funds-transfer";
        public const string TRACK_DEPOSIT = "v2/funds-transfers/{0}/sandbox/settle";
        public const string CONTINGENT_HOLDS = "v2/contingent-holds/{0}/sandbox/clear";
        public const string TRANSFER_FUNDS = "v2/account-cash-transfers?include=from-account-cash-totals,to-account-cash-totals";
        public const string MAKE_WITHDRAWAL = "v2/disbursements?include=funds-transfer,disbursement-authorization";
        public const string DISBURSEMENT_AUTHORIZATIONS = "v2/disbursement-authorizations/{0}/sandbox/verify-owner";
    }

    public class Assets
    {
        public const string ASSET_TRANSFER_METHODS = "v2/asset-transfer-methods";
        public const string ASSET_CONTRIBUTION = "v2/asset-contributions?include=asset-transfer-method,asset-transfer";
        public const string INTERNAL_ASSET_TRANSFERS = "v2/internal-asset-transfers";
        public const string WITHDRAW_ASSETS = "v2/asset-disbursements?include=asset-transfer-method,asset-transfer";
        public const string GET_ASSET_TRANSFERS = "v2/asset-transfers?include=disbursement-authorizations";
        public const string DISBURSEMENT_AUTHORIZATIONS = "v2/disbursement-authorizations/{0}/sandbox/verify-owner";
        public const string SETTLE_ASSET_TRANSFERS = "v2/asset-transfers/{0}/sandbox/settle";
    }

    public class Users
    {
        public const string CREATE_USER = "v2/users";
        public const string GET_USERS = "v2/users";
        public const string GET_USER_BY_ID = "v2/users/{0}";
        public const string PATCH_USER = "v2/users/{0}";
        public const string GET_CURRENT_USER = "/v2/users/current";
        public const string PATCH_CURRENT_USER = "/v2/users/current";
        public const string INVALIDATE_JWTS = "/v2/users/current/jwts/invalidate";
    }

    public class CipChecks
    {
        public const string GET_CIP_CHECKS = "/v2/cip-checks";
        public const string GET_CIP_CHECKS_BY_ID = "/v2/cip-checks/{0}";
        public const string SUBMIT_CIP_CHECK_FOR_REVIEW = "/v2/cip-checks/{0}/submit-for-review";
        public const string APPROVE_CIP_CHECK = "/v2/cip-checks/{0}/sandbox/approve";
        public const string DENY_CIP_CHECK = "/v2/cip-checks/{0}/sandbox/deny";
    }

    public class AmlChecks
    {
        public const string GET_AML_CHECKS_BY_ID = "/v2/aml-checks/{0}";
        public const string GET_AML_CHECKS = "/v2/aml-checks";
        public const string APPROVE_AML_CHECKS = "/v2/aml-checks/{0}/sandbox/approve";
        public const string DENY_AML_CHECKS = "/v2/aml-checks/{0}/sandbox/deny";

    }
}
