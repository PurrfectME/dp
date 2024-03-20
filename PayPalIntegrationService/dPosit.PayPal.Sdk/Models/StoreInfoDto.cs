using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class StoreInfoDto
{
    /// <summary>
    /// The ID of a store for a merchant in the system of record.
    /// </summary>
    public string StoreId { get; set; }

    /// <summary>
    /// The terminal ID for the checkout stand in a merchant store.
    /// </summary>
    public string TerminalId { get; set; }

    internal static StoreInfoDto CreateFromModel(StoreInfo model)
    {
        if (model is null)
        {
            return null;
        }

        return new StoreInfoDto
        {
            StoreId = model.StoreId,
            TerminalId = model.TerminalId
        };
    }
}
