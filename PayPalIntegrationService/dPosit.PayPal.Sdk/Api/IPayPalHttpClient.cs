using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateAccessToken;
using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateClientToken;
using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.TerminateAccessToken;
using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.UserInfo;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.AuthorizePaymentForOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.CapturePaymentForOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.ConfirmOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.CreateOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.ShowOrderDetails;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.UpdateOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.CaptureAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ReauthorizeAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.RefundCapturedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowCapturedPaymentDetails;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowDetailsForAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowRefundDetails;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.VoidAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListAllBalances;
using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListTransactions;

namespace dPosit.PayPal.Sdk.Api;

internal interface IPayPalHttpClient
{
    Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(
        GenerateAccessTokenRequest request,
        CancellationToken cancellationToken = default);

    Task TerminateAccessTokenAsync(TerminateAccessTokenRequest request, CancellationToken cancellationToken = default);

    Task<UserInfoResponse> UserInfoAsync(UserInfoRequest request, CancellationToken cancellationToken = default);

    Task<GenerateClientTokenResponse> GenerateClientTokenAsync(
        GenerateClientTokenRequest request,
        CancellationToken cancellationToken = default);

    Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request, CancellationToken cancellationToken = default);

    Task UpdateOrderAsync(string orderId, UpdateOrderRequest request, CancellationToken cancellationToken = default);

    Task<ShowOrderDetailsResponse> ShowOrderDetailsAsync(
        string orderId,
        ShowOrderDetailsRequest request,
        CancellationToken cancellationToken = default);

    Task<AuthorizePaymentForOrderResponse> AuthorizePaymentForOrderAsync(
        string orderId,
        AuthorizePaymentForOrderRequest request,
        CancellationToken cancellationToken = default);

    Task<CapturePaymentForOrderResponse> CapturePaymentForOrderAsync(
        string orderId,
        CapturePaymentForOrderRequest request,
        CancellationToken cancellationToken = default);

    Task<ConfirmOrderResponse> ConfirmOrderAsync(string orderId, ConfirmOrderRequest request, CancellationToken cancellationToken = default);

    Task<ShowDetailsForAuthorizedPaymentResponse> ShowDetailsForAuthorizedPaymentAsync(
        string authorizationId,
        ShowDetailsForAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default);

    Task<CaptureAuthorizedPaymentResponse> CaptureAuthorizedPaymentAsync(
        string authorizationId,
        CaptureAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default);

    Task<ReauthorizeAuthorizedPaymentResponse> ReauthorizeAuthorizedPaymentAsync(
        string authorizationId,
        ReauthorizeAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default);

    Task VoidAuthorizedPaymentAsync(
        string authorizationId,
        VoidAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default);

    Task<ShowCapturedPaymentDetailsResponse> ShowCapturedPaymentDetailsAsync(
        string captureId,
        ShowCapturedPaymentDetailsRequest request,
        CancellationToken cancellationToken = default);

    Task<RefundCapturedPaymentResponse> RefundCapturedPaymentAsync(
        string captureId,
        RefundCapturedPaymentRequest request,
        CancellationToken cancellationToken = default);

    Task<ShowRefundDetailsResponse> ShowRefundDetailsAsync(
        string refundId,
        ShowRefundDetailsRequest request,
        CancellationToken cancellationToken = default);

    Task<ListTransactionsResponse> ListTransactionsAsync(
        ListTransactionsRequest request,
        CancellationToken cancellationToken = default);

    Task<ListAllBalancesResponse> ListAllBalancesAsync(
        ListAllBalancesRequest request,
        CancellationToken cancellationToken = default);
}
