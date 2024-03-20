using dPosit.PayPal.Sdk.RequestModels.TransactionSearch;
using dPosit.PayPal.Sdk.ResponseModels.TransactionSearch;

namespace dPosit.PayPal.Sdk.Clients.TransactionSearch;

public interface IPayPalTransactionSearchClient
{
    Task<ListTransactionsResponseDto> ListTransactionsAsync(
        ListTransactionsRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task<ListAllBalancesResponseDto> ListAllBalancesAsync(
        ListAllBalancesRequestDto requestDto,
        CancellationToken cancellationToken = default);
}
