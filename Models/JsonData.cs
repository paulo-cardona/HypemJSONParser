using Newtonsoft.Json;
using System.Collections.Generic;

//public class Rootobject
//{
//    public string version { get; set; }
//    public List<Child> child { get; set; }
//}

public class Data
{
    public string mediaid { get; set; }
    public string artist { get; set; }
    public string title { get; set; }
    public int dateposted { get; set; }
    public int siteid { get; set; }
    public string sitename { get; set; }
    public string posturl { get; set; }
    public int postid { get; set; }
    public int loved_count { get; set; }
    public int posted_count { get; set; }
    public string thumb_url { get; set; }
    public string thumb_url_medium { get; set; }
    public string thumb_url_large { get; set; }
    public object thumb_url_artist { get; set; }
    public int time { get; set; }
    public string description { get; set; }
    public string itunes_link { get; set; }
}
