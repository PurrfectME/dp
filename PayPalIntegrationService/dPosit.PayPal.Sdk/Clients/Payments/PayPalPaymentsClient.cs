using dPosit.PayPal.Sdk.Api;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.RequestModels.Payments;
using dPosit.PayPal.Sdk.ResponseModels.Payments;
using Microsoft.Extensions.Options;

namespace dPosit.PayPal.Sdk.Clients.Payments;

public sealed class PayPalPaymentsClient : IPayPalPaymentsClient
{
    private readonly IPayPalHttpClient _payPalHttpClient;

    public PayPalPaymentsClient(HttpClient httpClient, IOptions<PayPalOptions> options)
    {
        _payPalHttpClient = new PayPalHttpClient(httpClient, options);
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ShowDetailsForAuthorizedPaymentResponseDto> ShowDetailsForAuthorizedPaymentAsync(
        string authorizationId,
        ShowDetailsForAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(authorizationId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ShowDetailsForAuthorizedPaymentAsync(authorizationId, requestModel, cancellationToken);

        var responseDto = ShowDetailsForAuthorizedPaymentResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<CaptureAuthorizedPaymentResponseDto> CaptureAuthorizedPaymentAsync(
        string authorizationId,
        CaptureAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(authorizationId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.CaptureAuthorizedPaymentAsync(authorizationId, requestModel, cancellationToken);

        var responseDto = CaptureAuthorizedPaymentResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ReauthorizeAuthorizedPaymentResponseDto> ReauthorizeAuthorizedPaymentAsync(
        string authorizationId,
        ReauthorizeAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(authorizationId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ReauthorizeAuthorizedPaymentAsync(authorizationId, requestModel, cancellationToken);

        var responseDto = ReauthorizeAuthorizedPaymentResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public Task VoidAuthorizedPaymentAsync(
        string authorizationId,
        VoidAuthorizedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(authorizationId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        return _payPalHttpClient.VoidAuthorizedPaymentAsync(authorizationId, requestModel, cancellationToken);
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ShowCapturedPaymentDetailsResponseDto> ShowCapturedPaymentDetailsAsync(
        string captureId,
        ShowCapturedPaymentDetailsRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(captureId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ShowCapturedPaymentDetailsAsync(captureId, requestModel, cancellationToken);

        var responseDto = ShowCapturedPaymentDetailsResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<RefundCapturedPaymentResponseDto> RefundCapturedPaymentAsync(
        string captureId,
        RefundCapturedPaymentRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(captureId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.RefundCapturedPaymentAsync(captureId, requestModel, cancellationToken);

        var responseDto = RefundCapturedPaymentResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ShowRefundDetailsResponseDto> ShowRefundDetailsAsync(
        string refundId,
        ShowRefundDetailsRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(refundId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ShowRefundDetailsAsync(refundId, requestModel, cancellationToken);

        var responseDto = ShowRefundDetailsResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }
}
