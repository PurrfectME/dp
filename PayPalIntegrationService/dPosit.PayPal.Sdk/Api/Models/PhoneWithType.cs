using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PhoneWithType
{
    /// <summary>
    /// The phone number, in its canonical international E.164 numbering plan format. Supports only the <c>national_number</c> property.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// The phone type.
    /// </summary>
    /// <value>
    /// "FAX" - a fax machine.<br/>
    /// "HOME" - a home phone.<br/>
    /// "MOBILE" - a mobile phone.<br/>
    /// "OTHER" - other.<br/>
    /// "PAGER" - a pager.<br/>
    /// "WORK" - a work phone.
    /// </value>
    [JsonPropertyName("phone_type")]
    public string PhoneType { get; set; }
}
