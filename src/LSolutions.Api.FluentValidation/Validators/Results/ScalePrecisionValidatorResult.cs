namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class ScalePrecisionValidatorResult
    {
        public ScalePrecisionValidatorResult(string expectedScale, string expectedPrecision)
        {
            ScalePrecision = new []{expectedScale, expectedPrecision};
        }

        public string[] ScalePrecision { get; set; }
    }
}
