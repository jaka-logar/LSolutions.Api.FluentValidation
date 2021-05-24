namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class EmailValidatorResult : IValidatorResult
    {
        public EmailValidatorResult()
        {
            Email = new string[0];
        }

        public string[] Email { get; set; }
    }
}
