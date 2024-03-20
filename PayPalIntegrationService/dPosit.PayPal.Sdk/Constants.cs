namespace dPosit.PayPal.Sdk;

public sealed class Constants
{
    internal sealed class Routes
    {
        public sealed class Authorization
        {
            public const string GENERATE_ACCESS_TOKEN = "v1/oauth2/token";
            public const string TERMINATE_ACCESS_TOKEN = "/v1/oauth2/token/terminate";

            public const string GENERATE_CLIENT_TOKEN = "/v1/identity/generate-token";
            public const string USER_INFO = "v1/identity/oauth2/userinfo";
        }

        public sealed class Orders
        {
            public const string CREATE_ORDER = "/v2/checkout/orders";
            public const string UPDATE_ORDER = "/v2/checkout/orders/{0}";
            public const string SHOW_ORDER_DETAILS = "/v2/checkout/orders/{0}";
            public const string AUTHORIZE_PAYMENT_FOR_ORDER = "/v2/checkout/orders/{0}/authorize";
            public const string CAPTURE_PAYMENT_FOR_ORDER = "/v2/checkout/orders/{0}/capture";
            public const string CONFIRM_ORDER = "/v2/checkout/orders/{0}/confirm-payment-source";
        }

        public sealed class Payments
        {
            public const string SHOW_DETAILS_FOR_AUTHORIZED_PAYMENT = "/v2/payments/authorizations/{0}";
            public const string CAPTURE_AUTHORIZED_PAYMENT = "/v2/payments/authorizations/{0}/capture";
            public const string REAUTHORIZE_AUTHORIZED_PAYMENT = "/v2/payments/authorizations/{0}/reauthorize";
            public const string VOID_AUTHORIZED_PAYMENT = "/v2/payments/authorizations/{0}/void";
            public const string SHOW_CAPTURED_PAYMENT_DETAILS = "/v2/payments/captures/{0}";
            public const string REFUND_CAPTURED_PAYMENT = "/v2/payments/captures/{0}/refund";
            public const string SHOW_REFUND_DETAILS = "/v2/payments/refunds/{0}";
        }

        public sealed class TransactionSearch
        {
            public const string LIST_TRANSACTIONS = "/v1/reporting/transactions";
            public const string LIST_ALL_BALANCES = "/v1/reporting/balances";
        }
    }

    internal sealed class Origin
    {
        public const string SANDBOX = "https://api-m.sandbox.paypal.com/";
        public const string PRODUCTION = "https://api-m.paypal.com/";
    }

    internal static readonly Dictionary<Models.GrantType, string> GrandTypeMap = new()
    {
        { Models.GrantType.None, null },
        { Models.GrantType.ClientCredentials, GrantType.CLIENT_CREDENTIALS },
        { Models.GrantType.RefreshToken, GrantType.REFRESH_TOKEN },
        { Models.GrantType.AuthorizationCode, GrantType.AUTHORIZATION_CODE }
    };

    internal sealed class GrantType
    {
        public const string CLIENT_CREDENTIALS = "client_credentials";
        public const string REFRESH_TOKEN = "refresh_token";
        public const string AUTHORIZATION_CODE = "authorization_code";
    }

    internal static readonly Dictionary<Models.TokenTypeHint, string> TokenTypeHintMap = new()
    {
        { Models.TokenTypeHint.None, null },
        { Models.TokenTypeHint.AccessToken, TokenTypeHint.ACCESS_TOKEN },
        { Models.TokenTypeHint.RefreshToken, TokenTypeHint.REFRESH_TOKEN }
    };

    internal sealed class TokenTypeHint
    {
        public const string ACCESS_TOKEN = "ACCESS_TOKEN";
        public const string REFRESH_TOKEN = "REFRESH_TOKEN";
    }

    internal static readonly Dictionary<Models.Intent, string> IntentMap = new()
    {
        { Models.Intent.None, null },
        { Models.Intent.Capture, Intent.CAPTURE },
        { Models.Intent.Authorize, Intent.AUTHORIZE }
    };

    internal sealed class Intent
    {
        public const string CAPTURE = "CAPTURE";
        public const string AUTHORIZE = "AUTHORIZE";
    }

    internal static readonly Dictionary<Models.OrderStatus, string> OrderStatusMap = new()
    {
        { Models.OrderStatus.None, null },
        { Models.OrderStatus.Created, OrderStatus.CREATED },
        { Models.OrderStatus.Saved, OrderStatus.SAVED },
        { Models.OrderStatus.Approved, OrderStatus.APPROVED },
        { Models.OrderStatus.Voided, OrderStatus.VOIDED },
        { Models.OrderStatus.Completed, OrderStatus.COMPLETED },
        { Models.OrderStatus.PayerActionRequired, OrderStatus.PAYER_ACTION_REQUIRED }
    };

    internal sealed class OrderStatus
    {
        public const string CREATED = "CREATED";
        public const string SAVED = "SAVED";
        public const string APPROVED = "APPROVED";
        public const string VOIDED = "VOIDED";
        public const string COMPLETED = "COMPLETED";
        public const string PAYER_ACTION_REQUIRED = "PAYER_ACTION_REQUIRED";
    }

    internal static readonly Dictionary<Models.ResponseType, string> ResponseTypeMap = new()
    {
        { Models.ResponseType.None, null },
        { Models.ResponseType.Token, ResponseType.TOKEN },
        { Models.ResponseType.Uat, ResponseType.UAT }
    };

    internal sealed class ResponseType
    {
        public const string TOKEN = "token";
        public const string UAT = "uat";
    }

    internal static readonly Dictionary<Models.TokenizationMethod, string> TokenizationMethodMap = new()
    {
        { Models.TokenizationMethod.None, null },
        { Models.TokenizationMethod.BillingAgreement, TokenizationMethod.BILLING_AGREEMENT },
    };

    internal sealed class TokenizationMethod
    {
        public const string BILLING_AGREEMENT = "BILLING_AGREEMENT";
    }

    internal static readonly Dictionary<Models.ShippingType, string> ShippingTypeMap = new()
    {
        { Models.ShippingType.None, null },
        { Models.ShippingType.Shipping, ShippingType.SHIPPING },
        { Models.ShippingType.Pickup, ShippingType.PICKUP_IN_PERSON }
    };

    internal sealed class ShippingType
    {
        public const string SHIPPING = "SHIPPING";
        public const string PICKUP_IN_PERSON = "PICKUP_IN_PERSON";
    }

    internal static readonly Dictionary<Models.SecCode, string> SecCodeMap = new()
    {
        { Models.SecCode.None, null },
        { Models.SecCode.Tel, SecCode.TEL },
        { Models.SecCode.Web, SecCode.WEB },
        { Models.SecCode.Ccd, SecCode.CCD },
        { Models.SecCode.Ppd, SecCode.PPD }
    };

    internal sealed class SecCode
    {
        public const string TEL = "TEL";
        public const string WEB = "WEB";
        public const string CCD = "CCD";
        public const string PPD = "PPD";
    }

    internal static readonly Dictionary<Models.ProcessingInstruction, string> ProcessingInstructionMap = new()
    {
        { Models.ProcessingInstruction.None, null },
        { Models.ProcessingInstruction.OrderCompleteOnPaymentApproval, ProcessingInstruction.ORDER_COMPLETE_ON_PAYMENT_APPROVAL },
        { Models.ProcessingInstruction.NoInstruction, ProcessingInstruction.NO_INSTRUCTION }
    };

    internal sealed class ProcessingInstruction
    {
        public const string ORDER_COMPLETE_ON_PAYMENT_APPROVAL = "ORDER_COMPLETE_ON_PAYMENT_APPROVAL";
        public const string NO_INSTRUCTION = "NO_INSTRUCTION";
    }

    internal static readonly Dictionary<Models.PatchOperation, string> PatchOperationMap = new()
    {
        { Models.PatchOperation.None, null },
        { Models.PatchOperation.Add, PatchOperation.ADD },
        { Models.PatchOperation.Remove, PatchOperation.REMOVE },
        { Models.PatchOperation.Replace, PatchOperation.REPLACE },
        { Models.PatchOperation.Move, PatchOperation.MOVE },
        { Models.PatchOperation.Copy, PatchOperation.COPY },
        { Models.PatchOperation.Test, PatchOperation.TEST }
    };

    internal sealed class PatchOperation
    {
        public const string ADD = "add";
        public const string REMOVE = "remove";
        public const string REPLACE = "replace";
        public const string MOVE = "move";
        public const string COPY = "copy";
        public const string TEST = "test";
    }

    internal static readonly Dictionary<Models.PaymentInstrumentType, string> PaymentInstrumentTypeMap = new()
    {
        { Models.PaymentInstrumentType.None, null },
        { Models.PaymentInstrumentType.CreditCard, PaymentInstrumentType.CREDITCARD },
        { Models.PaymentInstrumentType.DebitCard, PaymentInstrumentType.DEBITCARD }
    };

    internal sealed class PaymentInstrumentType
    {
        public const string CREDITCARD = "CREDITCARD";
        public const string DEBITCARD = "DEBITCARD";
    }

    internal static readonly Dictionary<Models.PaymentMethod, string> PaymentMethodMap = new()
    {
        { Models.PaymentMethod.None, null },
        { Models.PaymentMethod.Unrestricted, PaymentMethod.UNRESTRICTED },
        { Models.PaymentMethod.ImmediatePaymentRequired, PaymentMethod.IMMEDIATE_PAYMENT_REQUIRED }
    };

    internal sealed class PaymentMethod
    {
        public const string UNRESTRICTED = "UNRESTRICTED";
        public const string IMMEDIATE_PAYMENT_REQUIRED = "IMMEDIATE_PAYMENT_REQUIRED";
    }

    internal static readonly Dictionary<Models.RefundStatus, string> RefundStatusMap = new()
    {
        { Models.RefundStatus.None, null },
        { Models.RefundStatus.Cancelled, RefundStatus.CANCELLED },
        { Models.RefundStatus.Pending, RefundStatus.PENDING },
        { Models.RefundStatus.Completed, RefundStatus.COMPLETED }
    };

    internal sealed class RefundStatus
    {
        public const string CANCELLED = "CANCELLED";
        public const string PENDING = "PENDING";
        public const string COMPLETED = "COMPLETED";
    }

    internal static readonly Dictionary<Models.PaymentMethodType, string> PaymentMethodTypeMap = new()
    {
        { Models.PaymentMethodType.None, null },
        { Models.PaymentMethodType.Pui, PaymentMethodType.PUI },
        { Models.PaymentMethodType.Installment, PaymentMethodType.INSTALLMENT },
        { Models.PaymentMethodType.mEFT, PaymentMethodType.mEFT }
    };

    internal sealed class PaymentMethodType
    {
        public const string PUI = "PUI";
        public const string INSTALLMENT = "installment";
        public const string mEFT = "mEFT";
    }

    internal static readonly Dictionary<Models.TransactionStatus, string> TransactionStatusMap = new()
    {
        { Models.TransactionStatus.None, null },
        { Models.TransactionStatus.D, TransactionStatus.D },
        { Models.TransactionStatus.P, TransactionStatus.P },
        { Models.TransactionStatus.S, TransactionStatus.S },
        { Models.TransactionStatus.V, TransactionStatus.V }
    };

    internal sealed class TransactionStatus
    {
        public const string D = "D";
        public const string P = "P";
        public const string S = "S";
        public const string V = "V";
    }

    internal static readonly Dictionary<Models.TransactionField, string> TransactionFieldMap = new()
    {
        { Models.TransactionField.None, null },
        { Models.TransactionField.TransactionInfo, TransactionField.TRANSACTION_INFO },
        { Models.TransactionField.PayerInfo, TransactionField.PAYER_INFO },
        { Models.TransactionField.ShippingInfo, TransactionField.SHIPPING_INFO },
        { Models.TransactionField.AuctionInfo, TransactionField.AUCTION_INFO },
        { Models.TransactionField.CartInfo, TransactionField.CART_INFO },
        { Models.TransactionField.IncentiveInfo, TransactionField.INCENTIVE_INFO },
        { Models.TransactionField.StoreInfo, TransactionField.STORE_INFO },
        { Models.TransactionField.All, TransactionField.ALL }
    };

    internal sealed class TransactionField
    {
        public const string TRANSACTION_INFO = "transaction_info";
        public const string PAYER_INFO = "payer_info";
        public const string SHIPPING_INFO = "shipping_info";
        public const string AUCTION_INFO = "auction_info";
        public const string CART_INFO = "cart_info";
        public const string INCENTIVE_INFO = "incentive_info";
        public const string STORE_INFO = "store_info";
        public const string ALL = "all";
    }

    internal static readonly Dictionary<Models.BalanceAffectingRecordsOnly, string> BalanceAffectingRecordsOnlyMap = new()
    {
        { Models.BalanceAffectingRecordsOnly.None, null },
        { Models.BalanceAffectingRecordsOnly.Yes, BalanceAffectingRecordsOnly.YES },
        { Models.BalanceAffectingRecordsOnly.No, BalanceAffectingRecordsOnly.NO },
    };

    internal sealed class BalanceAffectingRecordsOnly
    {
        public const string YES = "Y";
        public const string NO = "N";
    }

    internal static readonly Dictionary<Models.PaypalReferenceIdType, string> PaypalReferenceIdTypeMap = new()
    {
        { Models.PaypalReferenceIdType.None, null },
        { Models.PaypalReferenceIdType.Odr, PaypalReferenceIdType.ODR },
        { Models.PaypalReferenceIdType.Txn, PaypalReferenceIdType.TXN },
        { Models.PaypalReferenceIdType.Sub, PaypalReferenceIdType.SUB },
        { Models.PaypalReferenceIdType.Pap, PaypalReferenceIdType.PAP }
    };

    internal sealed class PaypalReferenceIdType
    {
        public const string ODR = "ODR";
        public const string TXN = "TXN";
        public const string SUB = "SUB";
        public const string PAP = "PAP";
    }

    internal static readonly Dictionary<Models.ProtectionEligibility, string> ProtectionEligibilityMap = new()
    {
        { Models.ProtectionEligibility.None, null },
        { Models.ProtectionEligibility.Eligible, ProtectionEligibility.ELIGIBLE },
        { Models.ProtectionEligibility.NotEligible, ProtectionEligibility.NOT_ELIGIBLE },
        { Models.ProtectionEligibility.PartiallyEligible, ProtectionEligibility.PARTIALLY_ELIGIBLE }
    };

