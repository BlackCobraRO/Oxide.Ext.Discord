using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Oxide.Ext.Discord.Entities.Channels
{
    /// <summary>
    /// Represents <a href="https://discord.com/developers/docs/topics/permissions#permissions-bitwise-permission-flags">Permission Flags</a> for user or role
    /// </summary>
    [Flags]
    public enum PermissionFlags : ulong
    {
        /// <summary>
        /// Allows creation of instant invites
        /// Channel Type (Text, Voice, Stage)
        /// </summary>
        [EnumMember(Value = "CREATE_INSTANT_INVITE")]
        CreateInstantInvite = 1 << 0,
        
        /// <summary>
        /// Allows kicking members
        /// </summary>
        [EnumMember(Value = "KICK_MEMBERS")]
        KickMembers = 1 << 1,
        
        /// <summary>
        /// Allows banning members
        /// </summary>
        [EnumMember(Value = "BAN_MEMBERS")]
        BanMembers = 1 << 2,
        
        /// <summary>
        /// Allows all permissions and bypasses channel permission overwrites
        /// </summary>
        [EnumMember(Value = "ADMINISTRATOR")]
        Administrator = 1 << 3,
        
        /// <summary>
        /// Allows management and editing of channels
        /// Channel Type (Text, Voice, Stage)
        /// </summary>
        [EnumMember(Value = "MANAGE_CHANNELS")]
        ManageChannels = 1 << 4,
        
        /// <summary>
        /// Allows management and editing of the guild
        /// </summary>
        [EnumMember(Value = "MANAGE_GUILD")]
        ManageGuild = 1 << 5,
        
        /// <summary>
        /// Allows for the addition of reactions to messages
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "ADD_REACTIONS")]
        AddReactions = 1 << 6,
        
        /// <summary>
        /// Allows for viewing of audit logs
        /// </summary>
        [EnumMember(Value = "VIEW_AUDIT_LOG")]
        ViewAuditLog = 1 << 7,
        
        /// <summary>
        /// Allows for using priority speaker in a voice channel
        /// Channel Type (Voice)
        /// </summary>
        [EnumMember(Value = "PRIORITY_SPEAKER")]
        PrioritySpeaker = 1 << 8,
        
        /// <summary>
        /// Allows the user to go live
        /// Channel Type (Voice)
        /// </summary>
        [EnumMember(Value = "STREAM")]
        Stream = 1 << 9,
        
        /// <summary>
        /// Allows guild members to view a channel, which includes reading messages in text channels
        /// Channel Type (Text, Voice, Stage)
        /// </summary>
        [EnumMember(Value = "VIEW_CHANNEL")]
        ViewChannel = 1 << 10,
        
        /// <summary>
        /// Allows for sending messages in a channel
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "SEND_MESSAGES")]
        SendMessages = 1 << 11,
        
        /// <summary>
        /// Allows for sending of /tts messages
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "SEND_TTS_MESSAGES")]
        SendTtsMessages = 1 << 12,
        
        /// <summary>
        /// Allows for deletion of other users messages
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "MANAGE_MESSAGES")]
        ManageMessages = 1 << 13,
        
        /// <summary>
        /// Links sent by users with this permission will be auto-embedded
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "EMBED_LINKS")]
        EmbedLinks = 1 << 14,
        
        /// <summary>
        /// Allows for uploading images and files
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "ATTACH_FILES")]
        AttachFiles = 1 << 15,
        
        /// <summary>
        /// Allows for reading of message history
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "READ_MESSAGE_HISTORY")]
        ReadMessageHistory = 1 << 16,
        
        /// <summary>
        /// Allows for using the @everyone tag to notify all users in a channel,
        /// and the @here tag to notify all online users in a channel
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "MENTION_EVERYONE")]
        MentionEveryone = 1 << 17,
        
        /// <summary>
        /// Allows the usage of custom emojis from other servers
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "USE_EXTERNAL_EMOJIS")]
        UseExternalEmojis = 1 << 18,
        
        /// <summary>
        /// Allows for viewing guild insights
        /// </summary>
        [EnumMember(Value = "VIEW_GUILD_INSIGHTS")]
        ViewGuildInsights = 1 << 19,
        
        /// <summary>
        /// Allows for joining of a voice channel
        /// Channel Type (Voice, Stage)
        /// </summary>
        [EnumMember(Value = "CONNECT")]
        Connect = 1 << 20,
        
        /// <summary>
        /// Allows for speaking in a voice channel
        /// Channel Type (Voice)
        /// </summary>
        [EnumMember(Value = "SPEAK")]
        Speak = 1 << 21,
        
        /// <summary>
        /// Allows for muting members in a voice channel
        /// Channel Type (Voice, Stage)
        /// </summary>
        [EnumMember(Value = "MUTE_MEMBERS")]
        MuteMembers = 1 << 22,
        
        /// <summary>
        /// Allows for deafening of members in a voice channel
        /// Channel Type (Voice, Stage)
        /// </summary>
        [EnumMember(Value = "DEAFEN_MEMBERS")]
        DeafanMembers = 1 << 23,
        
        /// <summary>
        /// Allows for moving of members between voice channels
        /// Channel Type (Voice, Stage)
        /// </summary>
        [EnumMember(Value = "MOVE_MEMBERS")]
        MoveMembers = 1 << 24,
        
        /// <summary>
        /// Allows for using voice-activity-detection in a voice channel
        /// Channel Type (Voice)
        /// </summary>
        [EnumMember(Value = "USE_VAD")]
        UseVad = 1 << 25,
        
        /// <summary>
        /// Allows for modification of own nickname
        /// </summary>
        [EnumMember(Value = "CHANGE_NICKNAME")]
        ChangeNickname = 1 << 26,
        
        /// <summary>
        /// Allows for modification of other users nicknames
        /// </summary>
        [EnumMember(Value = "MANAGE_NICKNAMES")]
        ManageNicknames = 1 << 27,
        
        /// <summary>
        /// Allows management and editing of roles
        /// Channel Type (Text, Voice, Stage)
        /// </summary>
        [EnumMember(Value = "MANAGE_ROLES")]
        ManageRoles = 1 << 28,
        
        /// <summary>
        /// Allows management and editing of webhooks
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "MANAGE_WEBHOOKS")]
        ManageWebhooks = 1 << 29,
        
        /// <summary>
        /// Allows management and editing of emojis
        /// </summary>
        [EnumMember(Value = "MANAGE_EMOJIS_AND_STICKERS")]
        ManageEmojisAndStickers = 1 << 30,
        
        /// <summary>
        /// Allows members to use application commands, including slash commands and context menu commands.
        /// </summary>
        [EnumMember(Value = "USE_APPLICATION_COMMANDS")]
        UseSlashCommands = 1ul << 31,
        
        /// <summary>
        /// Allows for requesting to speak in stage channels.
        /// Channel Type (Stage)
        /// (This permission is under active development and may be changed or removed.)
        /// </summary>
        [EnumMember(Value = "REQUEST_TO_SPEAK")]
        RequestToSpeak = 1ul << 32,
        
        /// <summary>
        /// Allows for deleting and archiving threads, and viewing all private threads
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "MANAGE_THREADS")]
        ManageThreads  = 1ul << 34,
        
        /// <summary>
        /// Allows for creating and participating in threads
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "USE_PUBLIC_THREADS")]
        UsePublicThreads  = 1ul << 35,
        
        /// <summary>
        /// Allows for creating and participating in private threads
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "USE_PRIVATE_THREADS")]
        UsePrivateThreads  = 1ul << 36,
        
        /// <summary>
        /// Allows the usage of custom stickers from other servers
        /// Channel Type (Text)
        /// </summary>
        [EnumMember(Value = "USE_EXTERNAL_STICKERS")]
        UseExternalStickers  = 1ul << 37,
    }
}