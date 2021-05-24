namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class NotFoundValidatorResult : IValidatorResult
    {
        public NotFoundValidatorResult()
        {
            NotFound = new string[0];
        }

        public string[] NotFound { get; set; }
    }
}
