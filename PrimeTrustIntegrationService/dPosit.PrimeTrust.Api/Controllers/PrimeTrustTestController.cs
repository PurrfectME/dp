using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace dPosit.Auth.Api.Controllers;

[Route("api/primeTrust/v2")]
[ApiController]
public class PrimeTrustController : ControllerBase
{
    private readonly IPrimeTrustAccountHttpClient _primeTrustClient;

    public PrimeTrustController(IPrimeTrustAccountHttpClient primeTrustAccountHttpClient)
    {
        _primeTrustClient = primeTrustAccountHttpClient;
    }

    [HttpPost("token")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> GetToken(UserLoginDto requestModel)
    {
        var token = await _primeTrustClient.GetJwt(requestModel);

        return Ok(token);
    }

    [HttpPost("transfer-funds")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> TransferFunds(AccountCashTransferRequestDto requestDto)
    {
        var cashTransferResponse = await _primeTrustClient.TrasnferFundsBetweenAccounts(requestDto);

        if (cashTransferResponse is null)
        {
            return BadRequest();
        }

        return Ok(cashTransferResponse);
    }

    [HttpPost("agreement-previews")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> PostAgreementPreviews(AgreementPreviewRequestDto requestDto)
    {
        var agreementPreviewResponse = await _primeTrustClient.PostAgreementPreviews(requestDto);

        if (agreementPreviewResponse is null)
        {
            return BadRequest();
        }

        return Ok(agreementPreviewResponse);
    }

    [HttpPost("account")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> CreateAccount(CreateAccountRequestDto requestDto)
    {
        var accountResponse = await _primeTrustClient.CreateAccount(requestDto);

        if (accountResponse is null)
        {
            return BadRequest();
        }

        return Ok(accountResponse);
    }

    [HttpPost("funds/{accountId}")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> AddFunds(string accountId, AddFundsRequestDto requestDto)
    {
        var accountResponse = await _primeTrustClient.AddFunds(accountId, requestDto);

        if (accountResponse is null)
        {
            return BadRequest();
        }

        return Ok(accountResponse);
    }

    [HttpPost("accounts/{accountId}/open")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> OpenAccount(string accountId)
    {
        var accountResponse = await _primeTrustClient.OpenAccount(accountId);

        if (accountResponse is null)
        {
            return BadRequest();
        }

        return Ok(accountResponse);
    }

    [HttpPost("funds-transfer")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> CreateFundsTransferMethod(CreateFundsTransferMethodRequestDto requestDto)
    {
        var accountResponse = await _primeTrustClient.CreateFundsTransferMethod(requestDto);

        if (accountResponse is null)
        {
            return BadRequest();
        }

        return Ok(accountResponse);
    }

    [HttpPost("disbursements")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> MakeWithdrawal(MakeDisbursementRequestDto requestDto)
    {
        var withdrawalResponse = await _primeTrustClient.MakeWithdrawal(requestDto);

        if (withdrawalResponse is null)
        {
            return BadRequest();
        }

        return Ok(withdrawalResponse);
    }

    [HttpPost("contact-transfer-reference")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> CreateContactTransferReference(CreateContactReferenceRequestDto requestDto)
    {
        var contactTransferReference = await _primeTrustClient.CreateContactTransferReference(requestDto);

        if (contactTransferReference is null)
        {
            return BadRequest();
        }

        return Ok(contactTransferReference);
    }

    [HttpPost("contribution")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> MakeContribution(MakeContributionRequestDto requestDto)
    {
        var contribution = await _primeTrustClient.MakeContribution(requestDto);

        if (contribution is null)
        {
            return BadRequest();
        }

        return Ok(contribution);
    }

    [HttpPost("deposits/track/{fundsTransferId}")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> TrackDeposit(string fundsTransferId)
    {
        var trackingResponse = await _primeTrustClient.TrackDeposit(fundsTransferId);

        if (trackingResponse is null)
        {
            return BadRequest();
        }

        return Ok(trackingResponse);
    }

    [HttpGet("contingent-holds/{contingentHoldId}")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> GetContingentHold(string contingentHoldId)
    {
        var contingentHold = await _primeTrustClient.GetContingentHold(contingentHoldId);

        if (contingentHold is null)
        {
            return BadRequest();
        }

        return Ok(contingentHold);
    }

    [HttpPost("assets/deposit")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> DepositAsset(AssetTransferMethodsRequestDto requestDto)
    {
        var assetTransferMethod = await _primeTrustClient.DepositAsset(requestDto);

        if (assetTransferMethod is null)
        {
            return BadRequest();
        }

        return Ok(assetTransferMethod);
    }

    [HttpPost("assets/track")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> TrackAsset(AssetContributionRequestDto requestDto)
    {
        var assetContribution = await _primeTrustClient.TrackAsset(requestDto);

        if (assetContribution is null)
        {
            return BadRequest();
        }

        return Ok(assetContribution);
    }

    [HttpPost("assets-transfer/settle/{assetTransferId}")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> SettleAssetTransfers(string assetTransferId)
    {
        var assetTransferResponse = await _primeTrustClient.SettleAssetTransfers(assetTransferId);

        if (assetTransferResponse is null)
        {
            return BadRequest();
        }

        return Ok(assetTransferResponse);
    }

    [HttpPost("accounts-assets-transfer")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> TransferAssetsBetweenAccounts(InternalAssetTransfersRequestDto internalAsset)
    {
        var transferResponse = await _primeTrustClient.TransferAssetsBetweenAccounts(internalAsset);

        if (transferResponse is null)
        {
            return BadRequest();
        }

        return Ok(transferResponse);
    }

    [HttpPost("assets/withdraw")]
    //TODO: use own api models then map them to infrastructure models
    public async Task<IActionResult> WithdrawAssets(WithdrawAssetRequestDto asset)
    {
        var withdrawalResposne = await _primeTrustClient.WithdrawAssets(asset);

        if (withdrawalResposne is null)
        {
            return BadRequest();
        }

        return Ok(withdrawalResposne);
    }
}
