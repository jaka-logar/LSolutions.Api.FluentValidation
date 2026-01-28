namespace LSolutions.Api.FluentValidation.Validators.Results;

public class NotNullValidatorResult : IValidatorResult
{
    public string[] NotNull { get; set; } = [];
}