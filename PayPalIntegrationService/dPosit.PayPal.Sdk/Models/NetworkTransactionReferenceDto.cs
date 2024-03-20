using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class NetworkTransactionReferenceDto
{
    /// <summary>
    /// Transaction reference id returned by the scheme. For Visa and Amex, this is the "Tran id" field in response. For MasterCard, this
    /// is the "BankNet reference id" field in response. For Discover, this is the "NRID" field in response.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Name of the card network through which the transaction was routed.
    /// </summary>
    public CardBrand Network { get; set; }

    /// <summary>
    /// The date that the transaction was authorized by the scheme. For MasterCard, this is the "BankNet reference date" field in response.
    /// </summary>
    public string Date { get; set; }

    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(Id))
        {
            throw new PayPalModelValidationException<NetworkTransactionReferenceDto>("Id is required.");
        }

        if (Id.Length < 9 || Id.Length > 15)
        {
            throw new PayPalModelValidationException<NetworkTransactionReferenceDto>("Incorrect Id length.");
        }

        if (Network is CardBrand.None)
        {
            throw new PayPalModelValidationException<NetworkTransactionReferenceDto>("Network is required.");
        }

        if (Date is not null && Date.Length != 4)
        {
            throw new PayPalModelValidationException<NetworkTransactionReferenceDto>("Incorrect Date length.");
        }
    }

    internal NetworkTransactionReference ToRequestModel()
    {
        Validate();

        return new NetworkTransactionReference
        {
            Id = Id,
            Network = Network.GetStringValue(),
            Date = Date
        };
    }
}
