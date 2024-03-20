using dPosit.PayPal.Sdk.Api;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.RequestModels.Authorization;
using dPosit.PayPal.Sdk.ResponseModels.Authorization;
using Microsoft.Extensions.Options;

namespace dPosit.PayPal.Sdk.Clients.Authorization;

public sealed class PayPalAuthorizationClient : IPayPalAuthorizationClient
{
    private readonly IPayPalHttpClient _payPalHttpClient;

    public PayPalAuthorizationClient(HttpClient httpClient, IOptions<PayPalOptions> options)
    {
        _payPalHttpClient = new PayPalHttpClient(httpClient, options);
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<GenerateAccessTokenResponseDto> GenerateAccessTokenAsync(
        GenerateAccessTokenRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.GenerateAccessTokenAsync(requestModel, cancellationToken);

        var responseDto = GenerateAccessTokenResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public Task TerminateAccessTokenAsync(TerminateAccessTokenRequestDto requestDto, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        return _payPalHttpClient.TerminateAccessTokenAsync(requestModel, cancellationToken);
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<GetUserInfoResponseDto> UserInfoAsync(GetUserInfoRequestDto requestDto, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.UserInfoAsync(requestModel, cancellationToken);

        var responseDto = GetUserInfoResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }

    /// <exception cref="PayPalModelValidationException">Validation exception for incorrect requestDto.</exception>
    public async Task<GenerateClientTokenResponseDto> GenerateClientTokenAsync(
        GenerateClientTokenRequestDto requestDto,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(requestDto);

        var requestModel = requestDto.ToRequestModel();

        var responseModel = await _payPalHttpClient.GenerateClientTokenAsync(requestModel, cancellationToken);

        var responseDto = GenerateClientTokenResponseDto.CreateFromModel(responseModel);
        return responseDto;
    }
}
