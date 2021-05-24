namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class ValidValidatorResult : IValidatorResult
    {
        public ValidValidatorResult()
        {
            Valid = new string[0];
        }

        public string[] Valid { get; set; }
    }
}