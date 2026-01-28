namespace LSolutions.Api.FluentValidation.Validators.Results;

public class NotEmptyValidatorResult : IValidatorResult
{
    public string[] NotEmpty { get; set; } = [];
}