using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class CaptureDto
{
    /// <summary>
    /// The status of the captured payment.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// The details of the captured payment status.
    /// </summary>
    public CaptureStatusDetailsDto StatusDetails { get; set; }

    /// <summary>
    /// The amount for this captured payment.
    /// </summary>
    public MoneyDto Amount { get; set; }

    /// <summary>
    /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in
    /// transaction and settlement reports.
    /// </summary>
    public string CustomId { get; set; }

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    public DisbursementMode DisbursementMode { get; set; }

    /// <summary>
    /// Indicates whether you can make additional captures against the authorized payment.
    /// </summary>
    /// <value>
    /// <c>true</c> - if you do not intend to capture additional payments against the authorization.<br/>
    /// <c>false</c> - if you intend to capture additional payments against the authorization.
    /// </value>
    public bool? FinalCapture { get; set; }

    /// <summary>
    /// The PayPal-generated ID for the captured payment.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that
    /// the payer receives.
    /// </summary>
    public string InvoiceId { get; set; }

    /// <summary>
    /// An array of related HATEOAS links.
    /// </summary>
    public LinkDescriptionDto[] Links { get; set; }

    /// <summary>
    /// An object that provides additional processor information for a direct credit card transaction.
    /// </summary>
    public ProcessorResponseDto ProcessorResponse { get; set; }

    /// <summary>
    /// The level of protection offered as defined by PayPal Seller Protection for Merchants.
    /// </summary>
    public SellerProtectionDto SellerProtection { get; set; }

    /// <summary>
    /// The detailed breakdown of the capture activity. This is not available for transactions that are in pending state.
    /// </summary>
    public SellerReceivableBreakdownDto SellerReceivableBreakdown { get; set; }

    /// <summary>
    /// The date and time when the transaction occurred, in Internet date and time format. Seconds are required while fractional seconds
    /// are optional.
    /// </summary>
    public DateTimeOffset CreateTime { get; set; }

    /// <summary>
    /// The date and time when the transaction was last updated, in Internet date and time format. Seconds are required while fractional
    /// seconds are optional.
    /// </summary>
    public DateTimeOffset UpdateTime { get; set; }

    internal static CaptureDto CreateFromModel(Capture model)
    {
        if (model is null)
        {
            return null;
        }

        return new CaptureDto
        {
            Status = model.Status,
            StatusDetails = CaptureStatusDetailsDto.CreateFromModel(model.StatusDetails),
            Amount = MoneyDto.CreateFromModel(model.Amount),
            CustomId = model.CustomId,
            DisbursementMode = Helpers.ParseDisbursementModeValue(model.DisbursementMode),
            FinalCapture = model.FinalCapture,
            Id = model.Id,
            InvoiceId = model.InvoiceId,
            Links = model.Links?.Select(LinkDescriptionDto.CreateFromModel).ToArray(),
            ProcessorResponse = ProcessorResponseDto.CreateFromModel(model.ProcessorResponse),
            SellerProtection = SellerProtectionDto.CreateFromModel(model.SellerProtection),
            SellerReceivableBreakdown = SellerReceivableBreakdownDto.CreateFromModel(model.SellerReceivableBreakdown),
            CreateTime = DateTimeOffset.Parse(model.CreateTime),
            UpdateTime = DateTimeOffset.Parse(model.UpdateTime)
        };
    }
}
