using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowRefundDetails;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.Payments;

public sealed class ShowRefundDetailsResponseDto
{
    /// <summary>
    /// The amount that the payee refunded to the payer.
    /// </summary>
    public MoneyDto Amount { get; set; }

    /// <summary>
    /// The date and time when the transaction occurred, in Internet date and time format. Seconds are required while fractional seconds
    /// are optional.
    /// </summary>
    public DateTimeOffset CreateTime { get; set; }

    /// <summary>
    /// The PayPal-generated ID for the refund.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails
    /// that the payer receives.
    /// </summary>
    public string InvoiceId { get; set; }

    /// <summary>
    /// An array of related HATEOAS links.
    /// </summary>
    public LinkDescriptionDto[] Links { get; set; }

    /// <summary>
    /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    public string NoteToPayer { get; set; }

    /// <summary>
    /// The breakdown of the refund.
    /// </summary>
    public SellerPayableBreakdownDto SellerPayableBreakdown { get; set; }

    /// <summary>
    /// The status of the refund.
    /// </summary>
    public RefundStatus Status { get; set; }

    /// <summary>
    /// The details of the refund status.
    /// </summary>
    public RefundStatusDetailsDto StatusDetails { get; set; }

    /// <summary>
    /// The date and time when the transaction was last updated, in Internet date and time format. Seconds are required while fractional
    /// seconds are optional.
    /// </summary>
    public DateTimeOffset UpdateTime { get; set; }

    internal static ShowRefundDetailsResponseDto CreateFromModel(ShowRefundDetailsResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ShowRefundDetailsResponseDto
        {
            Amount = MoneyDto.CreateFromModel(model.Amount),
            CreateTime = DateTimeOffset.Parse(model.CreateTime),
            Id = model.Id,
            InvoiceId = model.InvoiceId,
            Links = model.Links?.Select(LinkDescriptionDto.CreateFromModel).ToArray(),
            NoteToPayer = model.NoteToPayer,
            SellerPayableBreakdown = SellerPayableBreakdownDto.CreateFromModel(model.SellerPayableBreakdown),
            Status = Helpers.ParseRefundStatusValue(model.Status),
            StatusDetails = RefundStatusDetailsDto.CreateFromModel(model.StatusDetails),
            UpdateTime = DateTimeOffset.Parse(model.UpdateTime)
        };
    }
}
