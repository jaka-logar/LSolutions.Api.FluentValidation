using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Resources;
using LSolutions.Api.FluentValidation.Validators;
using LSolutions.Api.FluentValidation.Validators.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace LSolutions.Api.FluentValidation.AspNetCore.Validators
{
    public static class ValidatorExtensions
    {
        /// <summary>
        ///     Get ModelState errors in list
        /// </summary>
        /// <param name="modelStateDictionary">Model state dictionary</param>
        /// <returns>List of errors</returns>
        public static IList<string> GetModelStateErrors(this ModelStateDictionary modelStateDictionary)
        {
            List<string> errors = new List<string>();
            foreach (ModelStateEntry modelState in modelStateDictionary.Values.Where(x => x.Errors.Count > 0))
            {
                errors.AddRange(modelState.Errors.Select(error => error.ErrorMessage));
            }

            errors = errors.Distinct().ToList();

            return errors;
        }

        /// <summary>
        ///     Get ModelState errors with keys in list
        /// </summary>
        /// <param name="modelStateDictionary">Model state dictionary</param>
        /// <returns>List of errors</returns>
        public static IDictionary<string, object> GetModelStateErrorPairs(this ModelStateDictionary modelStateDictionary)
        {
            IDictionary<string, object> errors = new Dictionary<string, object>();

            if (modelStateDictionary.ErrorCount > 0)
            {
                foreach (string key in modelStateDictionary.Keys)
                {
                    if (modelStateDictionary[key].Errors.Count > 0)
                    {
                        Dictionary<object, object> test = new Dictionary<object, object>();

                        foreach (ModelError modelError in modelStateDictionary[key].Errors)
                        {
                            Dictionary<string, object> deserializeError = JsonSerializer.Deserialize<Dictionary<string, object>>(modelError.ErrorMessage);

                            if (deserializeError != null)
                            {
                                foreach (KeyValuePair<string, object> pair in deserializeError)
                                {
                                    test.Add(pair.Key, pair.Value);
                                }
                            }
                        }

                        errors.Add(key, test);
                    }
                }
            }

            return errors;
        }

        /// <summary>
        /// Add model error value in JSON format
        /// </summary>
        /// <param name="modelStateDictionary">Model state dictionary</param>
        /// <param name="key">Key</param>
        /// <param name="value">Value object</param>
        public static void AddModelErrorJson(this ModelStateDictionary modelStateDictionary, string key, IValidatorResult value)
        {
            modelStateDictionary.AddModelError(key, value.ToJson());
        }

        /// <summary>
        ///     Add API fluent validation validators
        /// </summary>
        /// <param name="builder">MVC builder</param>
        /// <param name="cultureInfo">Culture info; Default: en</param>
        /// <param name="languageManager">Language manager; Default: <see cref="ApiEnglishLanguageManager"/></param>
        /// <param name="runDefaultMvcValidationAfterFluentValidationExecutes">
        ///     Whether to run MVC's default validation process (including DataAnnotations) after FluentValidation is executed. True by default.</param>
        /// <param name="implicitlyValidateChildProperties">
        ///     Whether or not child properties should be implicitly validated if a matching validator can be found.
        ///     By default this is false, and you should wire up child validators using SetValidator.</param>
        /// <returns></returns>
        public static IMvcBuilder AddApiFluentValidationValidators(this IMvcBuilder builder, CultureInfo cultureInfo = null, LanguageManager languageManager = null,
            bool runDefaultMvcValidationAfterFluentValidationExecutes = true, bool implicitlyValidateChildProperties = false)
        {
            // https://fluentvalidation.net/localization
            ValidatorOptions.Global.LanguageManager.Culture = cultureInfo ?? new CultureInfo("en");
            ValidatorOptions.Global.LanguageManager = languageManager ?? new ApiEnglishLanguageManager();

            builder.AddFluentValidation(fv =>
            {
                // Register fluent validation as only validation library that executes
                fv.RunDefaultMvcValidationAfterFluentValidationExecutes = runDefaultMvcValidationAfterFluentValidationExecutes;

                fv.ImplicitlyValidateChildProperties = implicitlyValidateChildProperties;
            });

            return builder;
        }

        /// <summary>
        ///     Add API fluent validation validators
        /// </summary>
        /// <typeparam name="T">Assembly type to register validators from</typeparam>
        /// <param name="builder">MVC builder</param>
        /// <param name="cultureInfo">Culture info; Default: en</param>
        /// <param name="languageManager">Language manager; Default: <see cref="ApiEnglishLanguageManager"/></param>
        /// <param name="runDefaultMvcValidationAfterFluentValidationExecutes">
        ///     Whether to run MVC's default validation process (including DataAnnotations) after FluentValidation is executed. True by default.</param>
        /// <param name="implicitlyValidateChildProperties">
        ///     Whether or not child properties should be implicitly validated if a matching validator can be found.
        ///     By default this is false, and you should wire up child validators using SetValidator.</param>
        /// <returns></returns>
        public static IMvcBuilder AddApiFluentValidationValidators<T>(this IMvcBuilder builder, CultureInfo cultureInfo = null, LanguageManager languageManager = null,
            bool runDefaultMvcValidationAfterFluentValidationExecutes = true, bool implicitlyValidateChildProperties = false)
        {
            // https://fluentvalidation.net/localization
            ValidatorOptions.Global.LanguageManager.Culture = cultureInfo ?? new CultureInfo("en");
            ValidatorOptions.Global.LanguageManager = languageManager ?? new ApiEnglishLanguageManager();

            builder.AddFluentValidation(fv =>
            {
                // Register fluent validation as only validation library that executes
                fv.RunDefaultMvcValidationAfterFluentValidationExecutes = runDefaultMvcValidationAfterFluentValidationExecutes;

                fv.ImplicitlyValidateChildProperties = implicitlyValidateChildProperties;
                
                fv.RegisterValidatorsFromAssemblyContaining<T>();
            });

            return builder;
        }
    }
}
