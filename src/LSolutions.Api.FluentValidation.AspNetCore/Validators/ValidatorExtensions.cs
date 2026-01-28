using System.Collections.Generic;
using System.Linq;
using LSolutions.Api.FluentValidation.Validators;
using LSolutions.Api.FluentValidation.Validators.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace LSolutions.Api.FluentValidation.AspNetCore.Validators;

public static class ValidatorExtensions
{
    /// <summary>
    ///     Get ModelState errors in list
    /// </summary>
    /// <param name="modelStateDictionary">Model state dictionary</param>
    /// <returns>List of errors</returns>
    public static IList<string> GetModelStateErrors(this ModelStateDictionary modelStateDictionary)
    {
        List<string> errors = [];
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
                    Dictionary<string, object> deserializeErrorDictionary = new();

                    foreach (ModelError modelError in modelStateDictionary[key].Errors)
                    {
                        Dictionary<string, object> deserializeError = JsonConvert.DeserializeObject<Dictionary<string, object>>(
                            modelError.ErrorMessage, JsonDefaultSettings.GetDefaultSettings());

                        if (deserializeError != null)
                        {
                            foreach (KeyValuePair<string, object> pair in deserializeError)
                            {
                                deserializeErrorDictionary.TryAdd(pair.Key, pair.Value);
                            }
                        }
                    }

                    errors.TryAdd(key, deserializeErrorDictionary);
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
}