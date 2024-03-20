using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using dPosit.Http.Helpers;
using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateAccessToken;
using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateClientToken;
using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.TerminateAccessToken;
using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.UserInfo;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.AuthorizePaymentForOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.CapturePaymentForOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.ConfirmOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.CreateOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.ShowOrderDetails;
using dPosit.PayPal.Sdk.Api.Endpoints.Orders.UpdateOrder;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.CaptureAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ReauthorizeAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.RefundCapturedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowCapturedPaymentDetails;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowDetailsForAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowRefundDetails;
using dPosit.PayPal.Sdk.Api.Endpoints.Payments.VoidAuthorizedPayment;
using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListAllBalances;
using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListTransactions;
using dPosit.PayPal.Sdk.Extensions;
using Microsoft.Extensions.Options;

namespace dPosit.PayPal.Sdk.Api;

internal sealed class PayPalHttpClient : IPayPalHttpClient
{
    private readonly HttpClient _httpClient;
    private readonly PayPalOptions _payPalOptions;

    public PayPalHttpClient(HttpClient httpClient, IOptions<PayPalOptions> options)
    {
        _httpClient = httpClient;
        _payPalOptions = options.Value;

        ArgumentNullException.ThrowIfNull(options.Value.ApiBaseUri);
        ArgumentNullException.ThrowIfNull(options.Value.Credentials);

        _httpClient.BaseAddress = new Uri(options.Value.ApiBaseUri);

        _httpClient.DefaultRequestHeaders.Add("User-Agent", "dPosit/V0.1");
        _httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
    }

