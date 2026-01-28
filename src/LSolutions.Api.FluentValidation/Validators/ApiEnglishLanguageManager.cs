using FluentValidation.Resources;
using LSolutions.Api.FluentValidation.Validators.Results;

namespace LSolutions.Api.FluentValidation.Validators;

/// <summary>
///     Custom API translation to get generic validation errors
/// </summary>
public class ApiEnglishLanguageManager : LanguageManager
{
    public ApiEnglishLanguageManager()
    {
        AddTranslation("en", "NotNullValidator", new NotNullValidatorResult().ToJson());
        AddTranslation("en", "NotEmptyValidator", new NotEmptyValidatorResult().ToJson());
        AddTranslation("en", "NotEqualValidator", new NotEqualValidatorResult("{ComparisonValue}").ToJson());
        AddTranslation("en", "EqualValidator", new EqualValidatorResult("{ComparisonValue}").ToJson());
        AddTranslation("en", "LengthValidator", new LengthValidatorResult("{MinLength}", "{MaxLength}").ToJson());
        AddTranslation("en", "MaximumLengthValidator", new MaxLengthValidatorResult("{MaxLength}").ToJson());
        AddTranslation("en", "MinimumLengthValidator", new MinLengthValidatorResult("{MinLength}").ToJson());
        AddTranslation("en", "LessThanValidator", new LessThanValidatorResult("{ComparisonValue}").ToJson());
        AddTranslation("en", "LessThanOrEqualToValidator", new LessThanOrEqualValidatorResult("{ComparisonValue}").ToJson());
        AddTranslation("en", "GreaterThanValidator", new GreaterThanValidatorResult("{ComparisonValue}").ToJson());
        AddTranslation("en", "GreaterThanOrEqualToValidator", new GreaterThanOrEqualValidatorResult("{ComparisonValue}").ToJson());
        AddTranslation("en", "EmailValidator", new EmailValidatorResult().ToJson());
        AddTranslation("en", "EnumValidator", new EnumValidatorResult().ToJson());
        AddTranslation("en", "EnumNameValidator", new EnumNameValidatorResult().ToJson());
        AddTranslation("en", "EmptyValidator", new EmptyValidatorResult().ToJson());
        AddTranslation("en", "NullValidator", new NullValidatorResult().ToJson());
        AddTranslation("en", "ExclusiveBetweenValidator", new ExclusiveBetweenValidatorResult("{From}", "{To}").ToJson());
        AddTranslation("en", "InclusiveBetweenValidator", new InclusiveBetweenValidatorResult("{From}", "{To}").ToJson());
        AddTranslation("en", "ScalePrecisionValidator", new ScalePrecisionValidatorResult("{ExpectedScale}","{ExpectedPrecision}").ToJson());
    }
}