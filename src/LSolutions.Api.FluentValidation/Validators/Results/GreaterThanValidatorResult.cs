namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class GreaterThanValidatorResult
    {
        public GreaterThanValidatorResult(string comparisonValue)
        {
            GreaterThan = new []{comparisonValue};
        }

        public string[] GreaterThan { get; set; }
    }
}
