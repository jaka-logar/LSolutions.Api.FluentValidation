using System.Collections.Generic;
using LSolutions.Api.FluentValidation.AspNetCore.Validators;
using LSolutions.Api.FluentValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LSolutions.Api.FluentValidation.AspNetCore.Filters;

public class ValidateModelActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            // Model state errors
            IDictionary<string, object> modelStateErrors = context.ModelState.GetModelStateErrorPairs();

            ErrorModel errorModel = new()
            {
                Fields = modelStateErrors
            };

            context.Result = new BadRequestObjectResult(errorModel);
        }
    }

    public void OnActionExecuted(ActionExecutedContext context) { }
}