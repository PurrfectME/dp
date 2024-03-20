using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PatchDto<T>
{
    /// <summary>
    /// The operation.
    /// </summary>
    public PatchOperation Operation { get; set; }

    /// <summary>
    /// The JSON Pointer to the target document location from which to move the value. Required for the <c>move</c> operation.
    /// </summary>
    public string From { get; set; }

    /// <summary>
    /// The JSON Pointer to the target document location at which to complete the operation.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// The value to apply. The <c>remove</c> operation does not require a value.
    /// </summary>
    /// <value>Supported types: number, integer, string, boolean, null, array, object</value>
    public T Value { get; set; }

    private void Validate()
    {
        if (Operation is PatchOperation.None)
        {
            throw new PayPalModelValidationException<PatchDto<T>>("Operation is required.");
        }

        if (Operation is PatchOperation.Move && string.IsNullOrWhiteSpace(From))
        {
            throw new PayPalModelValidationException<PatchDto<T>>("From is required for PatchOperation.Move.");
        }

        if (Value is null && Operation != PatchOperation.Remove)
        {
            throw new PayPalModelValidationException<PatchDto<T>>("Value is required.");
        }
    }

    internal Patch<T> ToRequestModel()
    {
        Validate();

        return new Patch<T>
        {
            Operation = Operation.GetStringValue(),
            From = From,
            Path = Path,
            Value = Value
        };
    }
}
