using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LSolutions.Api.FluentValidation;

public static class JsonDefaultSettings
{
    public static JsonSerializerSettings GetDefaultSettings(bool processDictionaryKeys = true)
    {
        return new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Include,
            Formatting = Formatting.Indented,

            ContractResolver = new DefaultContractResolver 
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    ProcessDictionaryKeys = processDictionaryKeys
                }
            }
        };
    }
}