using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.Contracts;

public interface IFunds
{
    Task<AddFundsResponseDto.Root> AddFundsAsync(string accountId, AddFundsRequestDto addFundsDto, CancellationToken token);

    Task<ContactReferenceResponseDto.Root> CreateContactTransferReferenceAsync(CreateContactReferenceRequestDto contactReference, CancellationToken token);

    Task<CreateFundsTransferMethodResponseDto.Root> CreateFundsTransferMethodAsync(CreateFundsTransferMethodRequestDto createFundsMethod, CancellationToken token);

    Task<MakeContributionResponseDto.Root> MakeContributionAsync(MakeContributionRequestDto contribution, CancellationToken token);

    Task<TrackDepositResponseDto.Root> TrackDepositAsync(string fundsTransferId, CancellationToken token);

    Task<ContingentHoldsResponseDto.Root> GetContingentHoldAsync(string contingentHoldId, CancellationToken token);

    Task<AccountCashTransferResponseDto.Root> TrasnferFundsBetweenAccountsAsync(AccountCashTransferRequestDto accountCashTransferDto, CancellationToken token);

    Task<MakeDisbursementResponseDto.Root> MakeWithdrawalAsync(MakeDisbursementRequestDto withdrawalDto, CancellationToken token);

    //TODO: Похоже, что некоторые сигнатуры придётся отдельно выносить, так как они шарятся между запросами. Крч подумаю и прикину позже
    Task<DisbursementAuthorizationsResponseDto.Root> GetDisbursementAuthorizationsAsyncAsync(string disbursementAuthorizationAssetId, CancellationToken token);
}
