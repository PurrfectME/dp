using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.ResponseModels;
using dPosit.PrimeTrust.Sdk.Settings;

namespace dPosit.PrimeTrust.Sdk.HttpClients;

public partial class PrimeTrustClient : IAmlChecks
{
    public Task<ApproveAmlChecksResponseModel.Root> ApproveAmlChecks(string amlCheckId, CancellationToken token = default) =>
        PostAsync<ApproveAmlChecksResponseModel.Root>(string.Format(Constants.AmlChecks.APPROVE_AML_CHECKS, amlCheckId), token);

    public Task<DenyAmlChecksResponseModel.Root> DenyAmlChecks(string amlCheckId, CancellationToken token = default) =>
        PostAsync<DenyAmlChecksResponseModel.Root>(string.Format(Constants.AmlChecks.DENY_AML_CHECKS, amlCheckId), token);

    public Task<AmlChecksResponseModel.Root> GetAmlChecks(CancellationToken token = default) =>
        GetAsync<AmlChecksResponseModel.Root>(Constants.AmlChecks.GET_AML_CHECKS, token);

    public Task<AmlChecksByIdResponseModel.Root> GetAmlChecksById(string amlCheckId, CancellationToken token = default) =>
        GetAsync<AmlChecksByIdResponseModel.Root>(string.Format(Constants.AmlChecks.GET_AML_CHECKS_BY_ID, amlCheckId), token);
}
