namespace LSolutions.Api.FluentValidation.Validators.Results;

public class EqualValidatorResult(string comparisonValue) : IValidatorResult
{
    public string[] Equal { get; set; } = [comparisonValue];
}