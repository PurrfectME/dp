using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.Contracts;

public interface ICipChecks
{
    Task<CipChecksResposneModel.Root> GetAllCipChecks(CancellationToken cancellationToken = default);

    Task<CipChecksByIdResponseModel.Root> GetCipCheckById(string cipCheckId, CancellationToken cancellationToken = default);

    Task<SubmitReviewCipCheckResponseModel.Root> SubmitForReview(string cipCheckId, CancellationToken cancellationToken = default);

    Task<ApproveCipCheckResponseModel.Root> ApproveCipCHeck(string cipCheckId, CancellationToken cancellationToken = default);

    Task<DenyCipCheckResponseModel.Root> DenyCipCheck(string cipCheckId, CancellationToken cancellationToken = default);
}
