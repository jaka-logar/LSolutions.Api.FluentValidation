namespace LSolutions.Api.FluentValidation.Validators.Results;

public class ExclusiveBetweenValidatorResult(string from, string to) : IValidatorResult
{
    public string[] ExclusiveBetween { get; set; } = [from, to];
}