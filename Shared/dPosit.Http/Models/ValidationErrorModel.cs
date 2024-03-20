using dPosit.Auth.Application.Common.Enums;

namespace dPosit.Http.Models;

public sealed class ValidationErrorModel
{
    public string FieldName { get; set; }
    public ErrorCode[] ErrorCodes { get; set; }
}
