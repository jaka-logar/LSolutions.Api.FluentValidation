namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class ExclusiveBetweenValidatorResult
    {
        public ExclusiveBetweenValidatorResult(string from, string to)
        {
            ExclusiveBetween = new []{from, to};
        }

        public string[] ExclusiveBetween { get; set; }
    }
}
