namespace LSolutions.Api.FluentValidation.Validators.Results;

public class MaxLengthValidatorResult(string maxLength) : IValidatorResult
{
    public string[] MaxLength { get; set; } = [maxLength];
}