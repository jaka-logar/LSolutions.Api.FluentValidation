namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class MaxLengthValidatorResult : IValidatorResult
    {
        public MaxLengthValidatorResult(string maxLength)
        {
            MaxLength = new[] { maxLength };
        }

        public string[] MaxLength { get; set; }
    }
}
