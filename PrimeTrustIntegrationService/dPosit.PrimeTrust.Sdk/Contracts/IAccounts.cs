using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.Contracts;

public interface IAccounts
{
    Task<AgreementPreviewResponseDto.Root> PostAgreementPreviewsAsync(AgreementPreviewRequestDto agreementDto, CancellationToken cancellationToken = default);

    Task<CreateAccountResponseDto.Root> CreateIndividualAccountAsync(CreateAccountRequestDto createAccountDto, CancellationToken cancellationToken = default);

    Task<CreateEntityAccountResponseDto.Root> CreateEntityAccountAsync(CreateEntityAccountRequestDto createAccountDto, CancellationToken cancellationToken = default);

    Task<OpenAccountResponseDto.Root> OpenAccountAsync(string accountId, CancellationToken cancellationToken = default);

    Task<GetAccountCashTransfersResponseDto.Root> GetAccountCashTransfersAsync(string accountId, CancellationToken cancellationToken = default);

    Task<GetAccountAuthorizedCashTransfersResponseDto.Root> GetAccountAuthorizedCashTransfersAsync(string accountId, CancellationToken cancellationToken = default);

    Task<GetAccountInternalAssetTransfersResponseDto.Root> GetAccountInternalAssetTransfersAsync(string accountId, CancellationToken cancellationToken = default);
}
