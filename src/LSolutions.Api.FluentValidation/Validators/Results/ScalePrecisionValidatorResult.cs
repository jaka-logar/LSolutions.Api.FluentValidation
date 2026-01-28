namespace LSolutions.Api.FluentValidation.Validators.Results;

public class ScalePrecisionValidatorResult(string expectedScale, string expectedPrecision) : IValidatorResult
{
    public string[] ScalePrecision { get; set; } = [expectedScale, expectedPrecision];
}