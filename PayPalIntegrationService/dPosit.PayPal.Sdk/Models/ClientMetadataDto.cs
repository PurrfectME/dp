namespace dPosit.PayPal.Sdk.Models;

public class ClientMetadataDto
{
    public string Name { get; set; }

    public string DisplayName { get; set; }

    public string LogoUri { get; set; }

    public string[] Scopes { get; set; }

    public string UiType { get; set; }
}
