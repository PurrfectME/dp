﻿using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api;

internal class ErrorResponse
{
    [JsonPropertyName("error")]
    public string Error { get; set; }

    [JsonPropertyName("error_description")]
    public string ErrorDescription { get; set; }
}
