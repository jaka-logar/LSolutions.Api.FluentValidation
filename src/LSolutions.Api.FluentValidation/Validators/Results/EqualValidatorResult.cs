namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class EqualValidatorResult
    {
        public EqualValidatorResult(string comparisonValue)
        {
            Equal = new []{comparisonValue};
        }

        public string[] Equal { get; set; }
    }
}
