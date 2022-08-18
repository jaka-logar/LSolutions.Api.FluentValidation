namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class LessThanValidatorResult : IValidatorResult
    {
        public LessThanValidatorResult(string comparisonValue)
        {
            LessThan = new []{comparisonValue};
        }

        public string[] LessThan { get; set; }
    }
}
