namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class UniqueValidatorResult : IValidatorResult
    {
        public UniqueValidatorResult()
        {
            Unique = new string[0];
        }

        public string[] Unique { get; set; }
    }
}
