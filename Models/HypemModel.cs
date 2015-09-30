using Newtonsoft.Json;

namespace ParseHypemJsonWPF
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HypemModel
    {
        [JsonProperty(PropertyName = "mediaid")]
        public string mediaid { get; set; }

        [JsonProperty(PropertyName = "artist")]
        public string artist { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "dateposted")]
        public int dateposted { get; set; }

        [JsonProperty(PropertyName = "siteid")]
        public int siteid { get; set; }

        [JsonProperty(PropertyName = "sitename")]
        public string sitename { get; set; }

        [JsonProperty(PropertyName = "posturl")]
        public string posturl { get; set; }

        [JsonProperty(PropertyName = "postid")]
        public int postid { get; set; }

        [JsonProperty(PropertyName = "loved_count")]
        public int loved_count { get; set; }

        [JsonProperty(PropertyName = "posted_count")]
        public int posted_count { get; set; }

        [JsonProperty(PropertyName = "thumb_url")]
        public string thumb_url { get; set; }

        [JsonProperty(PropertyName = "thumb_url_medium")]
        public string thumb_url_medium { get; set; }

        [JsonProperty(PropertyName = "thumb_url_large")]
        public string thumb_url_large { get; set; }

        [JsonProperty(PropertyName = "thumb_url_artist")]
        public object thumb_url_artist { get; set; }

        [JsonProperty(PropertyName = "time")]
        public int time { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string description { get; set; }

        [JsonProperty(PropertyName = "itunes_link")]
        public string itunes_link { get; set; }
    }
}
