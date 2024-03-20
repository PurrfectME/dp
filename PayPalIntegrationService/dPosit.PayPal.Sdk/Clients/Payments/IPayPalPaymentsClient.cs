using dPosit.PayPal.Sdk.RequestModels.Payments;
using dPosit.PayPal.Sdk.ResponseModels.Payments;

namespace dPosit.PayPal.Sdk.Clients.Payments;

public interface IPayPalPaymentsClient
{
    Task<ShowDetailsForAuthorizedPaymentResponseDto> ShowDetailsForAuthorizedPaymentAsync(
        string authorizationId,
        ShowDetailsForAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<CaptureAuthorizedPaymentResponseDto> CaptureAuthorizedPaymentAsync(
        string authorizationId,
        CaptureAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<ReauthorizeAuthorizedPaymentResponseDto> ReauthorizeAuthorizedPaymentAsync(
        string authorizationId,
        ReauthorizeAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task VoidAuthorizedPaymentAsync(
        string authorizationId,
        VoidAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<ShowCapturedPaymentDetailsResponseDto> ShowCapturedPaymentDetailsAsync(
        string captureId,
        ShowCapturedPaymentDetailsRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<RefundCapturedPaymentResponseDto> RefundCapturedPaymentAsync(
        string captureId,
        RefundCapturedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<ShowRefundDetailsResponseDto> ShowRefundDetailsAsync(
        string refundId,
        ShowRefundDetailsRequestDto requestDto,
        CancellationToken cancellationToken = default);
}
