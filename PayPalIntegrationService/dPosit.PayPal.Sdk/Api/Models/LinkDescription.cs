﻿using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class LinkDescription
{
    /// <summary>
    /// The complete target URL. To make the related call, combine the method with this URI Template-formatted link. For pre-processing,
    /// include the <c>$</c>, <c>(</c>, and <c>)</c> characters. The <c>href</c> is the key HATEOAS component that links a completed call
    /// with a subsequent call.
    /// </summary>
    [JsonPropertyName("href")]
    public string Href { get; set; }

    /// <summary>
    /// The link relation type, which serves as an ID for a link that unambiguously describes the semantics of the link.
    /// </summary>
    [JsonPropertyName("rel")]
    public string Type { get; set; }

    /// <summary>
    /// The HTTP method required to make the related call.
    /// </summary>
    /// <value>
    /// "GET", "POST", "PUT", "DELETE", "HEAD", "CONNECT", "OPTIONS", "PATCH".
    /// </value>
    [JsonPropertyName("method")]
    public string Method { get; set; }
}
