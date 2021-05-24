namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class LessThanValidatorResult
    {
        public LessThanValidatorResult(string comparisonValue)
        {
            LessThan = new []{comparisonValue};
        }

        public string[] LessThan { get; set; }
    }
}
