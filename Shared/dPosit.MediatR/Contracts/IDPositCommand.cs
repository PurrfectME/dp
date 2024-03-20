using dPosit.Http.Models;
using MediatR;
using OneOf;

namespace dPosit.MediatR.Contracts;

public interface IDPositCommand<TResult> : IRequest<OneOf<TResult, ErrorModel>>
{
}

public interface IDPositCommand : IRequest<OneOf<Unit, ErrorModel>>
{
}
