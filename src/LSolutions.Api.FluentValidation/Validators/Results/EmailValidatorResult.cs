namespace LSolutions.Api.FluentValidation.Validators.Results;

public class EmailValidatorResult : IValidatorResult
{
    public string[] Email { get; set; } = [];
}