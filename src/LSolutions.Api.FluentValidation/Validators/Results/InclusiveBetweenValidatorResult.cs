namespace LSolutions.Api.FluentValidation.Validators.Results
{
    public class InclusiveBetweenValidatorResult
    {
        public InclusiveBetweenValidatorResult(string from, string to)
        {
            InclusiveBetween = new []{from, to};
        }

        public string[] InclusiveBetween { get; set; }
    }
}
