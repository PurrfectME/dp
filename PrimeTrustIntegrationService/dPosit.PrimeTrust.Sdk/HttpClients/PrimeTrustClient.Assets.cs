using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;
using dPosit.PrimeTrust.Sdk.Settings;

namespace dPosit.PrimeTrust.Sdk.HttpClients;

public partial class PrimeTrustClient : IAssets
{
    public Task<AssetTransferMethodsResponseDto.Root> DepositAssetAsync(AssetTransferMethodsRequestDto data, CancellationToken token = default) =>
        PostAsync<AssetTransferMethodsRequestDto, AssetTransferMethodsResponseDto.Root>(data, Constants.Assets.ASSET_TRANSFER_METHODS, token);

    public Task<DisbursementAuthorizationsResponseDto.Root> GetDisbursementAuthorizationsAsync(string disbursementAuthorizationAssetId, CancellationToken token = default) =>
        PostAsync<DisbursementAuthorizationsResponseDto.Root>(string.Format(Constants.Assets.DISBURSEMENT_AUTHORIZATIONS, disbursementAuthorizationAssetId), token);

    public Task<AssetContributionResponseDto.Root> TrackAssetAsync(AssetContributionRequestDto data, CancellationToken token = default) =>
        PostAsync<AssetContributionRequestDto, AssetContributionResponseDto.Root>(data, Constants.Assets.ASSET_CONTRIBUTION, token);

    public Task<TrackAssetTransfersResponseDto.Root> TrackAssetTransfersAsync(CancellationToken token = default) =>
        GetAsync<TrackAssetTransfersResponseDto.Root>(Constants.Assets.GET_ASSET_TRANSFERS, token);

    public Task<InternalAssetTransfersResponseDto.Root> TransferAssetsBetweenAccountsAsync(InternalAssetTransfersRequestDto data, CancellationToken token = default) =>
        PostAsync<InternalAssetTransfersRequestDto, InternalAssetTransfersResponseDto.Root>(data, Constants.Assets.INTERNAL_ASSET_TRANSFERS, token);

    public Task<WithdrawAssetResponseDto.Root> WithdrawAssetsAsync(WithdrawAssetRequestDto data, CancellationToken token = default) =>
        PostAsync<WithdrawAssetRequestDto, WithdrawAssetResponseDto.Root>(data, Constants.Assets.WITHDRAW_ASSETS, token);
}
