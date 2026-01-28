namespace LSolutions.Api.FluentValidation.Validators.Results;

public class EmptyValidatorResult : IValidatorResult
{
    public string[] Empty { get; set; } = [];
}