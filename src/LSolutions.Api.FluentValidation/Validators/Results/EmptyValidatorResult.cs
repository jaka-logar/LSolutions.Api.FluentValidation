namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class EmptyValidatorResult : IValidatorResult
    {
        public EmptyValidatorResult()
        {
            Empty = new string[0];
        }

        public string[] Empty { get; set; }
    }
}
