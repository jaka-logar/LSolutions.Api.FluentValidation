namespace LSolutions.Api.FluentValidation.Validators.Results;

public class EnumValidatorResult : IValidatorResult
{
    public string[] IsInEnum { get; set; } = [];
}