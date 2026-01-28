using System.Collections.Generic;

namespace LSolutions.Api.FluentValidation.Models;

/// <summary>
///     Standard error model
/// </summary>
public class ErrorModel
{
    /// <summary>
    ///     List of general errors
    /// </summary>
    public List<string> Errors { get; set; } = [];

    /// <summary>
    ///     List of fields errors
    /// </summary>
    public IDictionary<string, object> Fields { get; set; }
}