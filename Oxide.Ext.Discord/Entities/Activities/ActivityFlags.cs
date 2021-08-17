using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Oxide.Ext.Discord.Entities.Activities
{
    /// <summary>
    /// Represents <a href="https://discord.com/developers/docs/topics/gateway#activity-object-activity-flags">Activity Flags</a>
    /// </summary>
    [Flags]
    public enum ActivityFlags
    {
        /// <summary>
        /// No Actions can be done to this activity
        /// </summary>
        [EnumMember(Value = "NONE")]
        None = 0,
        
        /// <summary>
        /// No Actions can be done to this activity
        /// </summary>
        [EnumMember(Value = "INSTANCE")]
        Instance =	1 << 0,
        
        /// <summary>
        /// Activity can be joined
        /// </summary>
        [EnumMember(Value = "JOIN")]
        Join =	1 << 1,
        
        /// <summary>
        /// Activity can be spectated
        /// </summary>
        [EnumMember(Value = "SPECTATE")]
        Spectate =	1 << 2,
        
        /// <summary>
        /// User may request to join activity
        /// </summary>
        [EnumMember(Value = "JOIN_REQUEST")]
        JoinRequest =	1 << 3,
        
        /// <summary>
        /// User can listen along in spotify
        /// </summary>
        [EnumMember(Value = "SYNC")]
        Sync =	1 << 4,
        
        /// <summary>
        /// User can play this song
        /// </summary>
        [EnumMember(Value = "PLAY")]
        Play =	1 << 5
    }
}