    internal sealed class ProtectionEligibility
    {
        public const string ELIGIBLE = "01";
        public const string NOT_ELIGIBLE = "02";
        public const string PARTIALLY_ELIGIBLE = "03";
    }

    internal static readonly Dictionary<Models.PayerStatus, string> PayerStatusMap = new()
    {
        { Models.PayerStatus.None, null },
        { Models.PayerStatus.Verified, PayerStatus.VERIFIED },
        { Models.PayerStatus.NotVerified, PayerStatus.NOT_VERIFIED }
    };

    internal sealed class PayerStatus
    {
        public const string VERIFIED = "Y";
        public const string NOT_VERIFIED = "N";
    }

    internal static readonly Dictionary<Models.TokenType, string> TokenTypeMap = new()
    {
        { Models.TokenType.None, null },
        { Models.TokenType.Bearer, TokenType.BEARER }
    };

    internal sealed class TokenType
    {
        public const string BEARER = "Bearer";
    }

    internal static readonly Dictionary<Models.AuthenticationScheme, string> AuthenticationSchemeMap = new()
    {
        { Models.AuthenticationScheme.None, null },
        { Models.AuthenticationScheme.EmailPassword, AuthenticationScheme.EMAIL_PASSWORD },
        { Models.AuthenticationScheme.RememberMe, AuthenticationScheme.REMEMBER_ME }
    };

    internal sealed class AuthenticationScheme
    {
        public const string EMAIL_PASSWORD = "email_password";
        public const string REMEMBER_ME = "remember_me";
    }

    internal static readonly Dictionary<Models.ItemCategory, string> ItemCategoryMap = new()
    {
        { Models.ItemCategory.None, null },
        { Models.ItemCategory.DigitalGoods, ItemCategory.DIGITAL_GOODS },
        { Models.ItemCategory.PhysicalGoods, ItemCategory.PHYSICAL_GOODS },
        { Models.ItemCategory.Donation, ItemCategory.DONATION }
    };

    internal sealed class ItemCategory
    {
        public const string DIGITAL_GOODS = "DIGITAL_GOODS";
        public const string PHYSICAL_GOODS = "PHYSICAL_GOODS";
        public const string DONATION = "DONATION";
    }

    internal static readonly Dictionary<Models.DisbursementMode, string> DisbursementModeMap = new()
    {
        { Models.DisbursementMode.None, null },
        { Models.DisbursementMode.Instant, DisbursementMode.INSTANT },
        { Models.DisbursementMode.Delayed, DisbursementMode.DELAYED }
    };

    internal sealed class DisbursementMode
    {
        public const string INSTANT = "INSTANT";
        public const string DELAYED = "DELAYED";
    }

    internal static readonly Dictionary<Models.UserCheckoutAction, string> UserCheckoutActionMap = new()
    {
        { Models.UserCheckoutAction.None, null },
        { Models.UserCheckoutAction.PayNow, UserCheckoutAction.PAY_NOW },
        { Models.UserCheckoutAction.Continue, UserCheckoutAction.CONTINUE }
    };

    internal sealed class UserCheckoutAction
    {
        public const string PAY_NOW = "PAY_NOW";
        public const string CONTINUE = "CONTINUE";
    }

    internal static readonly Dictionary<Models.HttpMethod, string> HttpMethodMap = new()
    {
        { Models.HttpMethod.None, null },
        { Models.HttpMethod.Get, HttpMethod.GET },
        { Models.HttpMethod.Post, HttpMethod.POST },
        { Models.HttpMethod.Put, HttpMethod.PUT },
        { Models.HttpMethod.Delete, HttpMethod.DELETE },
        { Models.HttpMethod.Head, HttpMethod.HEAD },
        { Models.HttpMethod.Connect, HttpMethod.CONNECT },
        { Models.HttpMethod.Options, HttpMethod.OPTIONS },
        { Models.HttpMethod.Patch, HttpMethod.PATCH }
    };

    internal sealed class HttpMethod
    {
        public const string GET = "GET";
        public const string POST = "POST";
        public const string PUT = "PUT";
        public const string DELETE = "DELETE";
        public const string HEAD = "HEAD";
        public const string CONNECT = "CONNECT";
        public const string OPTIONS = "OPTIONS";
        public const string PATCH = "PATCH";
    }

    internal static readonly Dictionary<Models.CardBrand, string> CardBrandMap = new()
    {
        { Models.CardBrand.None, null },
        { Models.CardBrand.Visa, CardBrand.VISA },
        { Models.CardBrand.Mastercard, CardBrand.MASTERCARD },
        { Models.CardBrand.Discover, CardBrand.DISCOVER },
        { Models.CardBrand.AmericanExpress, CardBrand.AMERICAN_EXPRESS },
        { Models.CardBrand.Solo, CardBrand.SOLO },
        { Models.CardBrand.JapanCreditBureau, CardBrand.JAPAN_CREDIT_BUREAU },
        { Models.CardBrand.MilitaryStar, CardBrand.MILITARY_STAR },
        { Models.CardBrand.DeltaAirlines, CardBrand.DELTA_AIRLINES },
        { Models.CardBrand.Switch, CardBrand.SWITCH },
        { Models.CardBrand.Maestro, CardBrand.MAESTRO },
        { Models.CardBrand.CarteBancaireNationale, CardBrand.CARTE_BANCAIRE_NATIONALE },
        { Models.CardBrand.Configoga, CardBrand.CONFIGOGA },
        { Models.CardBrand.Confidis, CardBrand.CONFIDIS },
        { Models.CardBrand.Electron, CardBrand.ELECTRON },
        { Models.CardBrand.Cetelem, CardBrand.CETELEM },
        { Models.CardBrand.ChinaUnionPay, CardBrand.CHINA_UNION_PAY }
    };

    internal sealed class CardBrand
    {
        public const string VISA = "VISA";
        public const string MASTERCARD = "MASTERCARD";
        public const string DISCOVER = "DISCOVER";
        public const string AMERICAN_EXPRESS = "AMEX";
        public const string SOLO = "SOLO";
        public const string JAPAN_CREDIT_BUREAU = "JCB";
        public const string MILITARY_STAR = "STAR";
        public const string DELTA_AIRLINES = "DELTA";
        public const string SWITCH = "SWITCH";
        public const string MAESTRO = "MAESTRO";
        public const string CARTE_BANCAIRE_NATIONALE = "CB_NATIONALE";
        public const string CONFIGOGA = "CONFIGOGA";
        public const string CONFIDIS = "CONFIDIS";
        public const string ELECTRON = "ELECTRON";
        public const string CETELEM = "CETELEM";
        public const string CHINA_UNION_PAY = "CHINA_UNION_PAY";
    }

    internal static readonly Dictionary<Models.PaymentCardType, string> PaymentCardTypeMap = new()
    {
        { Models.PaymentCardType.None, null },
        { Models.PaymentCardType.Credit, PaymentCardType.CREDIT },
        { Models.PaymentCardType.Debit, PaymentCardType.DEBIT },
        { Models.PaymentCardType.Prepaid, PaymentCardType.PREPAID },
        { Models.PaymentCardType.Unknown, PaymentCardType.UNKNOWN }
    };

    internal sealed class PaymentCardType
    {
        public const string CREDIT = "CREDIT";
        public const string DEBIT = "DEBIT";
        public const string PREPAID = "PREPAID";
        public const string UNKNOWN = "UNKNOWN";
    }

    internal static readonly Dictionary<Models.ThreeDSecureAuthenticationStatus, string> ThreeDSecureAuthenticationStatusMap = new()
    {
        { Models.ThreeDSecureAuthenticationStatus.None, null },
        { Models.ThreeDSecureAuthenticationStatus.Successful, ThreeDSecureAuthenticationStatus.SUCCESSFUL },
        { Models.ThreeDSecureAuthenticationStatus.Failed, ThreeDSecureAuthenticationStatus.FAILED },
        { Models.ThreeDSecureAuthenticationStatus.UnableToComplete, ThreeDSecureAuthenticationStatus.UNABLE_TO_COMPLETE },
        { Models.ThreeDSecureAuthenticationStatus.AttemptsTransaction, ThreeDSecureAuthenticationStatus.ATTEMPTS_TRANSACTION },
        { Models.ThreeDSecureAuthenticationStatus.ChallengeRequired, ThreeDSecureAuthenticationStatus.CHALLENGE_REQUIRED },
        { Models.ThreeDSecureAuthenticationStatus.Rejected, ThreeDSecureAuthenticationStatus.REJECTED },
        { Models.ThreeDSecureAuthenticationStatus.DecoupledConfirmed, ThreeDSecureAuthenticationStatus.DECOUPLED_CONFIRMED },
        { Models.ThreeDSecureAuthenticationStatus.InformationalOnly, ThreeDSecureAuthenticationStatus.INFORMATIONAL_ONLY }
    };

    internal sealed class ThreeDSecureAuthenticationStatus
    {
        public const string SUCCESSFUL = "Y";
        public const string FAILED = "N";
        public const string UNABLE_TO_COMPLETE = "U";
        public const string ATTEMPTS_TRANSACTION = "A";
        public const string CHALLENGE_REQUIRED = "C";
        public const string REJECTED = "R";
        public const string DECOUPLED_CONFIRMED = "D";
        public const string INFORMATIONAL_ONLY = "I";
    }

    internal static readonly Dictionary<Models.ThreeDSecureAuthenticationEligibilityStatus, string> ThreeDSecureAuthenticationEligibilityStatusMap = new()
    {
        { Models.ThreeDSecureAuthenticationEligibilityStatus.None, null },
        { Models.ThreeDSecureAuthenticationEligibilityStatus.Yes, ThreeDSecureAuthenticationEligibilityStatus.YES },
        { Models.ThreeDSecureAuthenticationEligibilityStatus.No, ThreeDSecureAuthenticationEligibilityStatus.NO },
        { Models.ThreeDSecureAuthenticationEligibilityStatus.Unavailable, ThreeDSecureAuthenticationEligibilityStatus.UNAVAILABLE },
        { Models.ThreeDSecureAuthenticationEligibilityStatus.Bypass, ThreeDSecureAuthenticationEligibilityStatus.BYPASS }
    };

    internal sealed class ThreeDSecureAuthenticationEligibilityStatus
    {
        public const string YES = "Y";
        public const string NO = "N";
        public const string UNAVAILABLE = "U";
        public const string BYPASS = "B";
    }

    internal static readonly Dictionary<Models.LiabilityShift, string> LiabilityShiftMap = new()
    {
        { Models.LiabilityShift.None, null },
        { Models.LiabilityShift.Yes, LiabilityShift.YES },
        { Models.LiabilityShift.No, LiabilityShift.NO },
        { Models.LiabilityShift.Possible, LiabilityShift.POSSIBLE },
        { Models.LiabilityShift.Unknown, LiabilityShift.UNKNOWN }
    };

    internal sealed class LiabilityShift
    {
        public const string YES = "YES";
        public const string NO = "NO";
        public const string POSSIBLE = "POSSIBLE";
        public const string UNKNOWN = "UNKNOWN";
    }

    internal static readonly Dictionary<Models.AvsCode, string> AvsCodeMap = new()
    {
        { Models.AvsCode.None, null },
        { Models.AvsCode.A, AvsCode.A },
        { Models.AvsCode.B, AvsCode.B },
        { Models.AvsCode.C, AvsCode.C },
        { Models.AvsCode.D, AvsCode.D },
        { Models.AvsCode.E, AvsCode.E },
        { Models.AvsCode.F, AvsCode.F },
        { Models.AvsCode.G, AvsCode.G },
        { Models.AvsCode.I, AvsCode.I },
        { Models.AvsCode.M, AvsCode.M },
        { Models.AvsCode.N, AvsCode.N },
        { Models.AvsCode.P, AvsCode.P },
        { Models.AvsCode.R, AvsCode.R },
        { Models.AvsCode.S, AvsCode.S },
        { Models.AvsCode.U, AvsCode.U },
        { Models.AvsCode.W, AvsCode.W },
        { Models.AvsCode.X, AvsCode.X },
        { Models.AvsCode.Y, AvsCode.Y },
        { Models.AvsCode.Z, AvsCode.Z },
        { Models.AvsCode.Null, AvsCode.NULL },
        { Models.AvsCode.Zero, AvsCode.ZERO },
        { Models.AvsCode.One, AvsCode.ONE },
        { Models.AvsCode.Two, AvsCode.TWO },
        { Models.AvsCode.Three, AvsCode.THREE },
        { Models.AvsCode.Four, AvsCode.FOUR }
    };

    internal sealed class AvsCode
    {
        public const string A = "A";
        public const string B = "B";
        public const string C = "C";
        public const string D = "D";
        public const string E = "E";
        public const string F = "F";
        public const string G = "G";
        public const string I = "I";
        public const string M = "M";
        public const string N = "N";
        public const string P = "P";
        public const string R = "R";
        public const string S = "S";
        public const string U = "U";
        public const string W = "W";
        public const string X = "X";
        public const string Y = "Y";
        public const string Z = "Z";
        public const string NULL = "Null";
        public const string ZERO = "0";
        public const string ONE = "1";
        public const string TWO = "2";
        public const string THREE = "3";
        public const string FOUR = "4";
    }

    internal static readonly Dictionary<Models.CvvCode, string> CvvCodeMap = new()
    {
        { Models.CvvCode.None, null },
        { Models.CvvCode.E, CvvCode.E },
        { Models.CvvCode.I, CvvCode.I },
        { Models.CvvCode.M, CvvCode.M },
        { Models.CvvCode.N, CvvCode.N },
        { Models.CvvCode.P, CvvCode.P },
        { Models.CvvCode.S, CvvCode.S },
        { Models.CvvCode.U, CvvCode.U },
        { Models.CvvCode.X, CvvCode.X },
        { Models.CvvCode.AllOthers, CvvCode.ALL_OTHERS },
        { Models.CvvCode.Zero, CvvCode.ZERO },
        { Models.CvvCode.One, CvvCode.ONE },
        { Models.CvvCode.Two, CvvCode.TWO },
        { Models.CvvCode.Three, CvvCode.THREE },
        { Models.CvvCode.Four, CvvCode.FOUR }
    };

    internal sealed class CvvCode
    {
        public const string E = "E";
        public const string I = "I";
        public const string M = "M";
        public const string N = "N";
        public const string P = "R";
        public const string S = "S";
        public const string U = "U";
        public const string X = "X";
        public const string ALL_OTHERS = "All others";
        public const string ZERO = "0";
        public const string ONE = "1";
        public const string TWO = "2";
        public const string THREE = "3";
        public const string FOUR = "4";
    }

