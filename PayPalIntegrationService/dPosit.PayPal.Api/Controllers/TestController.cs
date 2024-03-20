using Microsoft.AspNetCore.Mvc;
using dPosit.PayPal.Sdk;
using dPosit.PayPal.Sdk.Clients.Authorization;
using dPosit.PayPal.Sdk.Clients.Orders;
using dPosit.PayPal.Sdk.Clients.Payments;
using dPosit.PayPal.Sdk.Clients.TransactionSearch;
using dPosit.PayPal.Sdk.Models;
using dPosit.PayPal.Sdk.RequestModels.Authorization;
using dPosit.PayPal.Sdk.RequestModels.Orders;
using dPosit.PayPal.Sdk.RequestModels.Payments;
using dPosit.PayPal.Sdk.RequestModels.TransactionSearch;
using dPosit.PayPal.Sdk.ResponseModels.Authorization;
using dPosit.PayPal.Sdk.ResponseModels.Orders;
using dPosit.PayPal.Sdk.ResponseModels.Payments;
using dPosit.PayPal.Sdk.ResponseModels.TransactionSearch;

namespace dPosit.PayPal.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TestController : ControllerBase
{
    private readonly IPayPalAuthorizationClient _payPalAuthorizationClient;
    private readonly IPayPalOrdersClient _palPalOrdersClient;
    private readonly IPayPalPaymentsClient _payPalPaymentsClient;
    private readonly IPayPalTransactionSearchClient _payPalTransactionSearchClient;

    public TestController(
        IPayPalAuthorizationClient payPalAuthorizationClient,
        IPayPalOrdersClient payPalPalOrdersClient,
        IPayPalPaymentsClient payPalPaymentsClient,
        IPayPalTransactionSearchClient payPalTransactionSearchClient)
    {
        _payPalAuthorizationClient = payPalAuthorizationClient;
        _palPalOrdersClient = payPalPalOrdersClient;
        _payPalPaymentsClient = payPalPaymentsClient;
        _payPalTransactionSearchClient = payPalTransactionSearchClient;
    }

