using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PayerInfoDto
{
    /// <summary>
    /// The PayPal` customer account ID.
    /// </summary>
    public string AccountId { get; set; }

    /// <summary>
    /// The payer address.
    /// </summary>
    public AddressDto Address { get; set; }

    /// <summary>
    /// The address status of the payer.
    /// </summary>
    /// <value>
    /// "Y" - Verified.
    /// "N" - Not verified.
    /// </value>
    public string AddressStatus { get; set; }

    /// <summary>
    /// The country or region.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// The email address of the payer.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// The payer name.
    /// </summary>
    public NameDto PayerName { get; set; }

    /// <summary>
    /// The status of the payer.
    /// </summary>
    public PayerStatus PayerStatus { get; set; }

    /// <summary>
    /// The primary phone number of the payer.
    /// </summary>
    public PhoneNumberDto PhoneNumber { get; set; }

    internal static PayerInfoDto CreateFromModel(PayerInfo model)
    {
        if (model is null)
        {
            return null;
        }

        return new PayerInfoDto
        {
            AccountId = model.AccountId,
            Address = AddressDto.CreateFromModel(model.Address),
            AddressStatus = model.AddressStatus,
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            EmailAddress = model.EmailAddress,
            PayerName = NameDto.CreateFromModel(model.PayerName),
            PayerStatus = Helpers.ParsePayerStatusValue(model.PayerStatus),
            PhoneNumber = PhoneNumberDto.CreateFromModel(model.PhoneNumber)
        };
    }
}