    internal static readonly Dictionary<Models.PaymentAdviceCode, string> PaymentAdviceCodeMap = new()
    {
        { Models.PaymentAdviceCode.None, null },
        { Models.PaymentAdviceCode.One, PaymentAdviceCode.ONE },
        { Models.PaymentAdviceCode.Two, PaymentAdviceCode.TWO },
        { Models.PaymentAdviceCode.Three, PaymentAdviceCode.THREE },
        { Models.PaymentAdviceCode.TwentyOne, PaymentAdviceCode.TWENTY_ONE }
    };

    internal sealed class PaymentAdviceCode
    {
        public const string ONE = "01";
        public const string TWO = "02";
        public const string THREE = "03";
        public const string TWENTY_ONE = "21";
    }

    internal static readonly Dictionary<Models.ProcessorResponseCode, string> ProcessorResponseCodeMap = new()
    {
        { Models.ProcessorResponseCode.None, null },
        { Models.ProcessorResponseCode.Approved, ProcessorResponseCode.APPROVED },
        { Models.ProcessorResponseCode.Cvv2FailurePossibleRetryWithCvv, ProcessorResponseCode.CVV2_FAILURE_POSSIBLE_RETRY_WITH_CVV },
        { Models.ProcessorResponseCode.Referral, ProcessorResponseCode.REFERRAL },
        { Models.ProcessorResponseCode.AccountNotFound, ProcessorResponseCode.ACCOUNT_NOT_FOUND },
        { Models.ProcessorResponseCode.DoNotHonor, ProcessorResponseCode.DO_NOT_HONOR },
        { Models.ProcessorResponseCode.UnauthorizedTransaction, ProcessorResponseCode.UNAUTHORIZED_TRANSACTION },
        { Models.ProcessorResponseCode.BadResponseReversalRequired, ProcessorResponseCode.BAD_RESPONSE_REVERSAL_REQUIRED },
        { Models.ProcessorResponseCode.CryptographicFailure, ProcessorResponseCode.CRYPTOGRAPHIC_FAILURE },
        { Models.ProcessorResponseCode.CancelledPayment, ProcessorResponseCode.CANCELLED_PAYMENT },
        { Models.ProcessorResponseCode.PartialAuthorization, ProcessorResponseCode.PARTIAL_AUTHORIZATION },
        { Models.ProcessorResponseCode.IssuerRejected, ProcessorResponseCode.ISSUER_REJECTED },
        { Models.ProcessorResponseCode.InvalidDataFormat, ProcessorResponseCode.INVALID_DATA_FORMAT },
        { Models.ProcessorResponseCode.InvalidAmount, ProcessorResponseCode.INVALID_AMOUNT },
        { Models.ProcessorResponseCode.InvalidTransactionCardIssuerAcquirer, ProcessorResponseCode.INVALID_TRANSACTION_CARD_ISSUER_ACQUIRER },
        { Models.ProcessorResponseCode.InvalidCaptureDate, ProcessorResponseCode.INVALID_CAPTURE_DATE },
        { Models.ProcessorResponseCode.InvalidCurrencyCode, ProcessorResponseCode.INVALID_CURRENCY_CODE },
        { Models.ProcessorResponseCode.InvalidAccount, ProcessorResponseCode.INVALID_ACCOUNT },
        { Models.ProcessorResponseCode.InvalidAccountRecurring, ProcessorResponseCode.INVALID_ACCOUNT_RECURRING },
        { Models.ProcessorResponseCode.InvalidTerminal, ProcessorResponseCode.INVALID_TERMINAL },
        { Models.ProcessorResponseCode.InvalidMerchant, ProcessorResponseCode.INVALID_MERCHANT },
        { Models.ProcessorResponseCode.BadProcessingCode, ProcessorResponseCode.BAD_PROCESSING_CODE },
        { Models.ProcessorResponseCode.InvalidMcc, ProcessorResponseCode.INVALID_MCC },
        { Models.ProcessorResponseCode.InvalidExpiration, ProcessorResponseCode.INVALID_EXPIRATION },
        { Models.ProcessorResponseCode.InvalidCardVerificationValue, ProcessorResponseCode.INVALID_CARD_VERIFICATION_VALUE },
        { Models.ProcessorResponseCode.InvalidLifeCycleOfTransaction, ProcessorResponseCode.INVALID_LIFE_CYCLE_OF_TRANSACTION },
        { Models.ProcessorResponseCode.InvalidOrder, ProcessorResponseCode.INVALID_ORDER },
        { Models.ProcessorResponseCode.TransactionCannotBeCompleted, ProcessorResponseCode.TRANSACTION_CANNOT_BE_COMPLETED },
        { Models.ProcessorResponseCode.GenericDecline, ProcessorResponseCode.GENERIC_DECLINE },
        { Models.ProcessorResponseCode.Cvv2Failure, ProcessorResponseCode.CVV2_FAILURE },
        { Models.ProcessorResponseCode.InsufficientFunds, ProcessorResponseCode.INSUFFICIENT_FUNDS },
        { Models.ProcessorResponseCode.InvalidPin, ProcessorResponseCode.INVALID_PIN },
        { Models.ProcessorResponseCode.DeclinedPinTryExceeded, ProcessorResponseCode.DECLINED_PIN_TRY_EXCEEDED },
        { Models.ProcessorResponseCode.CardClosed, ProcessorResponseCode.CARD_CLOSED },
        { Models.ProcessorResponseCode.PickupCardSpecialConditions, ProcessorResponseCode.PICKUP_CARD_SPECIAL_CONDITIONS },
        { Models.ProcessorResponseCode.UnauthorizedUser, ProcessorResponseCode.UNAUTHORIZED_USER },
        { Models.ProcessorResponseCode.AvsFailure, ProcessorResponseCode.AVS_FAILURE },
        { Models.ProcessorResponseCode.InvalidOrRestrictedCard, ProcessorResponseCode.INVALID_OR_RESTRICTED_CARD },
        { Models.ProcessorResponseCode.SoftAvs, ProcessorResponseCode.SOFT_AVS },
        { Models.ProcessorResponseCode.DuplicateTransaction, ProcessorResponseCode.DUPLICATE_TRANSACTION },
        { Models.ProcessorResponseCode.InvalidTransaction, ProcessorResponseCode.INVALID_TRANSACTION },
        { Models.ProcessorResponseCode.ExpiredCard, ProcessorResponseCode.EXPIRED_CARD },
        { Models.ProcessorResponseCode.IncorrectPinReenter, ProcessorResponseCode.INCORRECT_PIN_REENTER },
        { Models.ProcessorResponseCode.DeclinedScaRequired, ProcessorResponseCode.DECLINED_SCA_REQUIRED },
        { Models.ProcessorResponseCode.TransactionNotPermitted, ProcessorResponseCode.TRANSACTION_NOT_PERMITTED },
        { Models.ProcessorResponseCode.TxAttemptsExceedLimit, ProcessorResponseCode.TX_ATTEMPTS_EXCEED_LIMIT },
        { Models.ProcessorResponseCode.ReversalRejected, ProcessorResponseCode.REVERSAL_REJECTED },
        { Models.ProcessorResponseCode.InvalidIssue, ProcessorResponseCode.INVALID_ISSUE },
        { Models.ProcessorResponseCode.IssuerNotAvailableNotRetriable, ProcessorResponseCode.ISSUER_NOT_AVAILABLE_NOT_RETRIABLE },
        { Models.ProcessorResponseCode.IssuerNotAvailableRetriable, ProcessorResponseCode.ISSUER_NOT_AVAILABLE_RETRIABLE },
        { Models.ProcessorResponseCode.CardNotActivated, ProcessorResponseCode.CARD_NOT_ACTIVATED },
        { Models.ProcessorResponseCode.AccountNotOnFile, ProcessorResponseCode.ACCOUNT_NOT_ON_FILE },
        { Models.ProcessorResponseCode.ApprovedNonCapture, ProcessorResponseCode.APPROVED_NON_CAPTURE },
        { Models.ProcessorResponseCode.Error3Ds, ProcessorResponseCode.ERROR_3DS },
        { Models.ProcessorResponseCode.AuthenticationFailed, ProcessorResponseCode.AUTHENTICATION_FAILED },
        { Models.ProcessorResponseCode.BinError, ProcessorResponseCode.BIN_ERROR },
        { Models.ProcessorResponseCode.PinError, ProcessorResponseCode.PIN_ERROR },
        { Models.ProcessorResponseCode.ProcessorSystemError, ProcessorResponseCode.PROCESSOR_SYSTEM_ERROR },
        { Models.ProcessorResponseCode.HostKeyError, ProcessorResponseCode.HOST_KEY_ERROR },
        { Models.ProcessorResponseCode.ConfigurationError, ProcessorResponseCode.CONFIGURATION_ERROR },
        { Models.ProcessorResponseCode.UnsupportedOperation, ProcessorResponseCode.UNSUPPORTED_OPERATION },
        { Models.ProcessorResponseCode.FatalCommunicationError, ProcessorResponseCode.FATAL_COMMUNICATION_ERROR },
        { Models.ProcessorResponseCode.RetriableCommunicationError, ProcessorResponseCode.RETRIABLE_COMMUNICATION_ERROR },
        { Models.ProcessorResponseCode.SystemUnavailable, ProcessorResponseCode.SYSTEM_UNAVAILABLE },
        { Models.ProcessorResponseCode.DeclinedPleaseRetry, ProcessorResponseCode.DECLINED_PLEASE_RETRY },
        { Models.ProcessorResponseCode.SuspectedFraud, ProcessorResponseCode.SUSPECTED_FRAUD },
        { Models.ProcessorResponseCode.SecurityViolation, ProcessorResponseCode.SECURITY_VIOLATION },
        { Models.ProcessorResponseCode.LostOrStolen, ProcessorResponseCode.LOST_OR_STOLEN },
        { Models.ProcessorResponseCode.HoldCallCenter, ProcessorResponseCode.HOLD_CALL_CENTER },
        { Models.ProcessorResponseCode.RefusedCard, ProcessorResponseCode.REFUSED_CARD },
        { Models.ProcessorResponseCode.UnrecognizedResponseCode, ProcessorResponseCode.UNRECOGNIZED_RESPONSE_CODE },
        { Models.ProcessorResponseCode.ContingenciesNotResolved, ProcessorResponseCode.CONTINGENCIES_NOT_RESOLVED },
        { Models.ProcessorResponseCode.CvvFailure, ProcessorResponseCode.CVV_FAILURE },
        { Models.ProcessorResponseCode.BillingAddress, ProcessorResponseCode.BILLING_ADDRESS },
        { Models.ProcessorResponseCode.AmexDisabled, ProcessorResponseCode.AMEX_DISABLED },
        { Models.ProcessorResponseCode.AdultGamingUnsupported, ProcessorResponseCode.ADULT_GAMING_UNSUPPORTED },
        { Models.ProcessorResponseCode.AmountIncompatible, ProcessorResponseCode.AMOUNT_INCOMPATIBLE },
        { Models.ProcessorResponseCode.AuthResult, ProcessorResponseCode.AUTH_RESULT },
        { Models.ProcessorResponseCode.MccCode, ProcessorResponseCode.MCC_CODE },
        { Models.ProcessorResponseCode.ArcAvs, ProcessorResponseCode.ARC_AVS },
        { Models.ProcessorResponseCode.AmountExceeded, ProcessorResponseCode.AMOUNT_EXCEEDED },
        { Models.ProcessorResponseCode.BadGaming, ProcessorResponseCode.BAD_GAMING },
        { Models.ProcessorResponseCode.ArcCvv, ProcessorResponseCode.ARC_CVV },
        { Models.ProcessorResponseCode.CeRegistrationIncomplete, ProcessorResponseCode.CE_REGISTRATION_INCOMPLETE },
        { Models.ProcessorResponseCode.Country, ProcessorResponseCode.COUNTRY },
        { Models.ProcessorResponseCode.CreditError, ProcessorResponseCode.CREDIT_ERROR },
        { Models.ProcessorResponseCode.CardTypeUnsupported, ProcessorResponseCode.CARD_TYPE_UNSUPPORTED },
        { Models.ProcessorResponseCode.CurrencyUsedInvalid, ProcessorResponseCode.CURRENCY_USED_INVALID },
        { Models.ProcessorResponseCode.SecureError3Ds, ProcessorResponseCode.SECURE_ERROR_3DS },
        { Models.ProcessorResponseCode.DccUnsupported, ProcessorResponseCode.DCC_UNSUPPORTED },
        { Models.ProcessorResponseCode.DinersReject, ProcessorResponseCode.DINERS_REJECT },
        { Models.ProcessorResponseCode.AuthMessage, ProcessorResponseCode.AUTH_MESSAGE },
        { Models.ProcessorResponseCode.ExpiredFundingInstrument, ProcessorResponseCode.EXPIRED_FUNDING_INSTRUMENT },
        { Models.ProcessorResponseCode.ExceedsFrequencyLimit, ProcessorResponseCode.EXCEEDS_FREQUENCY_LIMIT },
        { Models.ProcessorResponseCode.InternalSystemError, ProcessorResponseCode.INTERNAL_SYSTEM_ERROR },
        { Models.ProcessorResponseCode.ExpiryDate, ProcessorResponseCode.EXPIRY_DATE },
        { Models.ProcessorResponseCode.FundingSourceAlreadyExists, ProcessorResponseCode.FUNDING_SOURCE_ALREADY_EXISTS },
        { Models.ProcessorResponseCode.InvalidFundingInstrument, ProcessorResponseCode.INVALID_FUNDING_INSTRUMENT },
        { Models.ProcessorResponseCode.RestrictedFundingInstrument, ProcessorResponseCode.RESTRICTED_FUNDING_INSTRUMENT },
        { Models.ProcessorResponseCode.FieldValidationFailed, ProcessorResponseCode.FIELD_VALIDATION_FAILED },
        { Models.ProcessorResponseCode.GamingRefundError, ProcessorResponseCode.GAMING_REFUND_ERROR },
        { Models.ProcessorResponseCode.H1Error, ProcessorResponseCode.H1_ERROR },
        { Models.ProcessorResponseCode.IdempotencyFailure, ProcessorResponseCode.IDEMPOTENCY_FAILURE },
        { Models.ProcessorResponseCode.InvalidInputFailure, ProcessorResponseCode.INVALID_INPUT_FAILURE },
        { Models.ProcessorResponseCode.IdMismatch, ProcessorResponseCode.ID_MISMATCH },
        { Models.ProcessorResponseCode.InvalidTraceId, ProcessorResponseCode.INVALID_TRACE_ID },
        { Models.ProcessorResponseCode.LateReversal, ProcessorResponseCode.LATE_REVERSAL },
        { Models.ProcessorResponseCode.LargeStatusCode, ProcessorResponseCode.LARGE_STATUS_CODE },
        { Models.ProcessorResponseCode.MissingBusinessRuleOrData, ProcessorResponseCode.MISSING_BUSINESS_RULE_OR_DATA },
        { Models.ProcessorResponseCode.BlockedMastercard, ProcessorResponseCode.BLOCKED_Mastercard },
        { Models.ProcessorResponseCode.Ppmd, ProcessorResponseCode.PPMD },
        { Models.ProcessorResponseCode.NotSupportedNrc, ProcessorResponseCode.NOT_SUPPORTED_NRC }
    };

