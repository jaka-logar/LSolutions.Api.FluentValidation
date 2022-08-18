namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class NotEqualValidatorResult : IValidatorResult
    {
        public NotEqualValidatorResult(string comparisonValue)
        {
            NotEqual = new []{comparisonValue};
        }

        public string[] NotEqual { get; set; }
    }
}
