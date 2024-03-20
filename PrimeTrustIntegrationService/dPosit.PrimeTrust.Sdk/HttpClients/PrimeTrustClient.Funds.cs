using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;
using dPosit.PrimeTrust.Sdk.Settings;

namespace dPosit.PrimeTrust.Sdk.HttpClients;

public partial class PrimeTrustClient : IFunds
{
    public Task<AddFundsResponseDto.Root> AddFundsAsync(string accountId, AddFundsRequestDto data, CancellationToken token) =>
        PostAsync<AddFundsRequestDto, AddFundsResponseDto.Root>(data, string.Format(Constants.Funds.ADD_FUNDS, accountId), token);

    public Task<ContactReferenceResponseDto.Root> CreateContactTransferReferenceAsync(CreateContactReferenceRequestDto data, CancellationToken token) =>
        PostAsync<CreateContactReferenceRequestDto, ContactReferenceResponseDto.Root>(data, Constants.Funds.CREATE_CONTACT_REFERENCE, token);

    public Task<CreateFundsTransferMethodResponseDto.Root> CreateFundsTransferMethodAsync(CreateFundsTransferMethodRequestDto data, CancellationToken token) =>
        PostAsync<CreateFundsTransferMethodRequestDto, CreateFundsTransferMethodResponseDto.Root>(data, Constants.Funds.CREATE_FUNDS_TRANSFER_METHOD, token);

    public Task<ContingentHoldsResponseDto.Root> GetContingentHoldAsync(string contingentHoldId, CancellationToken token) =>
        PostAsync<ContingentHoldsResponseDto.Root>(string.Format(Constants.Funds.CONTINGENT_HOLDS, contingentHoldId), token);

    public Task<DisbursementAuthorizationsResponseDto.Root> GetDisbursementAuthorizationsAsyncAsync(string disbursemenAssetId, CancellationToken token) =>
        PostAsync<DisbursementAuthorizationsResponseDto.Root>(string.Format(Constants.Funds.DISBURSEMENT_AUTHORIZATIONS, disbursemenAssetId), token);

    public Task<MakeContributionResponseDto.Root> MakeContributionAsync(MakeContributionRequestDto data, CancellationToken token) =>
        PostAsync<MakeContributionRequestDto, MakeContributionResponseDto.Root>(data, Constants.Funds.MAKE_CONTRIBUTION, token);

    public Task<MakeDisbursementResponseDto.Root> MakeWithdrawalAsync(MakeDisbursementRequestDto data, CancellationToken token) =>
        PostAsync<MakeDisbursementRequestDto, MakeDisbursementResponseDto.Root>(data, Constants.Funds.MAKE_WITHDRAWAL, token);

    public Task<TrackDepositResponseDto.Root> TrackDepositAsync(string fundsTransferId, CancellationToken token) =>
        PostAsync<TrackDepositResponseDto.Root>(string.Format(Constants.Funds.TRACK_DEPOSIT, fundsTransferId), token);

    public Task<AccountCashTransferResponseDto.Root> TrasnferFundsBetweenAccountsAsync(AccountCashTransferRequestDto data, CancellationToken token) =>
        PostAsync<AccountCashTransferRequestDto, AccountCashTransferResponseDto.Root>(data, Constants.Funds.TRANSFER_FUNDS, token);
}
