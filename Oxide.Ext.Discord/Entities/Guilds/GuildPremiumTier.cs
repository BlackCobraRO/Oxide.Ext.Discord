﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace Oxide.Ext.Discord.Entities.Guilds
{
    /// <summary>
    /// Represents <a href="https://discord.com/developers/docs/resources/guild#guild-object-verification-level">Verification Level</a>
    /// </summary>
    public enum GuildPremiumTier
    {
        /// <summary>
        /// Guild does not have any premium tier
        /// </summary>
        [EnumMember(Value = "NONE")]
        None = 0,
        
        /// <summary>
        /// Guild is premium tier 1
        /// </summary>
        [EnumMember(Value = "TIER_1")]
        Tier1 = 1,
        
        /// <summary>
        /// Guild is premium tier 2
        /// </summary>
        [EnumMember(Value = "TIER_2")]
        Tier2 = 2,
        
        /// <summary>
        /// Guild is premium tier 3
        /// </summary>
        [EnumMember(Value = "TIER_3")]
        Tier3 = 3
    }
}