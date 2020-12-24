using Newtonsoft.Json;

namespace Oxide.Ext.Discord.Entities.Messages.Embeds
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class EmbedAuthor
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("proxy_icon_url")]
        public string ProxyIconUrl { get; set; }
    }
}