    internal sealed class ProcessorResponseCode
    {
        public const string APPROVED = "0000";
        public const string CVV2_FAILURE_POSSIBLE_RETRY_WITH_CVV = "00N7";
        public const string REFERRAL = "0100";
        public const string ACCOUNT_NOT_FOUND = "0390";
        public const string DO_NOT_HONOR = "0500";
        public const string UNAUTHORIZED_TRANSACTION = "0580";
        public const string BAD_RESPONSE_REVERSAL_REQUIRED = "0800";
        public const string CRYPTOGRAPHIC_FAILURE = "0880";
        public const string CANCELLED_PAYMENT = "0R00";
        public const string PARTIAL_AUTHORIZATION = "1000";
        public const string ISSUER_REJECTED = "10BR";
        public const string INVALID_DATA_FORMAT = "1300";
        public const string INVALID_AMOUNT = "1310";
        public const string INVALID_TRANSACTION_CARD_ISSUER_ACQUIRER = "1312";
        public const string INVALID_CAPTURE_DATE = "1317";
        public const string INVALID_CURRENCY_CODE = "1320";
        public const string INVALID_ACCOUNT = "1330";
        public const string INVALID_ACCOUNT_RECURRING = "1335";
        public const string INVALID_TERMINAL = "1340";
        public const string INVALID_MERCHANT = "1350";
        public const string BAD_PROCESSING_CODE = "1360";
        public const string INVALID_MCC = "1370";
        public const string INVALID_EXPIRATION = "1380";
        public const string INVALID_CARD_VERIFICATION_VALUE = "1382";
        public const string INVALID_LIFE_CYCLE_OF_TRANSACTION = "1384";
        public const string INVALID_ORDER = "1390";
        public const string TRANSACTION_CANNOT_BE_COMPLETED = "1393";
        public const string GENERIC_DECLINE = "5100";
        public const string CVV2_FAILURE = "5110";
        public const string INSUFFICIENT_FUNDS = "5120";
        public const string INVALID_PIN = "5130";
        public const string DECLINED_PIN_TRY_EXCEEDED = "5135";
        public const string CARD_CLOSED = "5140";
        public const string PICKUP_CARD_SPECIAL_CONDITIONS = "5150";
        public const string UNAUTHORIZED_USER = "5160";
        public const string AVS_FAILURE = "5170";
        public const string INVALID_OR_RESTRICTED_CARD = "5180";
        public const string SOFT_AVS = "5190";
        public const string DUPLICATE_TRANSACTION = "5200";
        public const string INVALID_TRANSACTION = "5210";
        public const string EXPIRED_CARD = "5400";
        public const string INCORRECT_PIN_REENTER = "5500";
        public const string DECLINED_SCA_REQUIRED = "5650";
        public const string TRANSACTION_NOT_PERMITTED = "5700";
        public const string TX_ATTEMPTS_EXCEED_LIMIT = "5710";
        public const string REVERSAL_REJECTED = "5800";
        public const string INVALID_ISSUE = "5900";
        public const string ISSUER_NOT_AVAILABLE_NOT_RETRIABLE = "5910";
        public const string ISSUER_NOT_AVAILABLE_RETRIABLE = "5920";
        public const string CARD_NOT_ACTIVATED = "5930";
        public const string ACCOUNT_NOT_ON_FILE = "6300";
        public const string APPROVED_NON_CAPTURE = "7600";
        public const string ERROR_3DS = "7700";
        public const string AUTHENTICATION_FAILED = "7710";
        public const string BIN_ERROR = "7800";
        public const string PIN_ERROR = "7900";
        public const string PROCESSOR_SYSTEM_ERROR = "8000";
        public const string HOST_KEY_ERROR = "8010";
        public const string CONFIGURATION_ERROR = "8020";
        public const string UNSUPPORTED_OPERATION = "8030";
        public const string FATAL_COMMUNICATION_ERROR = "8100";
        public const string RETRIABLE_COMMUNICATION_ERROR = "8110";
        public const string SYSTEM_UNAVAILABLE = "8220";
        public const string DECLINED_PLEASE_RETRY = "9100";
        public const string SUSPECTED_FRAUD = "9500";
        public const string SECURITY_VIOLATION = "9510";
        public const string LOST_OR_STOLEN = "9520";
        public const string HOLD_CALL_CENTER = "9530";
        public const string REFUSED_CARD = "9540";
        public const string UNRECOGNIZED_RESPONSE_CODE = "9600";
        public const string CONTINGENCIES_NOT_RESOLVED = "PCNR";
        public const string CVV_FAILURE = "PCVV";
        public const string BILLING_ADDRESS = "PPAD";
        public const string AMEX_DISABLED = "PPAE";
        public const string ADULT_GAMING_UNSUPPORTED = "PPAG";
        public const string AMOUNT_INCOMPATIBLE = "PPAI";
        public const string AUTH_RESULT = "PPAR";
        public const string MCC_CODE = "PPAU";
        public const string ARC_AVS = "PPAV";
        public const string AMOUNT_EXCEEDED = "PPAX";
        public const string BAD_GAMING = "PPBG";
        public const string ARC_CVV = "PPC2";
        public const string CE_REGISTRATION_INCOMPLETE = "PPCE";
        public const string COUNTRY = "PPCO";
        public const string CREDIT_ERROR = "PPCR";
        public const string CARD_TYPE_UNSUPPORTED = "PPCT";
        public const string CURRENCY_USED_INVALID = "PPCU";
        public const string SECURE_ERROR_3DS = "PPD3";
        public const string DCC_UNSUPPORTED = "PPDC";
        public const string DINERS_REJECT = "PPDI";
        public const string AUTH_MESSAGE = "PPDV";
        public const string EXPIRED_FUNDING_INSTRUMENT = "PPEF";
        public const string EXCEEDS_FREQUENCY_LIMIT = "PPEL";
        public const string INTERNAL_SYSTEM_ERROR = "PPER";
        public const string EXPIRY_DATE = "PPEX";
        public const string FUNDING_SOURCE_ALREADY_EXISTS = "PPFE";
        public const string INVALID_FUNDING_INSTRUMENT = "PPFI";
        public const string RESTRICTED_FUNDING_INSTRUMENT = "PPFR";
        public const string FIELD_VALIDATION_FAILED = "PPFV";
        public const string GAMING_REFUND_ERROR = "PPGR";
        public const string H1_ERROR = "PPH1";
        public const string IDEMPOTENCY_FAILURE = "PPIF";
        public const string INVALID_INPUT_FAILURE = "PPII";
        public const string ID_MISMATCH = "PPIM";
        public const string INVALID_TRACE_ID = "PPIT";
        public const string LATE_REVERSAL = "PPLR";
        public const string LARGE_STATUS_CODE = "PPLS";
        public const string MISSING_BUSINESS_RULE_OR_DATA = "PPMB";
        public const string BLOCKED_Mastercard = "PPMC";
        public const string PPMD = "PPMD";
        public const string NOT_SUPPORTED_NRC = "PPNC";
    }

    internal sealed class UserInfoSchemas
    {
        public const string DEFAULT_SCHEMA = "paypalv1.1";
    }

    internal static readonly Dictionary<Models.CaptureStatusReason, string> CaptureStatusReasonMap = new()
    {
        { Models.CaptureStatusReason.None, null },
        { Models.CaptureStatusReason.BuyerComplaint, CaptureStatusReason.BUYER_COMPLAINT },
        { Models.CaptureStatusReason.Chargeback, CaptureStatusReason.CHARGEBACK },
        { Models.CaptureStatusReason.Echeck, CaptureStatusReason.ECHECK },
        { Models.CaptureStatusReason.InternationalWithdrawal, CaptureStatusReason.INTERNATIONAL_WITHDRAWAL },
        { Models.CaptureStatusReason.Other, CaptureStatusReason.OTHER },
        { Models.CaptureStatusReason.PendingReview, CaptureStatusReason.PENDING_REVIEW },
        { Models.CaptureStatusReason.ReceivingPreferenceMandatesManualAction, CaptureStatusReason.RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION },
        { Models.CaptureStatusReason.Refunded, CaptureStatusReason.REFUNDED },
        { Models.CaptureStatusReason.TransactionApprovedAwaitingFunding, CaptureStatusReason.TRANSACTION_APPROVED_AWAITING_FUNDING },
        { Models.CaptureStatusReason.Unilateral, CaptureStatusReason.UNILATERAL },
        { Models.CaptureStatusReason.VerificationRequired, CaptureStatusReason.VERIFICATION_REQUIRED }
    };

    internal sealed class CaptureStatusReason
    {
        public const string BUYER_COMPLAINT = "BUYER_COMPLAINT";
        public const string CHARGEBACK = "CHARGEBACK";
        public const string ECHECK = "ECHECK";
        public const string INTERNATIONAL_WITHDRAWAL = "INTERNATIONAL_WITHDRAWAL";
        public const string OTHER = "OTHER";
        public const string PENDING_REVIEW = "PENDING_REVIEW";
        public const string RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION = "RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION";
        public const string REFUNDED = "REFUNDED";
        public const string TRANSACTION_APPROVED_AWAITING_FUNDING = "TRANSACTION_APPROVED_AWAITING_FUNDING";
        public const string UNILATERAL = "UNILATERAL";
        public const string VERIFICATION_REQUIRED = "VERIFICATION_REQUIRED";
    }

    internal static readonly Dictionary<Models.SellerProtectionStatus, string> SellerProtectionStatusMap = new()
    {
        { Models.SellerProtectionStatus.None, null },
        { Models.SellerProtectionStatus.Eligible, SellerProtectionStatus.ELIGIBLE },
        { Models.SellerProtectionStatus.PartiallyEligible, SellerProtectionStatus.PARTIALLY_ELIGIBLE },
        { Models.SellerProtectionStatus.NotEligible, SellerProtectionStatus.NOT_ELIGIBLE }
    };

    internal sealed class SellerProtectionStatus
    {
        public const string ELIGIBLE = "ELIGIBLE";
        public const string PARTIALLY_ELIGIBLE = "PARTIALLY_ELIGIBLE";
        public const string NOT_ELIGIBLE = "NOT_ELIGIBLE";
    }

    internal static readonly Dictionary<Models.DisputeCategory, string> DisputeCategoryMap = new()
    {
        { Models.DisputeCategory.None, null },
        { Models.DisputeCategory.ItemNotReceived, DisputeCategory.ITEM_NOT_RECEIVED },
        { Models.DisputeCategory.UnauthorizedTransaction, DisputeCategory.UNAUTHORIZED_TRANSACTION }
    };

    internal sealed class DisputeCategory
    {
        public const string ITEM_NOT_RECEIVED = "ITEM_NOT_RECEIVED";
        public const string UNAUTHORIZED_TRANSACTION = "UNAUTHORIZED_TRANSACTION";
    }

    internal static readonly Dictionary<Models.RefundStatusReason, string> RefundStatusReasonMap = new()
    {
        { Models.RefundStatusReason.None, null },
        { Models.RefundStatusReason.Echeck, RefundStatusReason.ECHECK }
    };

    internal sealed class RefundStatusReason
    {
        public const string ECHECK = "ECHECK";
    }

    internal static readonly Dictionary<Models.PaymentInitiator, string> PaymentInitiatorMap = new()
    {
        { Models.PaymentInitiator.None, null },
        { Models.PaymentInitiator.Customer, PaymentInitiator.CUSTOMER },
        { Models.PaymentInitiator.Merchant, PaymentInitiator.MERCHANT }
    };

    internal sealed class PaymentInitiator
    {
        public const string CUSTOMER = "CUSTOMER";
        public const string MERCHANT = "MERCHANT";
    }

    internal static readonly Dictionary<Models.PaymentUsage, string> PaymentUsageMap = new()
    {
        { Models.PaymentUsage.None, null },
        { Models.PaymentUsage.First, PaymentUsage.FIRST },
        { Models.PaymentUsage.Subsequent, PaymentUsage.SUBSEQUENT },
        { Models.PaymentUsage.Derived, PaymentUsage.DERIVED }
    };

    internal sealed class PaymentUsage
    {
        public const string FIRST = "FIRST";
        public const string SUBSEQUENT = "SUBSEQUENT";
        public const string DERIVED = "DERIVED";
    }

    internal static readonly Dictionary<Models.PaymentType, string> PaymentTypeMap = new()
    {
        { Models.PaymentType.None, null },
        { Models.PaymentType.OneTime, PaymentType.ONE_TIME },
        { Models.PaymentType.Recurring, PaymentType.RECURRING },
        { Models.PaymentType.Unscheduled, PaymentType.UNSCHEDULED }
    };

    internal sealed class PaymentType
    {
        public const string ONE_TIME = "ONE_TIME";
        public const string RECURRING = "RECURRING";
        public const string UNSCHEDULED = "UNSCHEDULED";
    }

