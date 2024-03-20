using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public class ProcessorResponseDto
{
    /// <summary>
    /// The address verification code for Visa, Discover, Mastercard, or American Express transactions.
    /// </summary>
    public AvsCode AvsCode { get; set; }

    /// <summary>
    /// The card verification value code for for Visa, Discover, Mastercard, or American Express.
    /// </summary>
    public CvvCode CvvCode { get; set; }

    /// <summary>
    /// The declined payment transactions might have payment advice codes. The card networks, like Visa and Mastercard, return payment
    /// advice codes.
    /// </summary>
    public PaymentAdviceCode PaymentAdviceCode { get; set; }

    /// <summary>
    /// Processor response code for the non-PayPal payment processor errors.
    /// </summary>
    public ProcessorResponseCode ResponseCode { get; set; }

    internal static ProcessorResponseDto CreateFromModel(ProcessorResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ProcessorResponseDto
        {
            AvsCode = Helpers.ParseAvsCodeValue(model.AvsCode),
            CvvCode = Helpers.ParseCvvCodeValue(model.CvvCode),
            PaymentAdviceCode = Helpers.ParsePaymentAdviceCodeValue(model.PaymentAdviceCode),
            ResponseCode = Helpers.ParseProcessorResponseCodeValue(model.ResponseCode)
        };
    }
}
