namespace LSolutions.Api.FluentValidation.Validators.Results;

public class GreaterThanOrEqualValidatorResult(string comparisonValue) : IValidatorResult
{
    public string[] GreaterThanOrEqual { get; set; } = [comparisonValue];
}