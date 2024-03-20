using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.ResponseModels;
using dPosit.PrimeTrust.Sdk.Settings;

namespace dPosit.PrimeTrust.Sdk.HttpClients;

public partial class PrimeTrustClient : ICipChecks
{
    public Task<ApproveCipCheckResponseModel.Root> ApproveCipCHeck(string cipCheckId, CancellationToken token = default) =>
        PostAsync<ApproveCipCheckResponseModel.Root>(string.Format(Constants.CipChecks.APPROVE_CIP_CHECK, cipCheckId), token);

    public Task<DenyCipCheckResponseModel.Root> DenyCipCheck(string cipCheckId, CancellationToken token = default) =>
        PostAsync<DenyCipCheckResponseModel.Root>(string.Format(Constants.CipChecks.DENY_CIP_CHECK, cipCheckId), token);

    public Task<CipChecksResposneModel.Root> GetAllCipChecks(CancellationToken token = default) =>
        GetAsync<CipChecksResposneModel.Root>(Constants.CipChecks.GET_CIP_CHECKS, token);

    public Task<CipChecksByIdResponseModel.Root> GetCipCheckById(string cipCheckId, CancellationToken token = default) =>
        GetAsync<CipChecksByIdResponseModel.Root>(string.Format(Constants.CipChecks.GET_CIP_CHECKS_BY_ID, cipCheckId), token);

    public Task<SubmitReviewCipCheckResponseModel.Root> SubmitForReview(string cipCheckId, CancellationToken token = default) =>
        PostAsync<SubmitReviewCipCheckResponseModel.Root>(string.Format(Constants.CipChecks.SUBMIT_CIP_CHECK_FOR_REVIEW, cipCheckId), token);
}
