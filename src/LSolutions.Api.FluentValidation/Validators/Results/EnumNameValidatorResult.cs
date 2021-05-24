namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class EnumNameValidatorResult
    {
        public EnumNameValidatorResult()
        {
            IsEnumName = new string[0];
        }

        public string[] IsEnumName { get; set; }
    }
}