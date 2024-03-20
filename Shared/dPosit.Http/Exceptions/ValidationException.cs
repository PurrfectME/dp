using dPosit.Auth.Application.Common.Enums;
using FluentValidation.Results;

namespace dPosit.Http.Exceptions;

public sealed class ValidationException : Exception
{
    public IDictionary<string, ErrorCode[]> Errors { get; }

    public ValidationException()
        : base("One or more validation failures have occurred.")
    {
        Errors = new Dictionary<string, ErrorCode[]>();
    }

    public ValidationException(IEnumerable<ValidationFailure> failures)
        : this()
    {
        Errors = failures
            .GroupBy(
                e => e.PropertyName,
                e =>
                {
                    Enum.TryParse(e.ErrorCode, out ErrorCode errorCode);
                    return errorCode;
                })
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
}
