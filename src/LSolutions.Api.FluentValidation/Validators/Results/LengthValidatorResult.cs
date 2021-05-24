namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class LengthValidatorResult : IValidatorResult
    {
        public LengthValidatorResult(string minLength, string maxLength)
        {
            Length = new []{minLength, maxLength};
        }

        public string[] Length { get; set; }
    }
}
