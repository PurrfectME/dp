using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using dPosit.Http.Helpers;
using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.RequestModels;
using dPosit.PrimeTrust.Sdk.ResponseModels;

namespace dPosit.PrimeTrust.Sdk.HttpClients;

public class PrimeTrustAccountHttpClient : IPrimeTrustAccountHttpClient
{
    //todo: create strategy to choose between prod and sandbox
    //TODO: move urls from client
    private const string POST_CREATE_USER = "v2/users";
    private const string POST_JWT_URL = "auth/jwts";
    private const string TRANSFER_FUNDS_URL = "v2/account-cash-transfers?include=from-account-cash-totals,to-account-cash-totals";
    private const string POST_AGREEMENT_PREVIEW = "v2/agreement-previews";
    private const string CREATE_ACCOUNT = "v2/accounts?include=latest-agreement,account-type,webhook-config";
    private const string ADD_FUNDS_URL = "v2/accounts/{0}/sandbox/fund";
    private const string OPEN_ACCOUNT_URL = "v2/accounts/{0}/sandbox/open";
    private const string CREATE_FUNDS_TRANSFER_METHOD_URL = "v2/funds-transfer-methods?include=bank";
    private const string MAKE_WITHDRAWAL_URL = "v2/disbursements?include=funds-transfer,disbursement-authorization";
    private const string CREATE_CONTACT_REFERENCE_URL = "v2/contact-funds-transfer-references";
    private const string MAKE_CONTRIBUTION_URL = "v2/contributions?include=funds-transfer";
    private const string TRACK_DEPOSIT_URL = "v2/funds-transfers/{0}/sandbox/settle";
    private const string CONTINGENT_HOLDS_URL = "v2/contingent-holds/{0}/sandbox/clear";
    private const string DEPOSIT_ASSET_URL = "v2/asset-transfer-methods";
    private const string ASSET_CONTRIBUTION_URL = "v2/asset-contributions?include=asset-transfer-method,asset-transfer";
    private const string ASSET_TRANSFERS_URL = "v2/asset-transfers/{0}/sandbox/settle";
    private const string INTERNAL_ASSET_TRANSFERS_URL = "v2/internal-asset-transfers";
    private const string WITHDRAW_ASSETS_URL = "v2/asset-disbursements?include=asset-transfer-method,asset-transfer";
    private const string GET_ASSET_TRANSFERS_URL = "v2/asset-transfers?include=disbursement-authorizations";
    private const string DISBURSEMENT_AUTHORIZATIONS_URL = "v2/disbursement-authorizations/{0}/sandbox/verify-owner";

    private static readonly Uri _baseUrl = new("https://sandbox.primetrust.com");

    private readonly HttpClient _httpClient;

