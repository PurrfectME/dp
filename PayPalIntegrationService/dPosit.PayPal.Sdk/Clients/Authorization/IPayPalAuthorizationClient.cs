using dPosit.PayPal.Sdk.RequestModels.Authorization;
using dPosit.PayPal.Sdk.ResponseModels.Authorization;

namespace dPosit.PayPal.Sdk.Clients.Authorization;

public interface IPayPalAuthorizationClient
{
    Task<GenerateAccessTokenResponseDto> GenerateAccessTokenAsync(
        GenerateAccessTokenRequestDto requestDto,
        CancellationToken cancellationToken = default);

    Task TerminateAccessTokenAsync(TerminateAccessTokenRequestDto requestDto, CancellationToken cancellationToken = default);

    Task<GetUserInfoResponseDto> UserInfoAsync(GetUserInfoRequestDto requestDto, CancellationToken cancellationToken = default);

    Task<GenerateClientTokenResponseDto> GenerateClientTokenAsync(
        GenerateClientTokenRequestDto requestDto,
        CancellationToken cancellationToken = default);
}
