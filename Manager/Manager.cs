using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using DataAccess;
using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ParseHypemJsonWPF;
using System.IO;


namespace ParseHypemJsonWPF
{
    public class Manager
    {
        #region variables/properties
        string filePathConstant = @"c:\pcardona\hypem_batch_file.txt";
        private string HypemURL { get { return "http://hypem.com/playlist/loved/YoungBolivia/json/xxx/data.js"; } }
        int numberOfPagesToSearch = 10; //This should not be hardcoded, and also it times out beyond 10 :(
        List<string> SongUrls = new List<string>();
        #endregion

        #region Public Methods
        public void CreateBatchFile()
        {
            for (int i = 1; i <= numberOfPagesToSearch; i++)
            {                
                var jsonString = RequestJsonSTring(i.ToString());
                SongUrls.AddRange(ParseJSON(jsonString));
            }

            CreateFile(SongUrls);
        }
        #endregion

        #region Private Methods
        private List<string> ParseJSON(string json_data)
        {    
            // create a jcontainer using the json text
            var container = (JContainer)JsonConvert.DeserializeObject(json_data);
            
            // filter out everything but the inner element data and turn it into a list of JTokens
            int option;
            var pollOptionValues = container.Where(t => t as JProperty != null)
                .Cast<JProperty>().Where(p => int.TryParse(p.Name, out option))
                .Select(p => p.Value.Value<JToken>()).ToList();
            
            // create a container of Data objects
            var dataList = new List<Data>();
            foreach (var item in pollOptionValues)
            {   // use the JsonConverter to deserialize the inner data to our data model
                dataList.Add(JsonConvert.DeserializeObject<Data>(item.ToString()));
            }

            //Assemble URLs
            var listUrls = dataList.Select(x => "http://hypem.com/track/" + x.mediaid + "/a").ToList();
            return listUrls;
        }

        private string RequestJsonSTring(string iterator)
        {
            var webClient = new WebClient();
            var url = HypemURL.Replace("xxx", iterator);
            var json_data = webClient.DownloadString(url);
            return json_data;
        }

        private void CreateFile(List<string> Urls)
        {
            //todo clean up this notation!           
            using (var stream = File.Create(filePathConstant)) { }
            File.AppendAllLines(filePathConstant, Urls);
        }
        #endregion

        #region TODO
        /* 
        //TODO
        Page through all favorite pages
        metadata command arguments
        create a local parser account/save all web accounts inform/hash passwords
        */
        #endregion
    }
}