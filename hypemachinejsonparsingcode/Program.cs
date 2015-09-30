using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HypeMachineDataParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            // doesn't matter how you get the json text but we'll need to pass it to the json converter
            var filePath = @"C:\Users\jorda\Desktop\data.json";
            // option is for the linq below
            int option;
            // create a jcontainer using the json text
            var container = (JContainer)JsonConvert.DeserializeObject(File.ReadAllText(filePath));
            // filter out everything but the inner element data and turn it into a list of JTokens
            var pollOptionValues = container.Where(t => t as JProperty != null)
                .Cast<JProperty>().Where(p => int.TryParse(p.Name, out option))
                .Select(p => p.Value.Value<JToken>()).ToList();
            // create a container of Data objects
            var dataList = new List<Data>();
            foreach (var item in pollOptionValues)
            {
                // use the JsonConverter to deserialize the inner data to our data model
                dataList.Add(JsonConvert.DeserializeObject<Data>(item.ToString()));
            }

            Console.ReadLine();
        }
    }
}
