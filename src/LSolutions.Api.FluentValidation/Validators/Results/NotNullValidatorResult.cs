namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class NotNullValidatorResult : IValidatorResult
    {
        public NotNullValidatorResult()
        {
            NotNull = new string[0];
        }

        public string[] NotNull { get; set; }
    }
}