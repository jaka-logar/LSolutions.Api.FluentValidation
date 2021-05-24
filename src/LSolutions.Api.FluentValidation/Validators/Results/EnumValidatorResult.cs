namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class EnumValidatorResult : IValidatorResult
    {
        public EnumValidatorResult()
        {
            IsInEnum = new string[0];
        }

        public string[] IsInEnum { get; set; }
    }
}