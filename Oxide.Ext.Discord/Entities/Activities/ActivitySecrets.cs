using Newtonsoft.Json;

namespace Oxide.Ext.Discord.Entities.Activities
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class ActivitySecrets
    {
        [JsonProperty("join")]
        public string Join { get; set; }
        
        [JsonProperty("spectate")]
        public string Spectate { get; set; }
        
        [JsonProperty("match")]
        public string Match { get; set; }
    }
}