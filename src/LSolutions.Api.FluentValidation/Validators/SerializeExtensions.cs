using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace LSolutions.Api.FluentValidation.Validators
{
    public static class SerializeExtensions
    {
        /// <summary>
        ///     Serialize object to json
        /// </summary>
        /// <typeparam name="T">Type of object to serialize</typeparam>
        /// <param name="value">Object to serialize</param>
        /// <returns></returns>
        public static string ToJson<T>(this T value)
        {
            if (value == null)
            {
                return "[null]";
            }

            string result;

            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                    ser.WriteObject(stream, value);

                    result = Encoding.UTF8.GetString(stream.GetBuffer(), 0, (int)stream.Length);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                result = $"[serialize json exception] - {ex.Message}";
            }

            return result;
        }
    }
}
