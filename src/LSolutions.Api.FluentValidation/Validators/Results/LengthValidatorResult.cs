namespace LSolutions.Api.FluentValidation.Validators.Results;

public class LengthValidatorResult(string minLength, string maxLength) : IValidatorResult
{
    public string[] Length { get; set; } = [minLength, maxLength];
}