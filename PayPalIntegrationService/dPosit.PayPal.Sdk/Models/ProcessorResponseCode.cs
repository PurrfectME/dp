﻿namespace dPosit.PayPal.Sdk.Models;

public enum ProcessorResponseCode
{
    None,
    Approved,
    Cvv2FailurePossibleRetryWithCvv,
    Referral,
    AccountNotFound,
    DoNotHonor,
    UnauthorizedTransaction,
    BadResponseReversalRequired,
    CryptographicFailure,
    CancelledPayment,
    PartialAuthorization,
    IssuerRejected,
    InvalidDataFormat,
    InvalidAmount,
    InvalidTransactionCardIssuerAcquirer,
    InvalidCaptureDate,
    InvalidCurrencyCode,
    InvalidAccount,
    InvalidAccountRecurring,
    InvalidTerminal,
    InvalidMerchant,
    BadProcessingCode,
    InvalidMcc,
    InvalidExpiration,
    InvalidCardVerificationValue,
    InvalidLifeCycleOfTransaction,
    InvalidOrder,
    TransactionCannotBeCompleted,
    GenericDecline,
    Cvv2Failure,
    InsufficientFunds,
    InvalidPin,
    DeclinedPinTryExceeded,
    CardClosed,
    PickupCardSpecialConditions,
    UnauthorizedUser,
    AvsFailure,
    InvalidOrRestrictedCard,
    SoftAvs,
    DuplicateTransaction,
    InvalidTransaction,
    ExpiredCard,
    IncorrectPinReenter,
    DeclinedScaRequired,
    TransactionNotPermitted,
    TxAttemptsExceedLimit,
    ReversalRejected,
    InvalidIssue,
    IssuerNotAvailableNotRetriable,
    IssuerNotAvailableRetriable,
    CardNotActivated,
    AccountNotOnFile,
    ApprovedNonCapture,
    Error3Ds,
    AuthenticationFailed,
    BinError,
    PinError,
    ProcessorSystemError,
    HostKeyError,
    ConfigurationError,
    UnsupportedOperation,
    FatalCommunicationError,
    RetriableCommunicationError,
    SystemUnavailable,
    DeclinedPleaseRetry,
    SuspectedFraud,
    SecurityViolation,
    LostOrStolen,
    HoldCallCenter,
    RefusedCard,
    UnrecognizedResponseCode,
    ContingenciesNotResolved,
    CvvFailure,
    BillingAddress,
    AmexDisabled,
    AdultGamingUnsupported,
    AmountIncompatible,
    AuthResult,
    MccCode,
    ArcAvs,
    AmountExceeded,
    BadGaming,
    ArcCvv,
    CeRegistrationIncomplete,
    Country,
    CreditError,
    CardTypeUnsupported,
    CurrencyUsedInvalid,
    SecureError3Ds,
    DccUnsupported,
    DinersReject,
    AuthMessage,
    ExpiredFundingInstrument,
    ExceedsFrequencyLimit,
    InternalSystemError,
    ExpiryDate,
    FundingSourceAlreadyExists,
    InvalidFundingInstrument,
    RestrictedFundingInstrument,
    FieldValidationFailed,
    GamingRefundError,
    H1Error,
    IdempotencyFailure,
    InvalidInputFailure,
    IdMismatch,
    InvalidTraceId,
    LateReversal,
    LargeStatusCode,
    MissingBusinessRuleOrData,
    BlockedMastercard,
    Ppmd,
    NotSupportedNrc
}