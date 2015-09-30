using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using DataAccess;
using Models;
using Newtonsoft.Json;
using ParseHypemJsonWPF;


namespace ParseHypemJsonWPF
{
    public class Manager
    {
        string filePathConstant = @"c:\hypem_batch_file";

        private string HypemURL
        {
            get { return "http://hypem.com/playlist/loved/YoungBolivia/json/1/data.js"; }
        }

        public void CreateBatchFile()
        {
            var webClient = new WebClient();
            var json_data = webClient.DownloadString(HypemURL);
            var hypemSongCollection = JsonConvert.DeserializeObject<HypemJsonModel>(json_data).ListOfSongs;
            var listUrls = hypemSongCollection.Select(x => "http://hypem.com/track/" + x.mediaid + "/a").ToList();
            
            //Write to file.
            System.IO.File.OpenWrite(filePathConstant);
            System.IO.File.AppendAllLines(filePathConstant, listUrls);
        }

    }
}