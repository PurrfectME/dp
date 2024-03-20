using dPosit.PayPal.Sdk.Api;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.RequestModels.TransactionSearch;
using dPosit.PayPal.Sdk.ResponseModels.TransactionSearch;
using Microsoft.Extensions.Options;

namespace dPosit.PayPal.Sdk.Clients.TransactionSearch;

public sealed class PayPalTransactionSearchClient : IPayPalTransactionSearchClient
{
    private readonly IPayPalHttpClient _payPalHttpClient;

    public PayPalTransactionSearchClient(HttpClient httpClient, IOptions<PayPalOptions> options)
    {
        _payPalHttpClient = new PayPalHttpClient(httpClient, options);
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ListTransactionsResponseDto> ListTransactionsAsync(
        ListTransactionsRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ListTransactionsAsync(requestModel, cancellationToken);

        var responseDto = ListTransactionsResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<ListAllBalancesResponseDto> ListAllBalancesAsync(
        ListAllBalancesRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.ListAllBalancesAsync(requestModel, cancellationToken);

        var responseDto = ListAllBalancesResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }
}
