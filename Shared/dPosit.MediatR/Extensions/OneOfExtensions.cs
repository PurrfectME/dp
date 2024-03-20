using dPosit.Http.Models;
using OneOf;

namespace dPosit.MediatR.Extensions;

public static class OneOfExtensions
{
    public static bool IsErrorResult<T>(this OneOf<T, ErrorModel> oneOfResult)
    {
        return oneOfResult.IsT1;
    }
}
