using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PlatformFeeDto
{
    /// <summary>
    /// The fee for this transaction.
    /// </summary>
    public MoneyDto Amount { get; set; }

    /// <summary>
    /// The recipient of the fee for this transaction. If you omit this value, the default is the API caller.
    /// </summary>
    public PayeeDto Payee { get; set; }

    private void Validate()
    {
        if (Amount is null)
        {
            throw new PayPalModelValidationException<PlatformFeeDto>("Amount is required.");
        }
    }

    internal PlatformFee ToRequestModel()
    {
        Validate();

        return new PlatformFee
        {
            Amount = Amount.ToRequestModel(),
            Payee = Payee?.ToRequestModel()
        };
    }

    internal static PlatformFeeDto CreateFromModel(PlatformFee model)
    {
        if (model is null)
        {
            return null;
        }

        return new PlatformFeeDto
        {
            Amount = MoneyDto.CreateFromModel(model.Amount),
            Payee = PayeeDto.CraeteFromModel(model.Payee)
        };
    }
}
