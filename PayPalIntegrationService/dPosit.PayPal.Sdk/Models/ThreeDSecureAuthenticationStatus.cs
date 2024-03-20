namespace dPosit.PayPal.Sdk.Models;

public enum ThreeDSecureAuthenticationStatus
{
    /// <summary>
    /// Default empty status.
    /// </summary>
    None,
    /// <summary>
    /// Successful authentication.
    /// </summary>
    Successful,
    /// <summary>
    /// Failed authentication / account not verified / transaction denied.
    /// </summary>
    Failed,
    /// <summary>
    /// Unable to complete authentication.
    /// </summary>
    UnableToComplete,
    /// <summary>
    /// Successful attempts transaction.
    /// </summary>
    AttemptsTransaction,
    /// <summary>
    /// Challenge required for authentication.
    /// </summary>
    ChallengeRequired,
    /// <summary>
    /// Authentication rejected (merchant must not submit for authorization).
    /// </summary>
    Rejected,
    /// <summary>
    /// Challenge required; decoupled authentication confirmed.
    /// </summary>
    DecoupledConfirmed,
    /// <summary>
    /// Informational only; 3DS requestor challenge preference acknowledged.
    /// </summary>
    InformationalOnly
}
