using System;
using System.Net;
using Newtonsoft.Json;

namespace DataAccess
{
    public static class JsonDeserializer
    {

        public static T GetJsonData<T>(string url) where T : new()
        {
            using (var webClient = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = webClient.DownloadString(url);


                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();

            }
        }

    }
}
