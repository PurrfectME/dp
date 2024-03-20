using dPosit.PayPal.Sdk.RequestModels.Orders;
using dPosit.PayPal.Sdk.ResponseModels.Orders;

namespace dPosit.PayPal.Sdk.Clients.Orders;

public interface IPayPalOrdersClient
{
    Task<CreateOrderResponseDto> CreateOrderAsync(CreateOrderRequestDto requestDto, CancellationToken cancellationToken = default);

    Task UpdateOrderAsync(string orderId, UpdateOrderRequestDto requestDto, CancellationToken cancellationToken = default);

    Task<ShowOrderDetailsResponseDto> ShowOrderDetailsAsync(
        string orderId,
        ShowOrderDetailsRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<AuthorizePaymentForOrderResponseDto> AuthorizePaymentForOrderAsync(
        string orderId,
        AuthorizePaymentForOrderRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<CapturePaymentForOrderResponseDto> CapturePaymentForOrderAsync(
        string orderId,
        CapturePaymentForOrderRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<ConfirmOrderResponseDto> ConfirmOrder(
        string orderId,
        ConfirmOrderRequestDto requestDto,
        CancellationToken cancellationToken = default);
}
