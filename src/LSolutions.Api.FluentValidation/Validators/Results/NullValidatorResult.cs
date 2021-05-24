namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class NullValidatorResult : IValidatorResult
    {
        public NullValidatorResult()
        {
            Null = new string[0];
        }

        public string[] Null { get; set; }
    }
}