using Newtonsoft.Json;

namespace LSolutions.Api.FluentValidation.Validators
{
    public static class SerializeExtensions
    {
        /// <summary>
        ///     Serialize object to json
        /// </summary>
        /// <param name="value">Object to serialize</param>
        /// <param name="settings">Custom serialization settings</param>
        /// <returns></returns>
        public static string ToJson(this object value, JsonSerializerSettings settings = null)
        {
            if (settings == null)
            {
                settings = JsonDefaultSettings.GetDefaultSettings();
            }

            if (value == null)
            {
                return string.Empty;
            }

            string result = JsonConvert.SerializeObject(value, settings);

            return result;
        }
    }
}
