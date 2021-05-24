namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class GreaterThanOrEqualValidatorResult
    {
        public GreaterThanOrEqualValidatorResult(string comparisonValue)
        {
            GreaterThanOrEqual = new []{comparisonValue};
        }

        public string[] GreaterThanOrEqual { get; set; }
    }
}
