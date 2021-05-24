# LSolutions.Api.FluentValidation

Custom FluentValidation translations for most built-in validators.
BaseValidationApiController implemented with common error responses. Return ErrorModel with ModelState fields errors and with array of custom errors.


[![Build status](https://ci.appveyor.com/api/projects/status/k9ingemp8kl2yfkg?svg=true)](https://ci.appveyor.com/project/jaka-logar/lsolutions-api-fluentvalidation)
[![contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/jaka-logar/LSolutions.Api.FluentValidation/issues)

Packed as two NuGet packages. Core project with translations and AspNetCore project:
- LSolutions.Api.FluentValidation [![NuGet](https://img.shields.io/nuget/v/LSolutions.Api.FluentValidation.svg)](https://www.nuget.org/packages/LSolutions.Api.FluentValidation/)
- LSolutions.Api.FluentValidation.AspNetCore [![NuGet](https://img.shields.io/nuget/v/LSolutions.Api.FluentValidation.AspNetCore.svg)](https://www.nuget.org/packages/LSolutions.Api.FluentValidation.AspNetCore/)


## Usage

1. Add code below in your Startup.cs
```csharp
    public void ConfigureServices(IServiceCollection services)
	{
		services
			.AddControllers(configure =>
			{
				configure.Filters.Add(typeof(ValidateModelActionFilter));
			})

			// Fluent validation
			.AddApiFluentValidationValidators<Startup>(runDefaultMvcValidationAfterFluentValidationExecutes: false, implicitlyValidateChildProperties: true);
	}
```

2. Extend ApiEnglishLanguageManager with translations for your custom validators. 
