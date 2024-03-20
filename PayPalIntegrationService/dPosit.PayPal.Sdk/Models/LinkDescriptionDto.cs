using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class LinkDescriptionDto
{
    /// <summary>
    /// The complete target URL. To make the related call, combine the method with this URI Template-formatted link. For pre-processing,
    /// include the <c>$</c>, <c>(</c>, and <c>)</c> characters. The <c>href</c> is the key HATEOAS component that links a completed call
    /// with a subsequent call.
    /// </summary>
    public string Href { get; set; }

    /// <summary>
    /// The link relation type, which serves as an ID for a link that unambiguously describes the semantics of the link.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// The HTTP method required to make the related call.
    /// </summary>
    public HttpMethod Method { get; set; }

    internal static LinkDescriptionDto CreateFromModel(LinkDescription model)
    {
        if (model is null)
        {
            return null;
        }

        return new LinkDescriptionDto
        {
            Href = model.Href,
            Type = model.Type,
            Method = Helpers.ParseHttpMethodValue(model.Method)
        };
    }
}
