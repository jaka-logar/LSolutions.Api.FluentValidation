namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class NotEmptyValidatorResult : IValidatorResult
    {
        public NotEmptyValidatorResult()
        {
            NotEmpty = new string[0];
        }

        public string[] NotEmpty { get; set; }
    }
}