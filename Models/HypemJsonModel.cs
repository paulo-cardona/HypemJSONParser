using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ParseHypemJsonWPF;

namespace Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HypemJsonModel
    {

        public List<HypemModel> ListOfSongs = new List<HypemModel>();
            
            
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }


        public HypemModel _song { get; set; }

        [JsonProperty(PropertyName = "0")]
        public HypemModel Song 
        {
            get
            {
                return _song;
            }
            set 
            {
                _song = value; 
                ListOfSongs.Add(value);  
            }
        }


        public HypemModel _song1 { get; set; }
        [JsonProperty(PropertyName = "1")]
        public HypemModel Song1
        {
            get
            {
                return _song1;
            }
            set
            {
                _song1 = value;
                ListOfSongs.Add(value);
            }
        }

        public HypemModel _song2 { get; set; }
        [JsonProperty(PropertyName = "2")]
        public HypemModel Song2
        {
            get
            {
                return _song2;
            }
            set
            {
                _song2 = value;
                ListOfSongs.Add(value);
            }
        }

        public HypemModel _song3 { get; set; }
        [JsonProperty(PropertyName = "3")]
        public HypemModel Song3
        {
            get
            {
                return _song3;
            }
            set
            {
                _song3 = value;
                ListOfSongs.Add(value);
            }
        }

        public HypemModel _song4 { get; set; }
        [JsonProperty(PropertyName = "4")]
        public HypemModel Song4
        {
            get
            {
                return _song4;
            }
            set
            {
                _song4 = value;
                ListOfSongs.Add(value);
            }
        }

        public HypemModel _song5 { get; set; }
        [JsonProperty(PropertyName = "5")]
        public HypemModel Song5
        {
            get
            {
                return _song5;
            }
            set
            {
                _song5 = value;
                ListOfSongs.Add(value);
            }
        }

        public HypemModel _song6 { get; set; }
        public HypemModel _song7 { get; set; }
        public HypemModel _song8 { get; set; }
        public HypemModel _song9 { get; set; }
        public HypemModel _song10 { get; set; }
        public HypemModel _song11 { get; set; }
        public HypemModel _song12 { get; set; }
        public HypemModel _song13 { get; set; }
        public HypemModel _song14 { get; set; }
        public HypemModel _song15 { get; set; }
        public HypemModel _song16 { get; set; }
        public HypemModel _song17 { get; set; }
        public HypemModel _song18 { get; set; }
        public HypemModel _song19 { get; set; }
        public HypemModel _song20 { get; set; }
        public HypemModel _song21 { get; set; }
        public HypemModel _song22 { get; set; }
        public HypemModel _song23 { get; set; }
        public HypemModel _song24 { get; set; }
        public HypemModel _song25 { get; set; }
        public HypemModel _song26 { get; set; }
        public HypemModel _song27 { get; set; }
        public HypemModel _song28 { get; set; }
        public HypemModel _song29 { get; set; }
        public HypemModel _song30 { get; set; }
        public HypemModel _song31 { get; set; }
        public HypemModel _song32 { get; set; }
        public HypemModel _song33 { get; set; }
        public HypemModel _song34 { get; set; }
        public HypemModel _song35 { get; set; }
        public HypemModel _song36 { get; set; }
        public HypemModel _song37 { get; set; }
        public HypemModel _song38 { get; set; }
        public HypemModel _song39 { get; set; }
        public HypemModel _song40 { get; set; }
        public HypemModel _song41 { get; set; }
        public HypemModel _song42 { get; set; }
        public HypemModel _song43 { get; set; }
        public HypemModel _song44 { get; set; }
        public HypemModel _song45 { get; set; }
        public HypemModel _song46 { get; set; }
        public HypemModel _song47 { get; set; }
        public HypemModel _song48 { get; set; }
        public HypemModel _song49 { get; set; }
        public HypemModel _song50 { get; set; }


        [JsonProperty(PropertyName = "6")]
        public HypemModel Song6
        {
            get
            {
                return _song6;
            }
            set
            {
                _song6 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "7")]
        public HypemModel Song7
        {
            get
            {
                return _song7;
            }
            set
            {
                _song7 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "8")]
        public HypemModel Song8
        {
            get
            {
                return _song8;
            }
            set
            {
                _song8 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "9")]
        public HypemModel Song9
        {
            get
            {
                return _song9;
            }
            set
            {
                _song9 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "10")]
        public HypemModel Song10
        {
            get
            {
                return _song10;
            }
            set
            {
                _song10 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "11")]
        public HypemModel Song11
        {
            get
            {
                return _song11;
            }
            set
            {
                _song11 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "12")]
        public HypemModel Song12
        {
            get
            {
                return _song12;
            }
            set
            {
                _song12 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "13")]
        public HypemModel Song13
        {
            get
            {
                return _song13;
            }
            set
            {
                _song13 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "14")]
        public HypemModel Song14
        {
            get
            {
                return _song14;
            }
            set
            {
                _song14 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "15")]
        public HypemModel Song15
        {
            get
            {
                return _song15;
            }
            set
            {
                _song15 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "16")]
        public HypemModel Song16
        {
            get
            {
                return _song16;
            }
            set
            {
                _song16 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "17")]
        public HypemModel Song17 
        {
            get
            {
                return _song17;
            }
            set
            {
                _song17 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "18")]
        public HypemModel Song18
        {
            get
            {
                return _song18;
            }
            set
            {
                _song18 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "19")]
        public HypemModel Song19
        {
            get
            {
                return _song19;
            }
            set
            {
                _song19 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "20")]
        public HypemModel Song20
        {
            get
            {
                return _song20;
            }
            set
            {
                _song20 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "21")]
        public HypemModel Song21
        {
            get
            {
                return _song21;
            }
            set
            {
                _song21 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "22")]
        public HypemModel Song22
        {
            get
            {
                return _song22;
            }
            set
            {
                _song22 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "23")]
        public HypemModel Song23
        {
            get
            {
                return _song23;
            }
            set
            {
                _song23 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "24")]
        public HypemModel Song24
        {
            get
            {
                return _song24;
            }
            set
            {
                _song24 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "25")]
        public HypemModel Song25
        {
            get
            {
                return _song25;
            }
            set
            {
                _song25 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "26")]
        public HypemModel Song26
        {
            get
            {
                return _song26;
            }
            set
            {
                _song26 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "27")]
        public HypemModel Song27
        {
            get
            {
                return _song27;
            }
            set
            {
                _song27 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "28")]
        public HypemModel Song28
        {
            get
            {
                return _song28;
            }
            set
            {
                _song28 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "29")]
        public HypemModel Song29
        {
            get { return _song29; }
            set
            {
                _song29 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "30")]
        public HypemModel Song30
        {
            get
            {
                return _song30;
            }
            set
            {
                _song30 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "31")]
        public HypemModel Song31
        {
            get
            {
                return _song31;
            }
            set
            {
                _song31 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "32")]
        public HypemModel Song32
        {
            get
            {
                return _song32;
            }
            set
            {
                _song32 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "33")]
        public HypemModel Song33
        {
            get
            {
                return _song33;
            }
            set
            {
                _song33 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "34")]
        public HypemModel Song34
        {
            get
            {
                return _song34;
            }
            set
            {
                _song34 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "35")]
        public HypemModel Song35
        {
            get
            {
                return _song35;
            }
            set
            {
                _song35 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "36")]
        public HypemModel Song36
        {
            get
            {
                return _song36;
            }
            set
            {
                _song36 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "37")]
        public HypemModel Song37
        {
            get
            {
                return _song37;
            }
            set
            {
                _song37 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "38")]
        public HypemModel Song38
        {
            get
            {
                return _song38;
            }
            set
            {
                _song38 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "39")]
        public HypemModel Song39
        {
            get
            {
                return _song39;
            }
            set
            {
                _song39 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "40")]
        public HypemModel Song40
        {
            get
            {
                return _song40;
            }
            set
            {
                _song40 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "41")]
        public HypemModel Song41
        {
            get
            {
                return _song41;
            }
            set
            {
                _song41 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "42")]
        public HypemModel Song42
        {
            get
            {
                return _song42;
            }
            set
            {
                _song42 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "43")]
        public HypemModel Song43
        {
            get
            {
                return _song43;
            }
            set
            {
                _song43 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "44")]
        public HypemModel Song44
        {
            get
            {
                return _song44;
            }
            set
            {
                _song44 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "45")]
        public HypemModel Song45
        {
            get
            {
                return _song45;
            }
            set
            {
                _song45 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "46")]
        public HypemModel Song46
        {
            get
            {
                return _song46;
            }
            set
            {
                _song46 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "47")]
        public HypemModel Song47
        {
            get
            {
                return _song47;
            }
            set
            {
                _song47 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "48")]
        public HypemModel Song48
        {
            get
            {
                return _song48;
            }
            set
            {
                _song48 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "49")]
        public HypemModel Song49
        {
            get
            {
                return _song49;
            }
            set
            {
                _song49 = value;
                ListOfSongs.Add(value);
            }
        }

        [JsonProperty(PropertyName = "50")]
        public HypemModel Song50
        {
            get
            {
                return _song50;
            }
            set
            {
                _song50 = value;
                ListOfSongs.Add(value);
            }
        }


    }
}