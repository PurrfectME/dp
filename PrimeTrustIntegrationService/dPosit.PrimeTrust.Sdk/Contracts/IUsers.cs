using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.Contracts;

public interface IUsers
{
    //POST/v2/users
    Task<CreateUserResponseDto.Root> CreateUserAsync(CreateUserRequestDto createUserRequest, CancellationToken token);

    //GET/v2/users
    Task<UsersResponseDto.Root> GetUsersAsync(CancellationToken token);

    //GET/v2/users/id
    Task<UsersResponseDto.Root> GetUserByIdAsync(string userId, CancellationToken token);

    //PATCH/v2/users/id
    Task<UsersResponseDto.Root> PatchUserAsync(string userId, PatchUserRequestDto patchUserRequest, CancellationToken token);

    //v2/users/current
    Task<UsersResponseDto.Root> GetCurrentUserAsync(CancellationToken token);

    //PATCH/v2/users/current
    Task<UsersResponseDto.Root> PatchCurrentUserAsync(string userId, PatchUserRequestDto patchUserRequest, CancellationToken token);

    //POST/v2/users/current/jwts/invalidate
    Task<InvalidateJwtResponseDto.Root> InvalidateCurrentUserJwtAsync(CancellationToken token);
}
