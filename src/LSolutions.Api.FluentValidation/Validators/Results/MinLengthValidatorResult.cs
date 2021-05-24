namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class MinLengthValidatorResult
    {
        public MinLengthValidatorResult(string minLength)
        {
            MinLength = new[] { minLength };
        }

        public string[] MinLength { get; set; }
    }
}
