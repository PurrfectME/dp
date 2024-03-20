using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PaymentMethodDto
{
    /// <summary>
    /// The merchant-preferred payment methods.
    /// </summary>
    public PaymentMethod PayeePreferred { get; set; }

    /// <summary>
    /// NACHA (the regulatory body governing the ACH network) requires that API callers (merchants, partners) obtain the consumer’s
    /// explicit authorization before initiating a transaction. To stay compliant, you’ll need to make sure that you retain a compliant
    /// authorization for each transaction that you originate to the ACH Network using this API. ACH transactions are categorized
    /// (using SEC codes) by how you capture authorization from the Receiver (the person whose bank account is being debited or credited).
    /// </summary>
    public SecCode StandardEntryClassCode { get; set; }

    internal Api.Models.PaymentMethod ToRequestModel()
    {
        return new Api.Models.PaymentMethod
        {
            PayeePreferred = PayeePreferred.GetStringValue(),
            StandardEntryClassCode = StandardEntryClassCode.GetStringValue()
        };
    }
}