    [HttpGet("generate-access-token")]
    public async Task<ActionResult<GenerateAccessTokenResponseDto>> GenerateAccessToken(CancellationToken cancellationToken)
    {
        var request = new GenerateAccessTokenRequestDto
        {
            GrantType = GrantType.ClientCredentials,
            IgnoreCache = true,
            ReturnAuthnSchemes = true,
            ReturnClientMetadata = true,
            ReturnUnconsentedScopes = false
        };
        var response = await _payPalAuthorizationClient.GenerateAccessTokenAsync(request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("terminate-access-token")]
    public async Task<IActionResult> TerminateAccessToken(string jwt, CancellationToken cancellationToken)
    {
        var request = new TerminateAccessTokenRequestDto
        {
            Token = jwt,
            TokenTypeHint = TokenTypeHint.AccessToken,
            GrantType = GrantType.ClientCredentials,
        };
        await _payPalAuthorizationClient.TerminateAccessTokenAsync(request, cancellationToken);

        return Ok();
    }

    [HttpGet("user-info")]
    public async Task<ActionResult<GetUserInfoRequestDto>> UserInfo(string jwt, CancellationToken cancellationToken)
    {
        var request = new GetUserInfoRequestDto
        {
            Jwt = jwt
        };
        var response = await _payPalAuthorizationClient.UserInfoAsync(request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("generate-client-token")]
    public async Task<ActionResult<GetUserInfoRequestDto>> GenerateClientToken(string jwt, string customerId, CancellationToken cancellationToken)
    {
        var request = new GenerateClientTokenRequestDto
        {
            Jwt = jwt,
            CustomerId = customerId
        };

        var response = await _payPalAuthorizationClient.GenerateClientTokenAsync(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("create-order")]
    public async Task<ActionResult<CreateOrderResponseDto>> CreateOrder(string jwt, CancellationToken cancellationToken)
    {
        var request = new CreateOrderRequestDto
        {
            Jwt = jwt,
            Intent = Intent.Capture,
            PurchaseUnits = new[]
            {
                new PurchaseUnitRequestDto
                {
                    Amount = new AmountWithBreakdownDto
                    {
                        Currency = Currency.UnitedStatesDollar,
                        Value = "100.00"
                    }
                }
            }
        };

        var response = await _palPalOrdersClient.CreateOrderAsync(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("update-order")]
    public async Task<IActionResult> UpdateOrder(string jwt, string orderId, CancellationToken cancellationToken)
    {
        var request = new UpdateOrderRequestDto
        {
            Jwt = jwt,
            PatchRequest = new PatchDto<object>[]
            {
                new()
                {
                    Operation = PatchOperation.Add,
                    Path = "/purchase_units/@reference_id=='default'/description",
                    Value = "Test description"
                }
            }
        };

        await _palPalOrdersClient.UpdateOrderAsync(orderId, request, cancellationToken);

        return Ok();
    }

    [HttpGet("show-order-details")]
    public async Task<ActionResult<ShowOrderDetailsResponseDto>> ShowOrderDetails(
        string jwt,
        string orderId,
        CancellationToken cancellationToken)
    {
        var request = new ShowOrderDetailsRequestDto
        {
            Jwt = jwt
        };

        var response = await _palPalOrdersClient.ShowOrderDetailsAsync(orderId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("authorize-payment-for-order")]
    public async Task<ActionResult<AuthorizePaymentForOrderResponseDto>> AuthorizePaymentForOrder(
        string jwt,
        string orderId,
        CancellationToken cancellationToken)
    {
        var request = new AuthorizePaymentForOrderRequestDto
        {
            Jwt = jwt
        };

        var response = await _palPalOrdersClient.AuthorizePaymentForOrderAsync(orderId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("capture-payment-for-order")]
    public async Task<ActionResult<AuthorizePaymentForOrderResponseDto>> CapturePaymentForOrder(
        string jwt,
        string orderId,
        CancellationToken cancellationToken)
    {
        var request = new CapturePaymentForOrderRequestDto
        {
            Jwt = jwt
        };

        var response = await _palPalOrdersClient.CapturePaymentForOrderAsync(orderId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("confirm-order")]
    public async Task<ActionResult<ConfirmOrderResponseDto>> ConfirmOrder(
        ConfirmOrderRequestDto request,
        string orderId,
        CancellationToken cancellationToken)
    {
        var response = await _palPalOrdersClient.ConfirmOrder(orderId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("show-details-for-authorized-payment")]
    public async Task<ActionResult<ShowDetailsForAuthorizedPaymentResponseDto>> ShowDetailsForAuthorizedPayment(
        string jwt,
        string orderId,
        CancellationToken cancellationToken)
    {
        var request = new ShowDetailsForAuthorizedPaymentRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalPaymentsClient.ShowDetailsForAuthorizedPaymentAsync(orderId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("capture-authorized-payment")]
    public async Task<ActionResult<CaptureAuthorizedPaymentResponseDto>> CaptureAuthorizedPayment(
        string jwt,
        string authorizationId,
        CancellationToken cancellationToken)
    {
        var request = new CaptureAuthorizedPaymentRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalPaymentsClient.CaptureAuthorizedPaymentAsync(authorizationId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("reauthorize-authorized-payment")]
    public async Task<ActionResult<ReauthorizeAuthorizedPaymentResponseDto>> ReauthorizeAuthorizedPayment(
        string jwt,
        string authorizationId,
        CancellationToken cancellationToken)
    {
        var request = new ReauthorizeAuthorizedPaymentRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalPaymentsClient.ReauthorizeAuthorizedPaymentAsync(authorizationId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("void-authorized-payment")]
    public async Task<IActionResult> VoidAuthorizedPayment(
        string jwt,
        string authorizationId,
        CancellationToken cancellationToken)
    {
        var request = new VoidAuthorizedPaymentRequestDto
        {
            Jwt = jwt
        };

        await _payPalPaymentsClient.VoidAuthorizedPaymentAsync(authorizationId, request, cancellationToken);

        return Ok();
    }

    [HttpGet("show-captured-payment-details")]
    public async Task<ActionResult<ShowCapturedPaymentDetailsResponseDto>> ShowCapturedPaymentDetails(
        string jwt,
        string captureId,
        CancellationToken cancellationToken)
    {
        var request = new ShowCapturedPaymentDetailsRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalPaymentsClient.ShowCapturedPaymentDetailsAsync(captureId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("refund-captured-payment")]
    public async Task<ActionResult<RefundCapturedPaymentResponseDto>> RefundCapturedPayment(
        string jwt,
        string captureId,
        CancellationToken cancellationToken)
    {
        var request = new RefundCapturedPaymentRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalPaymentsClient.RefundCapturedPaymentAsync(captureId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("show-refund-details")]
    public async Task<ActionResult<ShowRefundDetailsResponseDto>> ShowRefundDetails(
        string jwt,
        string refundId,
        CancellationToken cancellationToken)
    {
        var request = new ShowRefundDetailsRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalPaymentsClient.ShowRefundDetailsAsync(refundId, request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("list-transactions")]
    public async Task<ActionResult<ListTransactionsResponseDto>> ListTransactions(
        string jwt,
        CancellationToken cancellationToken)
    {
        var request = new ListTransactionsRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalTransactionSearchClient.ListTransactionsAsync(request, cancellationToken);

        return Ok(response);
    }

    [HttpGet("list-all-balances")]
    public async Task<ActionResult<ListAllBalancesResponseDto>> ListAllBalances(
        string jwt,
        CancellationToken cancellationToken)
    {
        var request = new ListAllBalancesRequestDto
        {
            Jwt = jwt
        };

        var response = await _payPalTransactionSearchClient.ListAllBalancesAsync(request, cancellationToken);

        return Ok(response);
    }
}
