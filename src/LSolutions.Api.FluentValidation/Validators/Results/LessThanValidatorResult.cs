namespace LSolutions.Api.FluentValidation.Validators.Results;

public class LessThanValidatorResult(string comparisonValue) : IValidatorResult
{
    public string[] LessThan { get; set; } = [comparisonValue];
}