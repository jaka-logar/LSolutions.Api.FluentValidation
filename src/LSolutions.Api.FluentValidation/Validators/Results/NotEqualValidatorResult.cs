namespace LSolutions.Api.FluentValidation.Validators.Results;

public class NotEqualValidatorResult(string comparisonValue) : IValidatorResult
{
    public string[] NotEqual { get; set; } = [comparisonValue];
}