using dPosit.Http.Models;
using MediatR;
using OneOf;

namespace dPosit.MediatR.Contracts;

public interface IDPositCommandHandler<TCommand> : IRequestHandler<TCommand, OneOf<Unit, ErrorModel>>
    where TCommand : IRequest<OneOf<Unit, ErrorModel>>
{
}

public interface IDPositCommandHandler<TCommand, TResult> : IRequestHandler<TCommand, OneOf<TResult, ErrorModel>>
    where TCommand : IRequest<OneOf<TResult, ErrorModel>>
{
}
