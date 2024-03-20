using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.Contracts;

public interface IAssets
{
    Task<AssetTransferMethodsResponseDto.Root> DepositAssetAsync(AssetTransferMethodsRequestDto assetTransfer, CancellationToken token = default);

    Task<AssetContributionResponseDto.Root> TrackAssetAsync(AssetContributionRequestDto assetContribution, CancellationToken token = default);

    Task<InternalAssetTransfersResponseDto.Root> TransferAssetsBetweenAccountsAsync(InternalAssetTransfersRequestDto assetToTransfer, CancellationToken token = default);

    Task<WithdrawAssetResponseDto.Root> WithdrawAssetsAsync(WithdrawAssetRequestDto withdrawAsset, CancellationToken token = default);

    Task<TrackAssetTransfersResponseDto.Root> TrackAssetTransfersAsync(CancellationToken token = default);

    Task<DisbursementAuthorizationsResponseDto.Root> GetDisbursementAuthorizationsAsync(string disbursementAuthorizationAssetId, CancellationToken token = default);
}
