namespace LSolutions.Api.FluentValidation.Validators.Results;

public class GreaterThanValidatorResult(string comparisonValue) : IValidatorResult
{
    public string[] GreaterThan { get; set; } = [comparisonValue];
}