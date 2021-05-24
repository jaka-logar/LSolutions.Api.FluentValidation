namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class LessThanOrEqualValidatorResult
    {
        public LessThanOrEqualValidatorResult(string comparisonValue)
        {
            LessThanOrEqual = new []{comparisonValue};
        }

        public string[] LessThanOrEqual { get; set; }
    }
}
