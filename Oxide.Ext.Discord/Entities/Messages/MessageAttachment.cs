﻿using Newtonsoft.Json;
using Oxide.Ext.Discord.Interfaces;

namespace Oxide.Ext.Discord.Entities.Messages
{
    /// <summary>
    /// Represents a message <a href="https://discord.com/developers/docs/resources/channel#message-object">Attachment Structure</a>
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class MessageAttachment : ISnowflakeEntity
    {
        /// <summary>
        /// Attachment ID
        /// </summary>
        [JsonProperty("id")]
        public Snowflake Id { get; set; }

        /// <summary>
        /// Name of file attached
        /// </summary>
        [JsonProperty("filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Size of file in bytes
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Source url of file
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// A proxied url of file
        /// </summary>
        [JsonProperty("proxy_url")]
        public string ProxyUrl { get; set; }

        /// <summary>
        /// Height of file (if image)
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of file (if image)
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}