    //TODO: add dependency registration
    public PrimeTrustAccountHttpClient()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = _baseUrl
        };
        _httpClient.DefaultRequestHeaders.Add("X-Idempotent-ID-V2", Guid.NewGuid().ToString());
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "dPosit/V0.1");
        _httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
        _httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
    }

    public async Task<dynamic> CreateUserAsync(string userEmail, string userName, string userPassword)
    {
        var uri = new Uri(_baseUrl, POST_CREATE_USER);
        var requestModel = new PrimeTrustCreateUserRequestDto.Root();
        requestModel.Data = new PrimeTrustCreateUserRequestDto.Data();
        requestModel.Data.Type = "user";
        requestModel.Data.Attributes = new PrimeTrustCreateUserRequestDto.Attributes()
        {
            Email = userEmail,
            Name = userName,
            Password = userPassword
        };

        var json = JsonSerializer.Serialize(requestModel);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(uri, data);

        response.EnsureSuccessStatusCode();

        return JsonSerializer.Deserialize<dynamic>(await response.Content.ReadAsStringAsync());
    }

    public async Task<AgreementPreviewResponseDto> PostAgreementPreviews(AgreementPreviewRequestDto agreementDto)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(POST_AGREEMENT_PREVIEW)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(agreementDto)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<AgreementPreviewResponseDto>(responseBody)!;
    }

    public async Task<string> GetJwt(UserLoginDto loginDtoModel)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(POST_JWT_URL)
            .AddBasicAuthentication(loginDtoModel.UserName, loginDtoModel.Password)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<JwtResponseDto>(responseBody)!;

        return $"Bearer {result.Token}";
    }

    public async Task<AccountCashTransferResponseDto> TrasnferFundsBetweenAccounts(AccountCashTransferRequestDto accountCashTransferDto)
    {
        var response = await _httpClient.PostAsJsonAsync(TRANSFER_FUNDS_URL, accountCashTransferDto);

        response.EnsureSuccessStatusCode();

        //check for null
        return JsonSerializer.Deserialize<AccountCashTransferResponseDto>(await response.Content.ReadAsStringAsync());
    }

    public async Task<CreateAccountResponseDto> CreateAccount(CreateAccountRequestDto createAccountDto)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(CREATE_ACCOUNT)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(createAccountDto)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();


        response.EnsureSuccessStatusCode();

        //check for null
        return JsonSerializer.Deserialize<CreateAccountResponseDto>(responseBody);
    }

    public async Task<AddFundsResponseDto> AddFunds(string accountId, AddFundsRequestDto addFundsDto)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(ADD_FUNDS_URL, accountId))
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(addFundsDto)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<AddFundsResponseDto>(responseBody)!;
    }

    public async Task<OpenAccountResponseDto> OpenAccount(string accountId)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(OPEN_ACCOUNT_URL, accountId))
            .AddBearerAuthentication("GET_FROM_STORE")
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<OpenAccountResponseDto>(responseBody)!;
    }

    public async Task<CreateFundsTransferMethodResponseDto.Root> CreateFundsTransferMethod(CreateFundsTransferMethodRequestDto createFundsMethod)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(CREATE_FUNDS_TRANSFER_METHOD_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(createFundsMethod)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<CreateFundsTransferMethodResponseDto.Root>(responseBody)!;
    }

    public async Task<MakeDisbursementResponseDto.Root> MakeWithdrawal(MakeDisbursementRequestDto withdrawalDto)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(MAKE_WITHDRAWAL_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(withdrawalDto)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<MakeDisbursementResponseDto.Root>(responseBody)!;
    }

    public async Task<ContactReferenceResponseDto.Root> CreateContactTransferReference(CreateContactReferenceRequestDto wireDepositFunds)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(CREATE_CONTACT_REFERENCE_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(wireDepositFunds)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<ContactReferenceResponseDto.Root>(responseBody)!;
    }

    public async Task<MakeContributionResponseDto.Root> MakeContribution(MakeContributionRequestDto contribution)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(MAKE_CONTRIBUTION_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(contribution)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<MakeContributionResponseDto.Root>(responseBody)!;
    }

    public async Task<TrackDepositResponseDto.Root> TrackDeposit(string fundsTransferId)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(TRACK_DEPOSIT_URL, fundsTransferId))
            .AddBearerAuthentication("GET_FROM_STORE")
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<TrackDepositResponseDto.Root>(responseBody)!;
    }

    public async Task<ContingentHoldsResponseDto.Root> GetContingentHold(string contingentHoldId)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(string.Format(CONTINGENT_HOLDS_URL, contingentHoldId))
            .AddBearerAuthentication("GET_FROM_STORE")
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<ContingentHoldsResponseDto.Root>(responseBody)!;
    }

    public async Task<AssetTransferMethodsResponseDto.Root> DepositAsset(AssetTransferMethodsRequestDto assetTransfer)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(DEPOSIT_ASSET_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(assetTransfer)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<AssetTransferMethodsResponseDto.Root>(responseBody)!;
    }

    public async Task<AssetContributionResponseDto.Root> TrackAsset(AssetContributionRequestDto assetContribution)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(ASSET_CONTRIBUTION_URL)
            .AddJsonContent(assetContribution)
            .AddBearerAuthentication("GET_FROM_STORE")
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<AssetContributionResponseDto.Root>(responseBody)!;
    }

    public async Task<AssetTransfersResponseDto.Root> SettleAssetTransfers(string assetTransferId)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(ASSET_TRANSFERS_URL, assetTransferId))
            .AddBearerAuthentication("GET_FROM_STORE")
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<AssetTransfersResponseDto.Root>(responseBody)!;
    }

    public async Task<InternalAssetTransfersResponseDto.Root> TransferAssetsBetweenAccounts(InternalAssetTransfersRequestDto assetToTransfer)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(INTERNAL_ASSET_TRANSFERS_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(assetToTransfer)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<InternalAssetTransfersResponseDto.Root>(responseBody)!;
    }

    public async Task<WithdrawAssetResponseDto.Root> WithdrawAssets(WithdrawAssetRequestDto withdrawAsset)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(WITHDRAW_ASSETS_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .AddJsonContent(withdrawAsset)
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<WithdrawAssetResponseDto.Root>(responseBody)!;
    }

    public async Task<TrackAssetTransfersResponseDto.Root> TrackAssetTransfers()
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Get)
            .UseUrl(GET_ASSET_TRANSFERS_URL)
            .AddBearerAuthentication("GET_FROM_STORE")
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<TrackAssetTransfersResponseDto.Root>(responseBody)!;
    }

    public async Task<DisbursementAuthorizationsResponseDto.Root> GetDisbursementAuthorizations(string disbursementAuthorizationAssetId)
    {
        var requestMessage = new HttpRequestMessageBuilder()
            .UseMethod(HttpMethod.Post)
            .UseUrl(string.Format(DISBURSEMENT_AUTHORIZATIONS_URL, disbursementAuthorizationAssetId))
            .AddBearerAuthentication("GET_FROM_STORE")
            .Build();

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        //check for null
        return JsonSerializer.Deserialize<DisbursementAuthorizationsResponseDto.Root>(responseBody)!;
    }
}