    internal static readonly Dictionary<Currency, string> CurrencyCodesMap = new()
    {
        { Currency.AustralianDollar, "AUD" },
        { Currency.BrazilianReal, "BRL" },
        { Currency.CanadianDollar, "CAD" },
        { Currency.ChineseRenmenbi, "CNY" },
        { Currency.CzechKoruna, "CZK" },
        { Currency.DanishKrone, "DKK" },
        { Currency.Euro, "EUR" },
        { Currency.HongKongDollar, "HKD" },
        { Currency.HungarianForint, "HUF" },
        { Currency.IsraeliNewShekel, "ILS" },
        { Currency.JapaneseYen, "JPY" },
        { Currency.MalaysianRinggit, "MYR" },
        { Currency.MexicanPeso, "MXN" },
        { Currency.NewTaiwanDollar, "TWD" },
        { Currency.NewZealandDollar, "NZD" },
        { Currency.NorwegianKrone, "NOK" },
        { Currency.PhilippinePeso, "PHP" },
        { Currency.PolishZloty, "PLN" },
        { Currency.PoundSterling, "GBP" },
        { Currency.RussianRuble, "RUB" },
        { Currency.SingaporeDollar, "SGD" },
        { Currency.SwedishKrona, "SEK" },
        { Currency.SwissFranc, "CHF" },
        { Currency.ThaiBaht, "THB" },
        { Currency.UnitedStatesDollar, "USD" }
    };

    internal static readonly Dictionary<Currency, string> CurrencyCodesWithoutDecimalSupportMap = new()
    {
        { Currency.HungarianForint, "HUF" },
        { Currency.JapaneseYen, "JPY" },
        { Currency.NewTaiwanDollar, "TWD" }
    };

    internal static readonly Dictionary<Locale, string> LanguageTagMap = new ()
    {
        { Locale.ArabicSaudiArabia, "ar-SA" },
        { Locale.BanglaBangladesh, "bn-BD" },
        { Locale.BanglaIndia, "bn-IN" },
        { Locale.CzechCzechRepublic, "cs-CZ" },
        { Locale.DanishDenmark, "da-DK" },
        { Locale.GermanAustria, "de-AT" },
        { Locale.GermanSwitzerland, "de-CH" },
        { Locale.GermanGermany, "de-DE" },
        { Locale.GreekGreece, "el-GR" },
        { Locale.EnglishAustralia, "en-AU" },
        { Locale.EnglishCanada, "en-CA" },
        { Locale.EnglishUnitedKingdom, "en-GB" },
        { Locale.EnglishIreland, "en-IE" },
        { Locale.EnglishIndia, "en-IN" },
        { Locale.EnglishNewZealand, "en-NZ" },
        { Locale.EnglishUnitedStates, "en-US" },
        { Locale.EnglishSouthAfrica, "en-ZA" },
        { Locale.SpanishArgentina, "es-AR" },
        { Locale.SpanishChile, "es-CL" },
        { Locale.SpanishColumbia, "es-CO" },
        { Locale.SpanishSpain, "es-ES" },
        { Locale.SpanishMexico, "es-MX" },
        { Locale.SpanishUnitedStates, "es-US" },
        { Locale.FinnishFinland, "fi-FI" },
        { Locale.FrenchBelgium, "fr-BE" },
        { Locale.FrenchCanada, "fr-CA" },
        { Locale.FrenchSwitzerland, "fr-CH" },
        { Locale.FrenchFrance, "fr-FR" },
        { Locale.HebrewIsrael, "he-IL" },
        { Locale.HindiIndia, "hi-IN" },
        { Locale.HungarianHungary, "hu-HU" },
        { Locale.IndonesianIndonesia, "id-ID" },
        { Locale.ItalianSwitzerland, "it-CH" },
        { Locale.ItalianItaly, "it-IT" },
        { Locale.JapaneseJapan, "jp-JP" },
        { Locale.KoreanRepublicofKorea, "ko-KR" },
        { Locale.DutchBelgium, "nl-BE" },
        { Locale.DutchTheNetherlands, "nl-NL" },
        { Locale.NorwegianNorway, "no-NO" },
        { Locale.PolishPoland, "pl-PL" },
        { Locale.PortugeseBrazil, "pt-BR" },
        { Locale.PortugesePortugal, "pt-PT" },
        { Locale.RomanianRomania, "ro-RO" },
        { Locale.RussianRussianFederation, "ru-RU" },
        { Locale.SlovakSlovakia, "sk-SK" },
        { Locale.SwedishSweden, "sv-SE" },
        { Locale.TamilIndia, "ta-IN" },
        { Locale.TamilSriLanka, "ta-LK" },
        { Locale.ThaiThailand, "th-TH" },
        { Locale.TurkishTurkey, "tr-TR" },
        { Locale.ChineseChina, "zh-CN" },
        { Locale.ChineseHondKong, "zh-HK" },
        { Locale.ChineseTaiwan, "zh-TW" }
    };

