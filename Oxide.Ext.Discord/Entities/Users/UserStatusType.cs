using System.ComponentModel;
using System.Runtime.Serialization;

namespace Oxide.Ext.Discord.Entities.Users
{
    /// <summary>
    /// Represents Discord User <a href="https://discord.com/developers/docs/topics/gateway#update-status-status-types">Status Types</a> 
    /// </summary>
    public enum UserStatusType
    {
        /// <summary>
        /// User is online
        /// </summary>
        [Description("online")] Online,
        
        /// <summary>
        /// User has Do Not Disturb
        /// </summary>
        [Description("dnd")] DND,
        
        /// <summary>
        /// User is idle
        /// </summary>
        [Description("idle")] Idle,
        
        /// <summary>
        /// User is invisible
        /// </summary>
        [Description("invisible")] Invisible,
        
        /// <summary>
        /// User is offline
        /// </summary>
        [Description("offline")] Offline
    }
}