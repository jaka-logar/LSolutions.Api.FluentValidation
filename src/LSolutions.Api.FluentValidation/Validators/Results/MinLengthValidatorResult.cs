namespace LSolutions.Api.FluentValidation.Validators.Results;

public class MinLengthValidatorResult(string minLength) : IValidatorResult
{
    public string[] MinLength { get; set; } = [minLength];
}