    public static readonly Dictionary<Country, CountryAddressOptions> CountryAddressOptionsMap = new()
    {
        {
            Country.Albania, new()
            {
                Code = "AL",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Algeria, new()
            {
                Code = "DZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Andorra, new()
            {
                Code = "AD",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Angola, new()
            {
                Code = "AO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Anguilla, new()
            {
                Code = "AI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.AntiguaAndBarbuda, new()
            {
                Code = "AG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Argentina, new()
            {
                Code = "AR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Armenia, new()
            {
                Code = "AM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Aruba, new()
            {
                Code = "AW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Australia, new()
            {
                Code = "AU",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Austria, new()
            {
                Code = "AT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Azerbaijan, new()
            {
                Code = "AZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Bahamas, new()
            {
                Code = "BS",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Bahrain, new()
            {
                Code = "BH",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Barbados, new()
            {
                Code = "BB",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Belarus, new()
            {
                Code = "BY",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Belgium, new()
            {
                Code = "BE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Belize, new()
            {
                Code = "BZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Benin, new()
            {
                Code = "BJ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Bermuda, new()
            {
                Code = "BM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Bhutan, new()
            {
                Code = "BT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Bolivia, new()
            {
                Code = "BO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.BosniaAndHerzegovina, new()
            {
                Code = "BA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Botswana, new()
            {
                Code = "BW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Brazil, new()
            {
                Code = "BR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.BritishVirginIslands, new()
            {
                Code = "VG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Brunei, new()
            {
                Code = "BN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Bulgaria, new()
            {
                Code = "BG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.BurkinaFaso, new()
            {
                Code = "BF",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Burundi, new()
            {
                Code = "BI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Cambodia, new()
            {
                Code = "KH",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Cameroon, new()
            {
                Code = "CM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Canada, new()
            {
                Code = "CA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.CapeVerde, new()
            {
                Code = "CV",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.CaymanIslands, new()
            {
                Code = "KY",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Chad, new()
            {
                Code = "TD",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Chile, new()
            {
                Code = "CL",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.China, new()
            {
                Code = "C2",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Colombia, new()
            {
                Code = "CO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Comoros, new()
            {
                Code = "KM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.CongoBrazzaville, new()
            {
                Code = "CG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.CongoKinshasa, new()
            {
                Code = "CD",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.CookIslands, new()
            {
                Code = "CK",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.CostaRica, new()
            {
                Code = "CR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.CoteDivoire, new()
            {
                Code = "CI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Croatia, new()
            {
                Code = "HR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Cyprus, new()
            {
                Code = "CY",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.CzechRepublic, new()
            {
                Code = "CZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Denmark, new()
            {
                Code = "DK",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Djibouti, new()
            {
                Code = "DJ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Dominica, new()
            {
                Code = "DM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.DominicanRepublic, new()
            {
                Code = "DO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Ecuador, new()
            {
                Code = "EC",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Egypt, new()
            {
                Code = "EG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.ElSalvador, new()
            {
                Code = "SV",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Eritrea, new()
            {
                Code = "ER",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Estonia, new()
            {
                Code = "EE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Ethiopia, new()
            {
                Code = "ET",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.FalklandIslands, new()
            {
                Code = "FK",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.FaroeIslands, new()
            {
                Code = "FO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Fiji, new()
            {
                Code = "FJ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Finland, new()
            {
                Code = "FI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.France, new()
            {
                Code = "FR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.FrenchGuiana, new()
            {
                Code = "GF",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.FrenchPolynesia, new()
            {
                Code = "PF",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Gabon, new()
            {
                Code = "GA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Gambia, new()
            {
                Code = "GM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Georgia, new()
            {
                Code = "GE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Germany, new()
            {
                Code = "DE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Gibraltar, new()
            {
                Code = "GI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Greece, new()
            {
                Code = "GR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Greenland, new()
            {
                Code = "GL",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Grenada, new()
            {
                Code = "GD",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Guadeloupe, new()
            {
                Code = "GP",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Guatemala, new()
            {
                Code = "GT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Guinea, new()
            {
                Code = "GN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.GuineaBissau, new()
            {
                Code = "GW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Guyana, new()
            {
                Code = "GY",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Honduras, new()
            {
                Code = "HN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.HongKongSarChina, new()
            {
                Code = "HK",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Hungary, new()
            {
                Code = "HU",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Iceland, new()
            {
                Code = "IS",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.India, new()
            {
                Code = "IN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Indonesia, new()
            {
                Code = "ID",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Ireland, new()
            {
                Code = "IE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Israel, new()
            {
                Code = "IL",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Italy, new()
            {
                Code = "IT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Jamaica, new()
            {
                Code = "JM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Japan, new()
            {
                Code = "JP",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Jordan, new()
            {
                Code = "JO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Kazakhstan, new()
            {
                Code = "KZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Kenya, new()
            {
                Code = "KE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Kiribati, new()
            {
                Code = "KI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Kuwait, new()
            {
                Code = "KW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Kyrgyzstan, new()
            {
                Code = "KG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Laos, new()
            {
                Code = "LA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Latvia, new()
            {
                Code = "LV",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Lesotho, new()
            {
                Code = "LS",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Liechtenstein, new()
            {
                Code = "LI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Lithuania, new()
            {
                Code = "LT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Luxembourg, new()
            {
                Code = "LU",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Macedonia, new()
            {
                Code = "MK",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Madagascar, new()
            {
                Code = "MG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Malawi, new()
            {
                Code = "MW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Malaysia, new()
            {
                Code = "MY",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Maldives, new()
            {
                Code = "MV",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Mali, new()
            {
                Code = "ML",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Malta, new()
            {
                Code = "MT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.MarshallIslands, new()
            {
                Code = "MH",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Martinique, new()
            {
                Code = "MQ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Mauritania, new()
            {
                Code = "MR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Mauritius, new()
            {
                Code = "MU",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Mayotte, new()
            {
                Code = "YT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Mexico, new()
            {
                Code = "MX",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Micronesia, new()
            {
                Code = "FM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Moldova, new()
            {
                Code = "MD",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Monaco, new()
            {
                Code = "MC",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Mongolia, new()
            {
                Code = "MN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Montenegro, new()
            {
                Code = "ME",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Montserrat, new()
            {
                Code = "MS",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Morocco, new()
            {
                Code = "MA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Mozambique, new()
            {
                Code = "MZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Namibia, new()
            {
                Code = "NA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Nauru, new()
            {
                Code = "NR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Nepal, new()
            {
                Code = "NP",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Netherlands, new()
            {
                Code = "NL",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.NewCaledonia, new()
            {
                Code = "NC",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.NewZealand, new()
            {
                Code = "NZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Nicaragua, new()
            {
                Code = "NI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Niger, new()
            {
                Code = "NE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Nigeria, new()
            {
                Code = "NG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Niue, new()
            {
                Code = "NU",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.NorfolkIsland, new()
            {
                Code = "NF",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Norway, new()
            {
                Code = "NO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Oman, new()
            {
                Code = "OM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Palau, new()
            {
                Code = "PW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Panama, new()
            {
                Code = "PA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.PapuaNewGuinea, new()
            {
                Code = "PG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Paraguay, new()
            {
                Code = "PY",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Peru, new()
            {
                Code = "PE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Philippines, new()
            {
                Code = "PH",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.PitcairnIslands, new()
            {
                Code = "PN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Poland, new()
            {
                Code = "PL",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Portugal, new()
            {
                Code = "PT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Qatar, new()
            {
                Code = "QA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Reunion, new()
            {
                Code = "RE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Romania, new()
            {
                Code = "RO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Russia, new()
            {
                Code = "RU",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Rwanda, new()
            {
                Code = "RW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Samoa, new()
            {
                Code = "WS",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.SanMarino, new()
            {
                Code = "SM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.SaoTomeAndPrincipe, new()
            {
                Code = "ST",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.SaudiArabia, new()
            {
                Code = "SA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Senegal, new()
            {
                Code = "SN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Serbia, new()
            {
                Code = "RS",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Seychelles, new()
            {
                Code = "SC",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.SierraLeone, new()
            {
                Code = "SL",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Singapore, new()
            {
                Code = "SG",
                IsCityRequired = false,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Slovakia, new()
            {
                Code = "SK",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Slovenia, new()
            {
                Code = "SI",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.SolomonIslands, new()
            {
                Code = "SB",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Somalia, new()
            {
                Code = "SO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.SouthAfrica, new()
            {
                Code = "ZA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.SouthKorea, new()
            {
                Code = "KR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Spain, new()
            {
                Code = "ES",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.SriLanka, new()
            {
                Code = "LK",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.StHelena, new()
            {
                Code = "SH",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.StKittsAndNevis, new()
            {
                Code = "KN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.StLucia, new()
            {
                Code = "LC",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.StPierreAndMiquelon, new()
            {
                Code = "PM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.StVincentAndGrenadines, new()
            {
                Code = "VC",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Suriname, new()
            {
                Code = "SR",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.SvalbardAndJanMayen, new()
            {
                Code = "SJ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Swaziland, new()
            {
                Code = "SZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Sweden, new()
            {
                Code = "SE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Switzerland, new()
            {
                Code = "CH",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Taiwan, new()
            {
                Code = "TW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Tajikistan, new()
            {
                Code = "TJ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Tanzania, new()
            {
                Code = "TZ",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Thailand, new()
            {
                Code = "TH",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Togo, new()
            {
                Code = "TG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Tonga, new()
            {
                Code = "TO",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.TrinidadAndTobago, new()
            {
                Code = "TT",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Tunisia, new()
            {
                Code = "TN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Turkmenistan, new()
            {
                Code = "TM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.TurksAndCaicosIslands, new()
            {
                Code = "TC",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Tuvalu, new()
            {
                Code = "TV",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Uganda, new()
            {
                Code = "UG",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Ukraine, new()
            {
                Code = "UA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.UnitedArabEmirates, new()
            {
                Code = "AE",
                IsCityRequired = false,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.UnitedKingdom, new()
            {
                Code = "GB",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.UnitedStates, new()
            {
                Code = "US",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Uruguay, new()
            {
                Code = "UY",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Vanuatu, new()
            {
                Code = "VU",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.VaticanCity, new()
            {
                Code = "VA",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = true
            }
        },
        {
            Country.Venezuela, new()
            {
                Code = "VE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Vietnam, new()
            {
                Code = "VN",
                IsCityRequired = true,
                IsStateOrProvinceRequired = true,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.WallisAndFutuna, new()
            {
                Code = "WF",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Yemen, new()
            {
                Code = "YE",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Zambia, new()
            {
                Code = "ZM",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        },
        {
            Country.Zimbabwe, new()
            {
                Code = "ZW",
                IsCityRequired = true,
                IsStateOrProvinceRequired = false,
                IsPostalCodeRequired = false
            }
        }
    };
}

public class CountryAddressOptions
{
    public string Code { get; set; }
    public bool IsCityRequired { get; set; }
    public bool IsStateOrProvinceRequired { get; set; }
    public bool IsPostalCodeRequired { get; set; }
}

public enum Currency
{
    None,
    AustralianDollar,
    BrazilianReal,
    CanadianDollar,
    ChineseRenmenbi,
    CzechKoruna,
    DanishKrone,
    Euro,
    HongKongDollar,
    HungarianForint,
    IsraeliNewShekel,
    JapaneseYen,
    MalaysianRinggit,
    MexicanPeso,
    NewTaiwanDollar,
    NewZealandDollar,
    NorwegianKrone,
    PhilippinePeso,
    PolishZloty,
    PoundSterling,
    RussianRuble,
    SingaporeDollar,
    SwedishKrona,
    SwissFranc,
    ThaiBaht,
    UnitedStatesDollar
}

public enum Country
{
    None,
    Albania,
    Algeria,
    Andorra,
    Angola,
    Anguilla,
    AntiguaAndBarbuda,
    Argentina,
    Armenia,
    Aruba,
    Australia,
    Austria,
    Azerbaijan,
    Bahamas,
    Bahrain,
    Barbados,
    Belarus,
    Belgium,
    Belize,
    Benin,
    Bermuda,
    Bhutan,
    Bolivia,
    BosniaAndHerzegovina,
    Botswana,
    Brazil,
    BritishVirginIslands,
    Brunei,
    Bulgaria,
    BurkinaFaso,
    Burundi,
    Cambodia,
    Cameroon,
    Canada,
    CapeVerde,
    CaymanIslands,
    Chad,
    Chile,
    China,
    Colombia,
    Comoros,
    CongoBrazzaville,
    CongoKinshasa,
    CookIslands,
    CostaRica,
    CoteDivoire,
    Croatia,
    Cyprus,
    CzechRepublic,
    Denmark,
    Djibouti,
    Dominica,
    DominicanRepublic,
    Ecuador,
    Egypt,
    ElSalvador,
    Eritrea,
    Estonia,
    Ethiopia,
    FalklandIslands,
    FaroeIslands,
    Fiji,
    Finland,
    France,
    FrenchGuiana,
    FrenchPolynesia,
    Gabon,
    Gambia,
    Georgia,
    Germany,
    Gibraltar,
    Greece,
    Greenland,
    Grenada,
    Guadeloupe,
    Guatemala,
    Guinea,
    GuineaBissau,
    Guyana,
    Honduras,
    HongKongSarChina,
    Hungary,
    Iceland,
    India,
    Indonesia,
    Ireland,
    Israel,
    Italy,
    Jamaica,
    Japan,
    Jordan,
    Kazakhstan,
    Kenya,
    Kiribati,
    Kuwait,
    Kyrgyzstan,
    Laos,
    Latvia,
    Lesotho,
    Liechtenstein,
    Lithuania,
    Luxembourg,
    Macedonia,
    Madagascar,
    Malawi,
    Malaysia,
    Maldives,
    Mali,
    Malta,
    MarshallIslands,
    Martinique,
    Mauritania,
    Mauritius,
    Mayotte,
    Mexico,
    Micronesia,
    Moldova,
    Monaco,
    Mongolia,
    Montenegro,
    Montserrat,
    Morocco,
    Mozambique,
    Namibia,
    Nauru,
    Nepal,
    Netherlands,
    NewCaledonia,
    NewZealand,
    Nicaragua,
    Niger,
    Nigeria,
    Niue,
    NorfolkIsland,
    Norway,
    Oman,
    Palau,
    Panama,
    PapuaNewGuinea,
    Paraguay,
    Peru,
    Philippines,
    PitcairnIslands,
    Poland,
    Portugal,
    Qatar,
    Reunion,
    Romania,
    Russia,
    Rwanda,
    Samoa,
    SanMarino,
    SaoTomeAndPrincipe,
    SaudiArabia,
    Senegal,
    Serbia,
    Seychelles,
    SierraLeone,
    Singapore,
    Slovakia,
    Slovenia,
    SolomonIslands,
    Somalia,
    SouthAfrica,
    SouthKorea,
    Spain,
    SriLanka,
    StHelena,
    StKittsAndNevis,
    StLucia,
    StPierreAndMiquelon,
    StVincentAndGrenadines,
    Suriname,
    SvalbardAndJanMayen,
    Swaziland,
    Sweden,
    Switzerland,
    Taiwan,
    Tajikistan,
    Tanzania,
    Thailand,
    Togo,
    Tonga,
    TrinidadAndTobago,
    Tunisia,
    Turkmenistan,
    TurksAndCaicosIslands,
    Tuvalu,
    Uganda,
    Ukraine,
    UnitedArabEmirates,
    UnitedKingdom,
    UnitedStates,
    Uruguay,
    Vanuatu,
    VaticanCity,
    Venezuela,
    Vietnam,
    WallisAndFutuna,
    Yemen,
    Zambia,
    Zimbabwe
}

public enum Locale
{
    None,
    ArabicSaudiArabia,
    BanglaBangladesh,
    BanglaIndia,
    CzechCzechRepublic,
    DanishDenmark,
    GermanAustria,
    GermanSwitzerland,
    GermanGermany,
    GreekGreece,
    EnglishAustralia,
    EnglishCanada,
    EnglishUnitedKingdom,
    EnglishIreland,
    EnglishIndia,
    EnglishNewZealand,
    EnglishUnitedStates,
    EnglishSouthAfrica,
    SpanishArgentina,
    SpanishChile,
    SpanishColumbia,
    SpanishSpain,
    SpanishMexico,
    SpanishUnitedStates,
    FinnishFinland,
    FrenchBelgium,
    FrenchCanada,
    FrenchSwitzerland,
    FrenchFrance,
    HebrewIsrael,
    HindiIndia,
    HungarianHungary,
    IndonesianIndonesia,
    ItalianSwitzerland,
    ItalianItaly,
    JapaneseJapan,
    KoreanRepublicofKorea,
    DutchBelgium,
    DutchTheNetherlands,
    NorwegianNorway,
    PolishPoland,
    PortugeseBrazil,
    PortugesePortugal,
    RomanianRomania,
    RussianRussianFederation,
    SlovakSlovakia,
    SwedishSweden,
    TamilIndia,
    TamilSriLanka,
    ThaiThailand,
    TurkishTurkey,
    ChineseChina,
    ChineseHondKong,
    ChineseTaiwan
}

public class Argentina
{
    public static readonly Dictionary<Province, string> ProvinceCodesMap = new()
    {
        { Province.BuenosAiresCiudad, "CIUDAD AUTÓNOMA DE BUENOS AIRES" },
        { Province.BuenosAiresProvincia, "BUENOS AIRES" },
        { Province.Catamarca, "CATAMARCA" },
        { Province.Chaco, "CHACO" },
        { Province.Chubut, "CHUBUT" },
        { Province.Corrientes, "CORRIENTES" },
        { Province.Cordoba, "CÓRDOBA" },
        { Province.EntreRios, "ENTRE RÍOS" },
        { Province.Formosa, "FORMOSA" },
        { Province.Jujuy, "JUJUY" },
        { Province.LaPampa, "LA PAMPA" },
        { Province.LaRioja, "LA RIOJA" },
        { Province.Mendoza, "MENDOZA" },
        { Province.Misiones, "MISIONES" },
        { Province.Neuquen, "NEUQUÉN" },
        { Province.RioNegro, "RÍO NEGRO" },
        { Province.Salta, "SALTA" },
        { Province.SanJuan, "SAN JUAN" },
        { Province.SanLuis, "SAN LUIS" },
        { Province.SantaCruz, "SANTA CRUZ" },
        { Province.SantaFe, "SANTA FE" },
        { Province.SantiagoDelEstero, "SANTIAGO DEL ESTERO" },
        { Province.TierraDelFuego, "TIERRA DEL FUEGO" },
        { Province.Tucuman, "TUCUMÁN" }
    };

    public enum Province
    {
        BuenosAiresCiudad,
        BuenosAiresProvincia,
        Catamarca,
        Chaco,
        Chubut,
        Corrientes,
        Cordoba,
        EntreRios,
        Formosa,
        Jujuy,
        LaPampa,
        LaRioja,
        Mendoza,
        Misiones,
        Neuquen,
        RioNegro,
        Salta,
        SanJuan,
        SanLuis,
        SantaCruz,
        SantaFe,
        SantiagoDelEstero,
        TierraDelFuego,
        Tucuman
    }
}

public class Brazil
{
    public static readonly Dictionary<State, string> StateCodesMap = new()
    {
        { State.Acre, "AC" },
        { State.Alagoas, "AL" },
        { State.Amapa, "AP" },
        { State.Amazonas, "AM" },
        { State.Bahia, "BA" },
        { State.Ceara, "CE" },
        { State.DistritoFederalBrazil, "DF" },
        { State.EspiritoSanto, "ES" },
        { State.Goias, "GO" },
        { State.Maranhao, "MA" },
        { State.MatoGrosso, "MT" },
        { State.MatoGrossoDoSul, "MS" },
        { State.MinasGerais, "MG" },
        { State.Parana, "PR" },
        { State.Paraiba, "PB" },
        { State.Para, "PA" },
        { State.Pernambuco, "PE" },
        { State.Piaui, "PI" },
        { State.RioGrandeDoNorte, "RN" },
        { State.RioGrandeDoSul, "RS" },
        { State.RioDeJaneiro, "RJ" },
        { State.Rondonia, "RO" },
        { State.Roraima, "RR" },
        { State.SantaCatarina, "SC" },
        { State.Sergipe, "SE" },
        { State.SaoPaulo, "SP" },
        { State.Tocantins, "TO" }
    };

    public enum State
    {
        Acre,
        Alagoas,
        Amapa,
        Amazonas,
        Bahia,
        Ceara,
        DistritoFederalBrazil,
        EspiritoSanto,
        Goias,
        Maranhao,
        MatoGrosso,
        MatoGrossoDoSul,
        MinasGerais,
        Parana,
        Paraiba,
        Para,
        Pernambuco,
        Piaui,
        RioGrandeDoNorte,
        RioGrandeDoSul,
        RioDeJaneiro,
        Rondonia,
        Roraima,
        SantaCatarina,
        Sergipe,
        SaoPaulo,
        Tocantins
    }
}

public class Canada
{
    public static readonly Dictionary<Province, string> ProvinceCodesMap = new()
    {
        { Province.Alberta, "AB" },
        { Province.BritishColumbia, "BC" },
        { Province.Manitoba, "MB" },
        { Province.NewBrunswick, "NB" },
        { Province.NewfoundlandAndLabrador, "NL" },
        { Province.NorthwestTerritories, "NT" },
        { Province.NovaScotia, "NS" },
        { Province.Nunavut, "NU" },
        { Province.Ontario, "ON" },
        { Province.PrinceEdwardIsland, "PE" },
        { Province.Quebec, "QC" },
        { Province.Saskatchewan, "SK" },
        { Province.Yukon, "YT" }
    };

    public enum Province
    {
        Alberta,
        BritishColumbia,
        Manitoba,
        NewBrunswick,
        NewfoundlandAndLabrador,
        NorthwestTerritories,
        NovaScotia,
        Nunavut,
        Ontario,
        PrinceEdwardIsland,
        Quebec,
        Saskatchewan,
        Yukon
    }
}

public class China
{
    public static readonly Dictionary<Subdivision, string> ProvinceCodesMap = new()
    {
        { Subdivision.AnhuiSheng, "CN-AH" },
        { Subdivision.BeijingShi, "CN-BJ" },
        { Subdivision.ChongqingShi, "CN-CQ" },
        { Subdivision.FujianSheng, "CN-FJ" },
        { Subdivision.GuangdongSheng, "CN-GD" },
        { Subdivision.GansuSheng, "CN-GS" },
        { Subdivision.GuangxiZhuangzuZizhiqu, "CN-GX" },
        { Subdivision.GuizhouSheng, "CN-GZ" },
        { Subdivision.HenanSheng, "CN-HA" },
        { Subdivision.HubeiSheng, "CN-HB" },
        { Subdivision.HebeiSheng, "CN-HE" },
        { Subdivision.HainanSheng, "CN-HI" },
        { Subdivision.HongKongSAR, "CN-HK" },
        { Subdivision.HeilongjiangSheng, "CN-HL" },
        { Subdivision.HunanSheng, "CN-HN" },
        { Subdivision.JilinSheng, "CN-JL" },
        { Subdivision.JiangsuSheng, "CN-JS" },
        { Subdivision.JiangxiSheng, "CN-JX" },
        { Subdivision.LiaoningSheng, "CN-LN" },
        { Subdivision.MacaoSAR, "CN-MO" },
        { Subdivision.NeiMongolZizhiqu, "CN-NM" },
        { Subdivision.NingxiaHuizuZizhiqu, "CN-NX" },
        { Subdivision.QinghaiSheng, "CN-QH" },
        { Subdivision.SichuanSheng, "CN-SC" },
        { Subdivision.ShandongSheng, "CN-SD" },
        { Subdivision.ShanghaiShi, "CN-SH" },
        { Subdivision.ShaanxiSheng, "CN-SN" },
        { Subdivision.ShanxiSheng, "CN-SX" },
        { Subdivision.TianjinShi, "CN-TJ" },
        { Subdivision.TaiwanSheng, "CN-TW" },
        { Subdivision.XinjiangUygurZizhiqu, "CN-XJ" },
        { Subdivision.XizangZizhiqu, "CN-XZ" },
        { Subdivision.YunnanSheng, "CN-YN" },
        { Subdivision.ZhejiangSheng, "CN-ZJ" }
    };

    public enum Subdivision
    {
        AnhuiSheng,
        BeijingShi,
        ChongqingShi,
        FujianSheng,
        GuangdongSheng,
        GansuSheng,
        GuangxiZhuangzuZizhiqu,
        GuizhouSheng,
        HenanSheng,
        HubeiSheng,
        HebeiSheng,
        HainanSheng,
        HongKongSAR,
        HeilongjiangSheng,
        HunanSheng,
        JilinSheng,
        JiangsuSheng,
        JiangxiSheng,
        LiaoningSheng,
        MacaoSAR,
        NeiMongolZizhiqu,
        NingxiaHuizuZizhiqu,
        QinghaiSheng,
        SichuanSheng,
        ShandongSheng,
        ShanghaiShi,
        ShaanxiSheng,
        ShanxiSheng,
        TianjinShi,
        TaiwanSheng,
        XinjiangUygurZizhiqu,
        XizangZizhiqu,
        YunnanSheng,
        ZhejiangSheng
    }
}

public class India
{
    public static readonly Dictionary<State, string> ProvinceCodesMap = new()
    {
        { State.AndamanAndNicobarIslands, "Andaman and Nicobar Islands" },
        { State.AndhraPradesh, "Andhra Pradesh" },
        { State.ArmyPostOffice, "APO" },
        { State.ArunachalPradesh, "Arunachal Pradesh" },
        { State.Assam, "Assam" },
        { State.Bihar, "Bihar" },
        { State.Chandigarh, "Chandigarh" },
        { State.Chhattisgarh, "Chhattisgarh" },
        { State.DadraAndNagarHaveli, "Dadra and Nagar Haveli" },
        { State.DamanAndDiu, "Daman and Diu" },
        { State.Delhi, "Delhi (NCT)" },
        { State.Goa, "Goa" },
        { State.Gujarat, "Gujarat" },
        { State.Haryana, "Haryana" },
        { State.HimachalPradesh, "Himachal Pradesh" },
        { State.JammuAndKashmir, "Jammu and Kashmir" },
        { State.Jharkhand, "Jharkhand" },
        { State.Karnataka, "Karnataka" },
        { State.Kerala, "Kerala" },
        { State.Lakshadweep, "Lakshadweep" },
        { State.MadhyaPradesh, "Madhya Pradesh" },
        { State.Maharashtra, "Maharashtra" },
        { State.Manipur, "Manipur" },
        { State.Meghalaya, "Meghalaya" },
        { State.Mizoram, "Mizoram" },
        { State.Nagaland, "Nagaland" },
        { State.Odisha, "Odisha" },
        { State.Puducherry, "Puducherry" },
        { State.Punjab, "Punjab" },
        { State.Rajasthan, "Rajasthan" },
        { State.Sikkim, "Sikkim" },
        { State.TamilNadu, "Tamil Nadu" },
        { State.Telangana, "Telangana" },
        { State.Tripura, "Tripura" },
        { State.UttarPradesh, "Uttar Pradesh" },
        { State.Uttarakhand, "Uttarakhand" },
        { State.WestBengal, "West Bengal" }
    };

    public enum State
    {
        AndamanAndNicobarIslands,
        AndhraPradesh,
        ArmyPostOffice,
        ArunachalPradesh,
        Assam,
        Bihar,
        Chandigarh,
        Chhattisgarh,
        DadraAndNagarHaveli,
        DamanAndDiu,
        Delhi,
        Goa,
        Gujarat,
        Haryana,
        HimachalPradesh,
        JammuAndKashmir,
        Jharkhand,
        Karnataka,
        Kerala,
        Lakshadweep,
        MadhyaPradesh,
        Maharashtra,
        Manipur,
        Meghalaya,
        Mizoram,
        Nagaland,
        Odisha,
        Puducherry,
        Punjab,
        Rajasthan,
        Sikkim,
        TamilNadu,
        Telangana,
        Tripura,
        UttarPradesh,
        Uttarakhand,
        WestBengal
    }
}

public class Indonesia
{
    public static readonly Dictionary<Province, string> ProvinceCodesMap = new()
    {
        { Province.Bali, "ID-BA" },
        { Province.BangkaBelitung, "ID-BB" },
        { Province.Banten, "ID-BT" },
        { Province.Bengkulu, "ID-BE" },
        { Province.DIYogyakarta, "ID-YO" },
        { Province.DKIJakarta, "ID-JK" },
        { Province.Gorontalo, "ID-GO" },
        { Province.Jambi, "ID-JA" },
        { Province.JawaBarat, "ID-JB" },
        { Province.JawaTengah, "ID-JT" },
        { Province.JawaTimur, "ID-JI" },
        { Province.KalimantanBarat, "ID-KB" },
        { Province.KalimantanSelatan, "ID-KS" },
        { Province.KalimantanTengah, "ID-KT" },
        { Province.KalimantanTimur, "ID-KI" },
        { Province.KalimantanUtara, "ID-KU" },
        { Province.KepulauanRiau, "ID-KR" },
        { Province.Lampung, "ID-LA" },
        { Province.Maluku, "ID-MA" },
        { Province.MalukuUtara, "ID-MU" },
        { Province.NanggroeAcehDarussalam, "ID-AC" },
        { Province.NusaTenggaraBarat, "ID-NB" },
        { Province.NusaTenggaraTimur, "ID-NT" },
        { Province.Papua, "ID-PA" },
        { Province.PapuaBarat, "ID-PB" },
        { Province.Riau, "ID-RI" },
        { Province.SulawesiBarat, "ID-SR" },
        { Province.SulawesiSelatan, "ID-SN" },
        { Province.SulawesiTengah, "ID-ST" },
        { Province.SulawesiTenggara, "ID-SG" },
        { Province.SulawesiUtara, "ID-SA" },
        { Province.SumateraBarat, "ID-SB" },
        { Province.SumateraSelatan, "ID-SS" },
        { Province.SumateraUtara, "ID-SU" }
    };

    public enum Province
    {
        Bali,
        BangkaBelitung,
        Banten,
        Bengkulu,
        DIYogyakarta,
        DKIJakarta,
        Gorontalo,
        Jambi,
        JawaBarat,
        JawaTengah,
        JawaTimur,
        KalimantanBarat,
        KalimantanSelatan,
        KalimantanTengah,
        KalimantanTimur,
        KalimantanUtara,
        KepulauanRiau,
        Lampung,
        Maluku,
        MalukuUtara,
        NanggroeAcehDarussalam,
        NusaTenggaraBarat,
        NusaTenggaraTimur,
        Papua,
        PapuaBarat,
        Riau,
        SulawesiBarat,
        SulawesiSelatan,
        SulawesiTengah,
        SulawesiTenggara,
        SulawesiUtara,
        SumateraBarat,
        SumateraSelatan,
        SumateraUtara
    }
}

public class Italy
{
    public static readonly Dictionary<Province, string> ProvinceCodesMap = new()
    {
        { Province.Agrigento, "AG" },
        { Province.Alessandria, "AL" },
        { Province.Ancona, "AN" },
        { Province.Aosta, "AO" },
        { Province.Arezzo, "AR" },
        { Province.AscoliPiceno, "AP" },
        { Province.Asti, "AT" },
        { Province.Avellino, "AV" },
        { Province.Bari, "BA" },
        { Province.BarlettaAndriaTrani, "BT" },
        { Province.Belluno, "BL" },
        { Province.Benevento, "BN" },
        { Province.Bergamo, "BG" },
        { Province.Biella, "BI" },
        { Province.Bologna, "BO" },
        { Province.Bolzano, "BZ" },
        { Province.Brescia, "BS" },
        { Province.Brindisi, "BR" },
        { Province.Cagliari, "CA" },
        { Province.Caltanissetta, "CL" },
        { Province.Campobasso, "CB" },
        { Province.CarboniaIglesias, "CI" },
        { Province.Caserta, "CE" },
        { Province.Catania, "CT" },
        { Province.Catanzaro, "CZ" },
        { Province.Chieti, "CH" },
        { Province.Como, "CO" },
        { Province.Cosenza, "CS" },
        { Province.Cremona, "CR" },
        { Province.Crotone, "KR" },
        { Province.Cuneo, "CN" },
        { Province.Enna, "EN" },
        { Province.Fermo, "FM" },
        { Province.Ferrara, "FE" },
        { Province.Firenze, "FI" },
        { Province.Foggia, "FG" },
        { Province.ForliCesena, "FC" },
        { Province.Frosinone, "FR" },
        { Province.Genova, "GE" },
        { Province.Gorizia, "GO" },
        { Province.Grosseto, "GR" },
        { Province.Imperia, "IM" },
        { Province.Isernia, "IS" },
        { Province.LAquila, "AQ" },
        { Province.LaSpezia, "SP" },
        { Province.Latina, "LT" },
        { Province.Lecce, "LE" },
        { Province.Lecco, "LC" },
        { Province.Livorno, "LI" },
        { Province.Lodi, "LO" },
        { Province.Lucca, "LU" },
        { Province.Macerata, "MC" },
        { Province.Mantova, "MN" },
        { Province.MassaCarrara, "MS" },
        { Province.Matera, "MT" },
        { Province.MedioCampidano, "VS" },
        { Province.Messina, "ME" },
        { Province.Milano, "MI" },
        { Province.Modena, "MO" },
        { Province.MonzaEDellaBrianza, "MB" },
        { Province.Napoli, "NA" },
        { Province.Novara, "NO" },
        { Province.Nuoro, "NU" },
        { Province.Ogliastra, "OG" },
        { Province.OlbiaTempio, "OT" },
        { Province.Oristano, "OR" },
        { Province.Padova, "PD" },
        { Province.Palermo, "PA" },
        { Province.Parma, "PR" },
        { Province.Pavia, "PV" },
        { Province.Perugia, "PG" },
        { Province.PesaroEUrbino, "PU" },
        { Province.Pescara, "PE" },
        { Province.Piacenza, "PC" },
        { Province.Pisa, "PI" },
        { Province.Pistoia, "PT" },
        { Province.Pordenone, "PN" },
        { Province.Potenza, "PZ" },
        { Province.Prato, "PO" },
        { Province.Ragusa, "RG" },
        { Province.Ravenna, "RA" },
        { Province.ReggioCalabria, "RC" },
        { Province.ReggioEmilia, "RE" },
        { Province.Rieti, "RI" },
        { Province.Rimini, "RN" },
        { Province.Roma, "RM" },
        { Province.Rovigo, "RO" },
        { Province.Salerno, "SA" },
        { Province.Sassari, "SS" },
        { Province.Savona, "SV" },
        { Province.Siena, "SI" },
        { Province.Siracusa, "SR" },
        { Province.Sondrio, "SO" },
        { Province.Taranto, "TA" },
        { Province.Teramo, "TE" },
        { Province.Terni, "TR" },
        { Province.Torino, "TO" },
        { Province.Trapani, "TP" },
        { Province.Trento, "TN" },
        { Province.Treviso, "TV" },
        { Province.Trieste, "TS" },
        { Province.Udine, "UD" },
        { Province.Varese, "VA" },
        { Province.Venezia, "VE" },
        { Province.VerbanoCusioOssola, "VB" },
        { Province.Vercelli, "VC" },
        { Province.Verona, "VR" },
        { Province.ViboValentia, "VV" },
        { Province.Vicenza, "VI" },
        { Province.Viterbo, "VT" }
    };

    public enum Province
    {
        Agrigento,
        Alessandria,
        Ancona,
        Aosta,
        Arezzo,
        AscoliPiceno,
        Asti,
        Avellino,
        Bari,
        BarlettaAndriaTrani,
        Belluno,
        Benevento,
        Bergamo,
        Biella,
        Bologna,
        Bolzano,
        Brescia,
        Brindisi,
        Cagliari,
        Caltanissetta,
        Campobasso,
        CarboniaIglesias,
        Caserta,
        Catania,
        Catanzaro,
        Chieti,
        Como,
        Cosenza,
        Cremona,
        Crotone,
        Cuneo,
        Enna,
        Fermo,
        Ferrara,
        Firenze,
        Foggia,
        ForliCesena,
        Frosinone,
        Genova,
        Gorizia,
        Grosseto,
        Imperia,
        Isernia,
        LAquila,
        LaSpezia,
        Latina,
        Lecce,
        Lecco,
        Livorno,
        Lodi,
        Lucca,
        Macerata,
        Mantova,
        MassaCarrara,
        Matera,
        MedioCampidano,
        Messina,
        Milano,
        Modena,
        MonzaEDellaBrianza,
        Napoli,
        Novara,
        Nuoro,
        Ogliastra,
        OlbiaTempio,
        Oristano,
        Padova,
        Palermo,
        Parma,
        Pavia,
        Perugia,
        PesaroEUrbino,
        Pescara,
        Piacenza,
        Pisa,
        Pistoia,
        Pordenone,
        Potenza,
        Prato,
        Ragusa,
        Ravenna,
        ReggioCalabria,
        ReggioEmilia,
        Rieti,
        Rimini,
        Roma,
        Rovigo,
        Salerno,
        Sassari,
        Savona,
        Siena,
        Siracusa,
        Sondrio,
        Taranto,
        Teramo,
        Terni,
        Torino,
        Trapani,
        Trento,
        Treviso,
        Trieste,
        Udine,
        Varese,
        Venezia,
        VerbanoCusioOssola,
        Vercelli,
        Verona,
        ViboValentia,
        Vicenza,
        Viterbo
    }
}

public class Japan
{
    public static readonly Dictionary<Prefecture, string> PrefectureCodesMap = new()
    {
        { Prefecture.Aichi, "AICHI-KEN" },
        { Prefecture.Akita, "AKITA-KEN" },
        { Prefecture.Aomori, "AOMORI-KEN" },
        { Prefecture.Chiba, "CHIBA-KEN" },
        { Prefecture.Ehime, "EHIME-KEN" },
        { Prefecture.Fukui, "FUKUI-KEN" },
        { Prefecture.Fukuoka, "FUKUOKA-KEN" },
        { Prefecture.Fukushima, "FUKUSHIMA-KEN" },
        { Prefecture.Gifu, "GIFU-KEN" },
        { Prefecture.Gunma, "GUNMA-KEN" },
        { Prefecture.Hiroshima, "HIROSHIMA-KEN" },
        { Prefecture.Hokkaido, "HOKKAIDO" },
        { Prefecture.Hyogo, "HYOGO-KEN" },
        { Prefecture.Ibaraki, "IBARAKI-KEN" },
        { Prefecture.Ishikawa, "ISHIKAWA-KEN" },
        { Prefecture.Iwate, "IWATE-KEN" },
        { Prefecture.Kagawa, "KAGAWA-KEN" },
        { Prefecture.Kagoshima, "KAGOSHIMA-KEN" },
        { Prefecture.Kanagawa, "KANAGAWA-KEN" },
        { Prefecture.Kochi, "KOCHI-KEN" },
        { Prefecture.Kumamoto, "KUMAMOTO-KEN" },
        { Prefecture.Kyoto, "KYOTO-FU" },
        { Prefecture.Mie, "MIE-KEN" },
        { Prefecture.Miyagi, "MIYAGI-KEN" },
        { Prefecture.Miyazaki, "MIYAZAKI-KEN" },
        { Prefecture.Nagano, "NAGANO-KEN" },
        { Prefecture.Nagasaki, "NAGASAKI-KEN" },
        { Prefecture.Nara, "NARA-KEN" },
        { Prefecture.Niigata, "NIIGATA-KEN" },
        { Prefecture.Oita, "OITA-KEN" },
        { Prefecture.Okayama, "OKAYAMA-KEN" },
        { Prefecture.Okinawa, "OKINAWA-KEN" },
        { Prefecture.Osaka, "OSAKA-FU" },
        { Prefecture.Saga, "SAGA-KEN" },
        { Prefecture.Saitama, "SAITAMA-KEN" },
        { Prefecture.Shiga, "SHIGA-KEN" },
        { Prefecture.Shimane, "SHIMANE-KEN" },
        { Prefecture.Shizuoka, "SHIZUOKA-KEN" },
        { Prefecture.Tochigi, "TOCHIGI-KEN" },
        { Prefecture.Tokushima, "TOKUSHIMA-KEN" },
        { Prefecture.Tokyo, "TOKYO-TO" },
        { Prefecture.Tottori, "TOTTORI-KEN" },
        { Prefecture.Toyama, "TOYAMA-KEN" },
        { Prefecture.Wakayama, "WAKAYAMA-KEN" },
        { Prefecture.Yamagata, "YAMAGATA-KEN" },
        { Prefecture.Yamaguchi, "YAMAGUCHI-KEN" },
        { Prefecture.Yamanashi, "YAMANASHI-KEN" }
    };

    public enum Prefecture
    {
        Aichi,
        Akita,
        Aomori,
        Chiba,
        Ehime,
        Fukui,
        Fukuoka,
        Fukushima,
        Gifu,
        Gunma,
        Hiroshima,
        Hokkaido,
        Hyogo,
        Ibaraki,
        Ishikawa,
        Iwate,
        Kagawa,
        Kagoshima,
        Kanagawa,
        Kochi,
        Kumamoto,
        Kyoto,
        Mie,
        Miyagi,
        Miyazaki,
        Nagano,
        Nagasaki,
        Nara,
        Niigata,
        Oita,
        Okayama,
        Okinawa,
        Osaka,
        Saga,
        Saitama,
        Shiga,
        Shimane,
        Shizuoka,
        Tochigi,
        Tokushima,
        Tokyo,
        Tottori,
        Toyama,
        Wakayama,
        Yamagata,
        Yamaguchi,
        Yamanashi
    }
}

public class Mexico
{
    public static readonly Dictionary<State, string> PrefectureCodesMap = new()
    {
        { State.Aguascalientes, "AGS" },
        { State.BajaCalifornia, "BC" },
        { State.BajaCaliforniaSur, "BCS" },
        { State.Campeche, "CAMP" },
        { State.Chiapas, "CHIS" },
        { State.Chihuahua, "CHIH" },
        { State.CiudadDeMexico, "CDMX" },
        { State.Coahuila, "COAH" },
        { State.Colima, "COL" },
        { State.DistritoFederalMexico, "DF" },
        { State.Durango, "DGO" },
        { State.EstadoDeMexico, "MEX" },
        { State.Guanajuato, "GTO" },
        { State.Guerrero, "GRO" },
        { State.Hidalgo, "HGO" },
        { State.Jalisco, "JAL" },
        { State.Michoacan, "MICH" },
        { State.Morelos, "MOR" },
        { State.Nayarit, "NAY" },
        { State.NuevoLeon, "NL" },
        { State.Oaxaca, "OAX" },
        { State.Puebla, "PUE" },
        { State.Queretaro, "QRO" },
        { State.QuintanaRoo, "Q ROO" },
        { State.SanLuisPotosi, "SLP" },
        { State.Sinaloa, "SIN" },
        { State.Sonora, "SON" },
        { State.Tabasco, "TAB" },
        { State.Tamaulipas, "TAMPS" },
        { State.Tlaxcala, "TLAX" },
        { State.Veracruz, "VER" },
        { State.Yucatan, "YUC" },
        { State.Zacatecas, "ZAC" }
    };

    public enum State
    {
        Aguascalientes,
        BajaCalifornia,
        BajaCaliforniaSur,
        Campeche,
        Chiapas,
        Chihuahua,
        CiudadDeMexico,
        Coahuila,
        Colima,
        DistritoFederalMexico,
        Durango,
        EstadoDeMexico,
        Guanajuato,
        Guerrero,
        Hidalgo,
        Jalisco,
        Michoacan,
        Morelos,
        Nayarit,
        NuevoLeon,
        Oaxaca,
        Puebla,
        Queretaro,
        QuintanaRoo,
        SanLuisPotosi,
        Sinaloa,
        Sonora,
        Tabasco,
        Tamaulipas,
        Tlaxcala,
        Veracruz,
        Yucatan,
        Zacatecas
    }
}

public class Thailand
{
    public static readonly Dictionary<Province, string> ProvinceCodesMap = new()
    {
        { Province.AmnatCharoen, "" },
        { Province.AngThong, "" },
        { Province.Bangkok, "" },
        { Province.BuengKan, "" },
        { Province.BuriRam, "" },
        { Province.Chachoengsao, "" },
        { Province.ChaiNat, "" },
        { Province.Chaiyaphum, "" },
        { Province.Chanthaburi, "" },
        { Province.ChiangMai, "" },
        { Province.ChiangRai, "" },
        { Province.ChonBuri, "" },
        { Province.Chumphon, "" },
        { Province.Kalasin, "" },
        { Province.KamphaengPhet, "" },
        { Province.Kanchanaburi, "" },
        { Province.KhonKaen, "" },
        { Province.Krabi, "" },
        { Province.Lampang, "" },
        { Province.Lamphun, "" },
        { Province.Loei, "" },
        { Province.LopBuri, "" },
        { Province.MaeHongSon, "" },
        { Province.MahaSarakham, "" },
        { Province.Mukdahan, "" },
        { Province.NakhonNayok, "" },
        { Province.NakhonPathom, "" },
        { Province.NakhonPhanom, "" },
        { Province.NakhonRatchasima, "" },
        { Province.NakhonSawan, "" },
        { Province.NakhonSiThammarat, "" },
        { Province.Nan, "" },
        { Province.Narathiwat, "" },
        { Province.NongBuaLamphu, "" },
        { Province.NongKhai, "" },
        { Province.Nonthaburi, "" },
        { Province.PathumThani, "" },
        { Province.Pattani, "" },
        { Province.PhangNga, "" },
        { Province.Phatthalung, "" },
        { Province.Phatthaya, "" },
        { Province.Phayao, "" },
        { Province.Phetchabun, "" },
        { Province.Phetchaburi, "" },
        { Province.Phichit, "" },
        { Province.Phitsanulok, "" },
        { Province.PhraNakhonSiAyutthaya, "" },
        { Province.Phrae, "" },
        { Province.Phuket, "" },
        { Province.PrachinBuri, "" },
        { Province.PrachuapKhiriKhan, "" },
        { Province.Ranong, "" },
        { Province.Ratchaburi, "" },
        { Province.Rayong, "" },
        { Province.RoiEt, "" },
        { Province.SaKaeo, "" },
        { Province.SakonNakhon, "" },
        { Province.SamutPrakan, "" },
        { Province.SamutSakhon, "" },
        { Province.SamutSongkhram, "" },
        { Province.Saraburi, "" },
        { Province.Satun, "" },
        { Province.SiSaKet, "" },
        { Province.SingBuri, "" },
        { Province.Songkhla, "" },
        { Province.Sukhothai, "" },
        { Province.SuphanBuri, "" },
        { Province.SuratThani, "" },
        { Province.Surin, "" },
        { Province.Tak, "" },
        { Province.Trang, "" },
        { Province.Trat, "" },
        { Province.UbonRatchathani, "" },
        { Province.UdonThani, "" },
        { Province.UthaiThani, "" },
        { Province.Uttaradit, "" },
        { Province.Yala, "" },
        { Province.Yasothon, ""}
    };

    public enum Province
    {
        AmnatCharoen,
        AngThong,
        Bangkok,
        BuengKan,
        BuriRam,
        Chachoengsao,
        ChaiNat,
        Chaiyaphum,
        Chanthaburi,
        ChiangMai,
        ChiangRai,
        ChonBuri,
        Chumphon,
        Kalasin,
        KamphaengPhet,
        Kanchanaburi,
        KhonKaen,
        Krabi,
        Lampang,
        Lamphun,
        Loei,
        LopBuri,
        MaeHongSon,
        MahaSarakham,
        Mukdahan,
        NakhonNayok,
        NakhonPathom,
        NakhonPhanom,
        NakhonRatchasima,
        NakhonSawan,
        NakhonSiThammarat,
        Nan,
        Narathiwat,
        NongBuaLamphu,
        NongKhai,
        Nonthaburi,
        PathumThani,
        Pattani,
        PhangNga,
        Phatthalung,
        Phatthaya,
        Phayao,
        Phetchabun,
        Phetchaburi,
        Phichit,
        Phitsanulok,
        PhraNakhonSiAyutthaya,
        Phrae,
        Phuket,
        PrachinBuri,
        PrachuapKhiriKhan,
        Ranong,
        Ratchaburi,
        Rayong,
        RoiEt,
        SaKaeo,
        SakonNakhon,
        SamutPrakan,
        SamutSakhon,
        SamutSongkhram,
        Saraburi,
        Satun,
        SiSaKet,
        SingBuri,
        Songkhla,
        Sukhothai,
        SuphanBuri,
        SuratThani,
        Surin,
        Tak,
        Trang,
        Trat,
        UbonRatchathani,
        UdonThani,
        UthaiThani,
        Uttaradit,
        Yala,
        Yasothon
    }
}

public class Usa
{
    public static readonly Dictionary<State, string> StateCodesMap = new()
    {
        { State.Alabama, "AL" },
        { State.Alaska, "AK" },
        { State.Arizona, "AZ" },
        { State.Arkansas, "AR" },
        { State.California, "CA" },
        { State.Colorado, "CO" },
        { State.Connecticut, "CT" },
        { State.Delaware, "DE" },
        { State.DistrictOfColumbia, "DC" },
        { State.Florida, "FL" },
        { State.Georgia, "GA" },
        { State.Hawaii, "HI" },
        { State.Idaho, "ID" },
        { State.Illinois, "IL" },
        { State.Indiana, "IN" },
        { State.Iowa, "IA" },
        { State.Kansas, "KS" },
        { State.Kentucky, "KY" },
        { State.Louisiana, "LA" },
        { State.Maine, "ME" },
        { State.Maryland, "MD" },
        { State.Massachusetts, "MA" },
        { State.Michigan, "MI" },
        { State.Minnesota, "MN" },
        { State.Mississippi, "MS" },
        { State.Missouri, "MO" },
        { State.Montana, "MT" },
        { State.Nebraska, "NE" },
        { State.Nevada, "NV" },
        { State.NewHampshire, "NH" },
        { State.NewJersey, "NJ" },
        { State.NewMexico, "NM" },
        { State.NewYork, "NY" },
        { State.NorthCarolina, "NC" },
        { State.NorthDakota, "ND" },
        { State.Ohio, "OH" },
        { State.Oklahoma, "OK" },
        { State.Oregon, "OR" },
        { State.Pennsylvania, "PA" },
        { State.PuertoRico, "PR" },
        { State.RhodeIsland, "RI" },
        { State.SouthCarolina, "SC" },
        { State.SouthDakota, "SD" },
        { State.Tennessee, "TN" },
        { State.Texas, "TX" },
        { State.Utah, "UT" },
        { State.Vermont, "VT" },
        { State.Virginia, "VA" },
        { State.Washington, "WA" },
        { State.WestVirginia, "WV" },
        { State.Wisconsin, "WI" },
        { State.Wyoming, "WY" }
    };

    public enum State
    {
        Alabama,
        Alaska,
        Arizona,
        Arkansas,
        California,
        Colorado,
        Connecticut,
        Delaware,
        DistrictOfColumbia,
        Florida,
        Georgia,
        Hawaii,
        Idaho,
        Illinois,
        Indiana,
        Iowa,
        Kansas,
        Kentucky,
        Louisiana,
        Maine,
        Maryland,
        Massachusetts,
        Michigan,
        Minnesota,
        Mississippi,
        Missouri,
        Montana,
        Nebraska,
        Nevada,
        NewHampshire,
        NewJersey,
        NewMexico,
        NewYork,
        NorthCarolina,
        NorthDakota,
        Ohio,
        Oklahoma,
        Oregon,
        Pennsylvania,
        PuertoRico,
        RhodeIsland,
        SouthCarolina,
        SouthDakota,
        Tennessee,
        Texas,
        Utah,
        Vermont,
        Virginia,
        Washington,
        WestVirginia,
        Wisconsin,
        Wyoming,
    }

    public class ArmedForcesAPO
    {
        public static readonly Dictionary<State, string> StateCodesMap = new()
        {
            { State.ArmedForcesAmericas, "AA" },
            { State.ArmedForcesEurope, "AE" },
            { State.ArmedForcesPacific, "AP" }
        };

        public enum State
        {
            ArmedForcesAmericas,
            ArmedForcesEurope,
            ArmedForcesPacific
        }
    }

    public class OutlyingAreas
    {
        public static readonly Dictionary<State, string> StateCodesMap = new()
        {
            { State.AmericanSamoa, "AS" },
            { State.FederatedStatesOfMicronesia, "FM" },
            { State.Guam, "GU" },
            { State.MarshallIslands, "MH" },
            { State.NorthernMarianaIslands, "MP" },
            { State.Palau, "PW" },
            { State.VirginIslands, "VI" }
        };

        public enum State
        {
            AmericanSamoa,
            FederatedStatesOfMicronesia,
            Guam,
            MarshallIslands,
            NorthernMarianaIslands,
            Palau,
            VirginIslands
        }
    }
}
