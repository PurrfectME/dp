using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;
using dPosit.PrimeTrust.Sdk.Settings;

namespace dPosit.PrimeTrust.Sdk.HttpClients;
public partial class PrimeTrustClient : IAccounts
{
    public Task<CreateEntityAccountResponseDto.Root> CreateEntityAccountAsync(CreateEntityAccountRequestDto data, CancellationToken token = default) =>
        PostAsync<CreateEntityAccountRequestDto, CreateEntityAccountResponseDto.Root>(data, Constants.Accounts.CREATE_ENTITY_ACCOUNT, token);

    public Task<CreateAccountResponseDto.Root> CreateIndividualAccountAsync(CreateAccountRequestDto data, CancellationToken token = default) =>
        PostAsync<CreateAccountRequestDto, CreateAccountResponseDto.Root>(data, Constants.Accounts.CREATE_INDIVIDUAL_ACCOUNT, token);

    public Task<GetAccountAuthorizedCashTransfersResponseDto.Root> GetAccountAuthorizedCashTransfersAsync(string accountId, CancellationToken token = default) =>
        GetAsync<GetAccountAuthorizedCashTransfersResponseDto.Root>(string.Format(Constants.Accounts.GET_ACCOUNT_AUTHORIZED_ACCOUNTS, accountId), token);

    public Task<GetAccountCashTransfersResponseDto.Root> GetAccountCashTransfersAsync(string accountId, CancellationToken token = default) =>
        GetAsync<GetAccountCashTransfersResponseDto.Root>(string.Format(Constants.Accounts.GET_ACCOUNT_CASH_TRANSFERS, accountId), token);

    public Task<GetAccountInternalAssetTransfersResponseDto.Root> GetAccountInternalAssetTransfersAsync(string accountId, CancellationToken token = default) =>
        GetAsync<GetAccountInternalAssetTransfersResponseDto.Root>(string.Format(Constants.Accounts.GET_ACCOUNT_INTERNAL_ASSET_TRANSFERS, accountId), token);

    public Task<OpenAccountResponseDto.Root> OpenAccountAsync(string accountId, CancellationToken token = default) =>
        PostAsync<OpenAccountResponseDto.Root>(string.Format(Constants.Accounts.OPEN_ACCOUNT_URL, accountId), token);

    public Task<AgreementPreviewResponseDto.Root> PostAgreementPreviewsAsync(AgreementPreviewRequestDto agreementDto, CancellationToken token = default) =>
        PostAsync<AgreementPreviewRequestDto, AgreementPreviewResponseDto.Root>(agreementDto, Constants.Accounts.POST_AGREEMENT_PREVIEW, token);
}
