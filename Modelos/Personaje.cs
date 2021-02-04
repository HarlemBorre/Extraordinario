using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtraApp.Modelos{
    public class Personaje{
        [JsonProperty("char_id")]
        public int id {get; set; }
        [JsonProperty("name")]
        public int Name {get; set; }
        [JsonProperty("birthday")]
        public int birthday {get; set; }
        [JsonProperty("nickname")]
        public int nickname {get; set; }
        [JsonProperty("portrayed")]
        public int actor {get; set; }
        [JsonProperty("status")]
        public int status {get; set; }
        [JsonProperty("occupation")]
        public List<string> occupation {get; set; }
        [JsonProperty("img")]
        public int image {get; set; }
    }
}