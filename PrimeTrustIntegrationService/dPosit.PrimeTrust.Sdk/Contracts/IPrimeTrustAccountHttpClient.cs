using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.Contracts;

public interface IPrimeTrustAccountHttpClient
{
    Task<dynamic> CreateUserAsync(string userEmail, string userName, string userPassword);

    Task<string> GetJwt(UserLoginDto loginDtoModel);

    Task<AccountCashTransferResponseDto> TrasnferFundsBetweenAccounts(AccountCashTransferRequestDto accountCashTransferDto);

    Task<AgreementPreviewResponseDto> PostAgreementPreviews(AgreementPreviewRequestDto agreementDto);

    Task<CreateAccountResponseDto> CreateAccount(CreateAccountRequestDto createAccountDto);

    Task<AddFundsResponseDto> AddFunds(string accountId, AddFundsRequestDto addFundsDto);

    Task<OpenAccountResponseDto> OpenAccount(string accountId);

    Task<CreateFundsTransferMethodResponseDto.Root> CreateFundsTransferMethod(CreateFundsTransferMethodRequestDto createFundsMethod);

    Task<MakeDisbursementResponseDto.Root> MakeWithdrawal(MakeDisbursementRequestDto withdrawalDto);

    Task<ContactReferenceResponseDto.Root> CreateContactTransferReference(CreateContactReferenceRequestDto contactReference);

    Task<MakeContributionResponseDto.Root> MakeContribution(MakeContributionRequestDto contribution);

    Task<TrackDepositResponseDto.Root> TrackDeposit(string fundsTransferId);

    Task<ContingentHoldsResponseDto.Root> GetContingentHold(string contingentHoldId);

    Task<AssetTransferMethodsResponseDto.Root> DepositAsset(AssetTransferMethodsRequestDto assetTransfer);

    Task<AssetContributionResponseDto.Root> TrackAsset(AssetContributionRequestDto assetContribution);

    Task<AssetTransfersResponseDto.Root> SettleAssetTransfers(string assetTransferId);

    Task<InternalAssetTransfersResponseDto.Root> TransferAssetsBetweenAccounts(InternalAssetTransfersRequestDto assetToTransfer);

    Task<WithdrawAssetResponseDto.Root> WithdrawAssets(WithdrawAssetRequestDto withdrawAsset);

    Task<TrackAssetTransfersResponseDto.Root> TrackAssetTransfers();
    
    Task<DisbursementAuthorizationsResponseDto.Root> GetDisbursementAuthorizations(string disbursementAuthorizationAssetId);
}