    public async Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(
        GenerateAccessTokenRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(Constants.Routes.Authorization.GENERATE_ACCESS_TOKEN)
            .AddPayPalBasicAuthentication(_payPalOptions.Credentials)
            .AddFormUrlEncodedContent(request.ToKeyValuePairCollection())
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Throw exception or pass errors to caller.
            var responseError = response.StatusCode switch
            {
                HttpStatusCode.BadRequest =>
                    await response.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken: cancellationToken),
                HttpStatusCode.Unauthorized =>
                    await response.Content.ReadFromJsonAsync<GenerateAccessTokenErrorResponse>(cancellationToken: cancellationToken),
                _ => throw new Exception() // TODO: Implement proper handling of unexpected http status code..
            };
        }

        return await response.Content.ReadFromJsonAsync<GenerateAccessTokenResponse>(cancellationToken: cancellationToken);
    }

    public async Task TerminateAccessTokenAsync(TerminateAccessTokenRequest request, CancellationToken cancellationToken = default)
    {
        var httpMessageBuilder = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(Constants.Routes.Authorization.TERMINATE_ACCESS_TOKEN)
            .AddFormUrlEncodedContent(request.ToKeyValuePairCollection());

        if (request.GrantType is Constants.GrantType.CLIENT_CREDENTIALS)
        {
            httpMessageBuilder.AddPayPalBasicAuthentication(_payPalOptions.Credentials);
        }

        if (!string.IsNullOrWhiteSpace(request.Jwt))
        {
            httpMessageBuilder.AddBearerAuthentication(request.Jwt);
        }

        var httpMessage = httpMessageBuilder.Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code..
            throw new Exception();
        }
    }

    public async Task<UserInfoResponse> UserInfoAsync(UserInfoRequest request, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, string>
        {
            {
                "schema",
                request.Schema
            }
        };

        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(Constants.Routes.Authorization.USER_INFO, queryParams)
            .AddBearerAuthentication(request.Jwt)
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Throw exception or pass errors to caller.
            var responseError = response.StatusCode switch
            {
                HttpStatusCode.BadRequest =>
                    await response.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken: cancellationToken),
                HttpStatusCode.Unauthorized =>
                    await response.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken: cancellationToken),
                _ => throw new Exception() // TODO: Implement proper handling of unexpected http status code..
            };
        }

        return await response.Content.ReadFromJsonAsync<UserInfoResponse>(cancellationToken: cancellationToken);
    }

    public async Task<GenerateClientTokenResponse> GenerateClientTokenAsync(
        GenerateClientTokenRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(Constants.Routes.Authorization.GENERATE_CLIENT_TOKEN)
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request)
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code..
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<GenerateClientTokenResponse>(cancellationToken: cancellationToken);
    }

    public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request, CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(Constants.Routes.Orders.CREATE_ORDER)
            .AddBearerAuthentication(request.Jwt)
            .AddHeader("Prefer", "return=representation")
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code..
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<CreateOrderResponse>(cancellationToken: cancellationToken);
    }

    public async Task UpdateOrderAsync(string orderId, UpdateOrderRequest request, CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Patch)
            .UseUrl(string.Format(Constants.Routes.Orders.UPDATE_ORDER, orderId))
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request.PatchRequest, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code..
            throw new Exception();
        }
    }

    public async Task<ShowOrderDetailsResponse> ShowOrderDetailsAsync(
        string orderId,
        ShowOrderDetailsRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(string.Format(Constants.Routes.Orders.SHOW_ORDER_DETAILS, orderId))
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code..
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ShowOrderDetailsResponse>(cancellationToken: cancellationToken);
    }

    public async Task<AuthorizePaymentForOrderResponse> AuthorizePaymentForOrderAsync(
        string orderId,
        AuthorizePaymentForOrderRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(Constants.Routes.Orders.AUTHORIZE_PAYMENT_FOR_ORDER, orderId))
            .AddBearerAuthentication(request.Jwt)
            .AddHeader("Prefer", "return=representation")
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code..
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<AuthorizePaymentForOrderResponse>(cancellationToken: cancellationToken);
    }

    public async Task<CapturePaymentForOrderResponse> CapturePaymentForOrderAsync(
        string orderId,
        CapturePaymentForOrderRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(Constants.Routes.Orders.CAPTURE_PAYMENT_FOR_ORDER, orderId))
            .AddBearerAuthentication(request.Jwt)
            .AddHeader("Prefer", "return=representation")
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<CapturePaymentForOrderResponse>(cancellationToken: cancellationToken);
    }

    public async Task<ConfirmOrderResponse> ConfirmOrderAsync(
        string orderId,
        ConfirmOrderRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(Constants.Routes.Orders.CONFIRM_ORDER, orderId))
            .AddBearerAuthentication(request.Jwt)
            .AddHeader("Prefer", "return=representation")
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ConfirmOrderResponse>(cancellationToken: cancellationToken);
    }

    public async Task<ShowDetailsForAuthorizedPaymentResponse> ShowDetailsForAuthorizedPaymentAsync(
        string authorizationId,
        ShowDetailsForAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(string.Format(Constants.Routes.Payments.SHOW_DETAILS_FOR_AUTHORIZED_PAYMENT, authorizationId))
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ShowDetailsForAuthorizedPaymentResponse>(cancellationToken: cancellationToken);
    }

    public async Task<CaptureAuthorizedPaymentResponse> CaptureAuthorizedPaymentAsync(
        string authorizationId,
        CaptureAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(Constants.Routes.Payments.CAPTURE_AUTHORIZED_PAYMENT, authorizationId))
            .AddBearerAuthentication(request.Jwt)
            .AddHeader("Prefer", "return=representation")
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<CaptureAuthorizedPaymentResponse>(cancellationToken: cancellationToken);
    }

    public async Task<ReauthorizeAuthorizedPaymentResponse> ReauthorizeAuthorizedPaymentAsync(
        string authorizationId,
        ReauthorizeAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(Constants.Routes.Payments.REAUTHORIZE_AUTHORIZED_PAYMENT, authorizationId))
            .AddBearerAuthentication(request.Jwt)
            .AddHeader("Prefer", "return=representation")
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ReauthorizeAuthorizedPaymentResponse>(cancellationToken: cancellationToken);
    }

    public async Task VoidAuthorizedPaymentAsync(
        string authorizationId,
        VoidAuthorizedPaymentRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(Constants.Routes.Payments.VOID_AUTHORIZED_PAYMENT, authorizationId))
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }
    }

    public async Task<ShowCapturedPaymentDetailsResponse> ShowCapturedPaymentDetailsAsync(
        string captureId,
        ShowCapturedPaymentDetailsRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(string.Format(Constants.Routes.Payments.SHOW_CAPTURED_PAYMENT_DETAILS, captureId))
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ShowCapturedPaymentDetailsResponse>(cancellationToken: cancellationToken);
    }

    public async Task<RefundCapturedPaymentResponse> RefundCapturedPaymentAsync(
        string captureId,
        RefundCapturedPaymentRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(Constants.Routes.Payments.REFUND_CAPTURED_PAYMENT, captureId))
            .AddBearerAuthentication(request.Jwt)
            .AddHeader("Prefer", "return=representation")
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<RefundCapturedPaymentResponse>(cancellationToken: cancellationToken);
    }

    public async Task<ShowRefundDetailsResponse> ShowRefundDetailsAsync(
        string refundId,
        ShowRefundDetailsRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(string.Format(Constants.Routes.Payments.SHOW_REFUND_DETAILS, refundId))
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ShowRefundDetailsResponse>(cancellationToken: cancellationToken);
    }

    public async Task<ListTransactionsResponse> ListTransactionsAsync(
        ListTransactionsRequest request,
        CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(Constants.Routes.TransactionSearch.LIST_TRANSACTIONS, request.ToQueryParams())
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ListTransactionsResponse>(cancellationToken: cancellationToken);
    }

    public async Task<ListAllBalancesResponse> ListAllBalancesAsync(ListAllBalancesRequest request, CancellationToken cancellationToken = default)
    {
        var httpMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(Constants.Routes.TransactionSearch.LIST_ALL_BALANCES, request.ToQueryParams())
            .AddBearerAuthentication(request.Jwt)
            .AddJsonContent(request, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })
            .Build();

        var response = await _httpClient.SendAsync(httpMessage, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            // TODO: Implement proper handling of unexpected http status code.
            throw new Exception();
        }

        return await response.Content.ReadFromJsonAsync<ListAllBalancesResponse>(cancellationToken: cancellationToken);
    }
}
