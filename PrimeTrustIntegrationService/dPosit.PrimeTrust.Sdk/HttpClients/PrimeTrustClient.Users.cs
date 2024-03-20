using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;
using dPosit.PrimeTrust.Sdk.Settings;

namespace dPosit.PrimeTrust.Sdk.HttpClients;

public partial class PrimeTrustClient : IUsers
{
    public Task<CreateUserResponseDto.Root> CreateUserAsync(CreateUserRequestDto data, CancellationToken token) =>
        PostAsync<CreateUserRequestDto, CreateUserResponseDto.Root>(data, Constants.Users.CREATE_USER, token);

    public Task<UsersResponseDto.Root> GetCurrentUserAsync(CancellationToken token) =>
        GetAsync<UsersResponseDto.Root>(Constants.Users.GET_CURRENT_USER, token);

    public Task<UsersResponseDto.Root> GetUserByIdAsync(string userId, CancellationToken token) =>
        GetAsync<UsersResponseDto.Root>(string.Format(Constants.Users.GET_USER_BY_ID, userId), token);

    public Task<UsersResponseDto.Root> GetUsersAsync(CancellationToken token) =>
        GetAsync<UsersResponseDto.Root>(Constants.Users.GET_USERS, token);

    public Task<InvalidateJwtResponseDto.Root> InvalidateCurrentUserJwtAsync(CancellationToken token) =>
        PostAsync<InvalidateJwtResponseDto.Root>(Constants.Users.INVALIDATE_JWTS, token);

    public Task<UsersResponseDto.Root> PatchCurrentUserAsync(string userId, PatchUserRequestDto data, CancellationToken token) =>
        PatchAsync<PatchUserRequestDto, UsersResponseDto.Root>(data, string.Format(Constants.Users.PATCH_CURRENT_USER, userId), token);

    public Task<UsersResponseDto.Root> PatchUserAsync(string userId, PatchUserRequestDto data, CancellationToken token) =>
        PatchAsync<PatchUserRequestDto, UsersResponseDto.Root>(data, string.Format(Constants.Users.PATCH_USER, userId), token);
}
