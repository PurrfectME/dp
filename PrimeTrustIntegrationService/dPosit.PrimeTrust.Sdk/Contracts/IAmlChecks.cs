using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.Contracts;

public interface IAmlChecks
{
    Task<AmlChecksResponseModel.Root> GetAmlChecks(CancellationToken token = default);

    Task<AmlChecksByIdResponseModel.Root> GetAmlChecksById(string amlCheckId, CancellationToken token = default);

    Task<ApproveAmlChecksResponseModel.Root> ApproveAmlChecks(string amlCheckId, CancellationToken token = default);

    Task<DenyAmlChecksResponseModel.Root> DenyAmlChecks(string amlCheckId, CancellationToken token = default);
}
