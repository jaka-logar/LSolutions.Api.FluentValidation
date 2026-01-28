namespace LSolutions.Api.FluentValidation.Validators.Results;

public class NotFoundValidatorResult : IValidatorResult
{
    public string[] NotFound { get; set; } = [];
}