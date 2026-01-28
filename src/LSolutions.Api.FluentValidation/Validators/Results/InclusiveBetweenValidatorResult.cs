namespace LSolutions.Api.FluentValidation.Validators.Results;

public class InclusiveBetweenValidatorResult(string from, string to) : IValidatorResult
{
    public string[] InclusiveBetween { get; set; } = [from, to];
}