using dPosit.Http.Exceptions;
using dPosit.Http.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace dPosit.Http.Filters;

public class DPositApiExceptionFilterAttribute : ExceptionFilterAttribute
{
    private readonly ILogger<DPositApiExceptionFilterAttribute> _logger;

    public DPositApiExceptionFilterAttribute(ILogger<DPositApiExceptionFilterAttribute> logger)
    {
        _logger = logger;
    }

    public override void OnException(ExceptionContext context)
    {
        HandleException(context);

        base.OnException(context);
    }

    private void HandleException(ExceptionContext context)
    {
        var type = context.Exception.GetType();

        if (type == typeof(ValidationException))
        {
            HandleValidationException(context);
            return;
        }

        HandleUnknownException(context);
    }

    private void HandleValidationException(ExceptionContext context)
    {
        var exception = context.Exception as ValidationException;

        var errors = exception?.Errors
            .Select(errorObject => new ValidationErrorModel
            {
                FieldName = errorObject.Key,
                ErrorCodes = errorObject.Value
            })
            .ToArray();

        context.Result = new BadRequestObjectResult(errors);

        context.ExceptionHandled = true;
    }

    private void HandleUnknownException(ExceptionContext context)
    {
        _logger.LogError(context.Exception, "Unhandled exception during request processing");

        var details = new ProblemDetails
        {
            Status = StatusCodes.Status500InternalServerError,
            Title = "An error occurred while processing your request.",
            Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
        };

        context.Result = new ObjectResult(details)
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };

        context.ExceptionHandled = true;
    }
}

