using System.Collections.Generic;
using System.Linq;
using LSolutions.Api.FluentValidation.AspNetCore.Validators;
using LSolutions.Api.FluentValidation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LSolutions.Api.FluentValidation.AspNetCore.Controllers
{
    public abstract class BaseValidationApiController : ControllerBase
    {
        /// <summary>
        /// Common not found error
        /// </summary>
        /// <param name="errors">Array of errors</param>
        /// <returns></returns>
        protected virtual IActionResult NotFoundError(params string[] errors)
        {
            return NotFound(PrepareErrorModel(errors));
        }

        /// <summary>
        ///     Common bad request error
        /// </summary>
        /// <param name="errors">Array of errors</param>
        /// <returns></returns>
        protected virtual IActionResult BadRequestError(params string[] errors)
        {
            return BadRequest(PrepareErrorModel(errors));
        }

        /// <summary>
        ///     Common unauthorized error
        /// </summary>
        /// <param name="errors">Array of errors</param>
        /// <returns></returns>
        protected virtual IActionResult UnauthorizedError(params string[] errors)
        {
            return StatusCode(StatusCodes.Status401Unauthorized, PrepareErrorModel(errors));
        }

        /// <summary>
        ///     Common forbidden error
        /// </summary>
        /// <param name="errors">Array of errors</param>
        /// <returns></returns>
        protected virtual IActionResult ForbiddenError(params string[] errors)
        {
            return StatusCode(StatusCodes.Status403Forbidden, PrepareErrorModel(errors));
        }

        /// <summary>
        ///     Common internal server error
        /// </summary>
        /// <param name="errors">Array of errors</param>
        /// <returns></returns>
        protected virtual IActionResult InternalServerError(params string[] errors)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, PrepareErrorModel(errors));
        }

        /// <summary>
        ///     Common bad gateway error
        /// </summary>
        /// <param name="errors">Array of errors</param>
        /// <returns></returns>
        protected virtual IActionResult BadGatewayError(params string[] errors)
        {
            return StatusCode(StatusCodes.Status502BadGateway, PrepareErrorModel(errors));
        }

        protected virtual ErrorModel PrepareErrorModel(params string[] errors)
        {
            // Error model
            ErrorModel errorModel = new ErrorModel();
            if (errors != null && errors.Any())
            {
                errorModel.Errors.AddRange(errors);
            }

            // Model state errors
            IDictionary<string, object> modelStateErrors = ModelState.GetModelStateErrorPairs();
            if (modelStateErrors != null && modelStateErrors.Any())
            {
                errorModel.Fields = modelStateErrors;
            }

            return errorModel;
        }
    }
}
