using dPosit.PayPal.Sdk.Api;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.RequestModels.Orders;
using dPosit.PayPal.Sdk.ResponseModels.Orders;
using Microsoft.Extensions.Options;

namespace dPosit.PayPal.Sdk.Clients.Orders;

public sealed class PayPalOrdersClient : IPayPalOrdersClient
{
    private readonly IPayPalHttpClient _payPalHttpClient;

    public PayPalOrdersClient(HttpClient httpClient, IOptions<PayPalOptions> options)
    {
        _payPalHttpClient = new PayPalHttpClient(httpClient, options);
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<CreateOrderResponseDto> CreateOrderAsync(
        CreateOrderRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.CreateOrderAsync(requestModel, cancellationToken);

        var responseDto = CreateOrderResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public Task UpdateOrderAsync(string orderId, UpdateOrderRequestDto requestDto, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(orderId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        return _payPalHttpClient.UpdateOrderAsync(orderId, requestModel, cancellationToken);
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ShowOrderDetailsResponseDto> ShowOrderDetailsAsync(
        string orderId,
        ShowOrderDetailsRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(orderId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ShowOrderDetailsAsync(orderId, requestModel, cancellationToken);

        var responseDto = ShowOrderDetailsResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<AuthorizePaymentForOrderResponseDto> AuthorizePaymentForOrderAsync(
        string orderId,
        AuthorizePaymentForOrderRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(orderId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.AuthorizePaymentForOrderAsync(orderId, requestModel, cancellationToken);

        var responseDto = AuthorizePaymentForOrderResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<CapturePaymentForOrderResponseDto> CapturePaymentForOrderAsync(
        string orderId,
        CapturePaymentForOrderRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(orderId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.CapturePaymentForOrderAsync(orderId, requestModel, cancellationToken);

        var responseDto = CapturePaymentForOrderResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ConfirmOrderResponseDto> ConfirmOrder(
        string orderId, ConfirmOrderRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(orderId);
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ConfirmOrderAsync(orderId, requestModel, cancellationToken);

        var responseDto = ConfirmOrderResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }
}
