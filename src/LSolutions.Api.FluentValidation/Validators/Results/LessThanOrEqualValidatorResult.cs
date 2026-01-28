namespace LSolutions.Api.FluentValidation.Validators.Results;

public class LessThanOrEqualValidatorResult(string comparisonValue) : IValidatorResult
{
    public string[] LessThanOrEqual { get; set; } = [comparisonValue];
}