namespace LSolutions.Api.FluentValidation.Validators.Results;

public class UniqueValidatorResult : IValidatorResult
{
    public string[] Unique { get; set; } = [];
}