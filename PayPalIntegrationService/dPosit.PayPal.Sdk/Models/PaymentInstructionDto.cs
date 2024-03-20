using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PaymentInstructionDto
{
    /// <summary>
    /// The funds that are held payee by the marketplace/platform.
    /// </summary>
    /// <remarks>
    /// This field is only applicable to merchants that been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability.
    /// </remarks>
    public DisbursementMode DisbursementMode { get; set; }

    /// <summary>
    /// This field is only enabled for selected merchants/partners to use and provides the ability to trigger a specific pricing rate/plan
    /// for a payment transaction. The list of eligible 'payee_pricing_tier_id' would be provided to you by your Account Manager.
    /// Specifying values other than the one provided to you by your account manager would result in an error.
    /// </summary>
    public string PayeePricingTierId { get; set; }

    /// <summary>
    /// FX identifier generated returned by PayPal to be used for payment processing in order to honor FX rate (for eligible integrations)
    /// to be used when amount is settled/received into the payee account.
    /// </summary>
    public string PayeeReceivableFxRateId { get; set; }

    /// <summary>
    /// An array of various fees, commissions, tips, or donations.
    /// </summary>
    /// <remarks>
    /// This field is only applicable to merchants that been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability.
    /// </remarks>
    public PlatformFeeDto[] PlatformFees { get; set; }

    private void Validate()
    {
        if (PayeePricingTierId is not null && PayeePricingTierId.Length > 20)
        {
            throw new PayPalModelValidationException<PaymentInstructionDto>("Incorrect PayeePricingTierId lenght.");
        }

        if (PayeeReceivableFxRateId is not null && PayeeReceivableFxRateId.Length > 4000)
        {
            throw new PayPalModelValidationException<PaymentInstructionDto>("Incorrect PayeeReceivableFxRateId lenght.");
        }
    }

    internal PaymentInstruction ToRequestModel()
    {
        Validate();

        return new PaymentInstruction
        {
            DisbursementMode = DisbursementMode.GetStringValue(),
            PayeePricingTierId = PayeePricingTierId,
            PayeeReceivableFxRateId = PayeeReceivableFxRateId,
            PlatformFees = PlatformFees?.Select(platformFeeDto => platformFeeDto.ToRequestModel()).ToArray()
        };
    }

    internal static PaymentInstructionDto CreateFromModel(PaymentInstruction model)
    {
        if (model is null)
        {
            return null;
        }

        return new PaymentInstructionDto
        {
            DisbursementMode = Helpers.ParseDisbursementModeValue(model.DisbursementMode),
            PayeePricingTierId = model.PayeePricingTierId,
            PayeeReceivableFxRateId = model.PayeeReceivableFxRateId,
            PlatformFees = model.PlatformFees.Select(PlatformFeeDto.CreateFromModel).ToArray()
        };
    }
}
