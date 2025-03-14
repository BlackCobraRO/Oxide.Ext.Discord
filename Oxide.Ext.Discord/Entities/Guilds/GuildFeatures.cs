using System.ComponentModel;
using Newtonsoft.Json;
using Oxide.Ext.Discord.Helpers.Converters;

namespace Oxide.Ext.Discord.Entities.Guilds
{
    /// <summary>
    /// Represents <a href="https://discord.com/developers/docs/resources/guild#guild-object-guild-features">Guild Features</a>
    /// </summary>
    [JsonConverter(typeof(DiscordEnumConverter))]
    public enum GuildFeatures
    {
     
        /// <summary>
        /// Discord Extension doesn't currently support a guild features
        /// </summary>
        Unknown,
        
        /// <summary>
        /// Guild has access to set an animated guild icon
        /// </summary>
        [Description("ANIMATED_ICON")] 
        AnimatedIcon,
        
        /// <summary>
        /// Guild has access to set a guild banner image
        /// </summary>
        [Description("BANNER")] 
        Banner,
        
        /// <summary>
        /// Guild has access to use commerce features (i.e. create store channels)
        /// </summary>
        [Description("COMMERCE")] 
        Commerce,
        
        /// <summary>
        /// Guild can enable welcome screen and discovery, and receives community updates
        /// </summary>
        [Description("COMMUNITY")] 
        Community,
        
        /// <summary>
        /// Guild is lurkable and able to be discovered in the directory
        /// </summary>
        [Description("DISCOVERABLE")] 
        Discoverable,
        
        /// <summary>
        /// Guild is able to be featured in the directory
        /// </summary>
        [Description("FEATURABLE")] 
        Featurable,
        
        /// <summary>
        /// Guild has access to set an invite splash background
        /// </summary>
        [Description("INVITE_SPLASH")] 
        InviteSplash,
        
        /// <summary>
        /// Guild has enabled Membership Screening
        /// </summary>
        [Description("MEMBER_VERIFICATION_GATE_ENABLED")] 
        MemberVerificationGateEnabled,

        /// <summary>
        /// Guild has enabled monetization
        /// </summary>
        [Description("MONETIZATION_ENABLED")] 
        MonetizationEnabled,

        /// <summary>
        /// Guild has increased custom sticker slots
        /// </summary>
        [Description("MORE_STICKERS")] 
        MoreStickers,

        /// <summary>
        /// Guild has access to create news channels
        /// </summary>
        [Description("NEWS")] 
        News,
        
        /// <summary>
        /// Guild is partnered
        /// </summary>
        [Description("PARTNERED")] 
        Partnered,
        
        /// <summary>
        /// Guild can be previewed before joining via Membership Screening or the directory
        /// </summary>
        [Description("PREVIEW_ENABLED")] 
        PreviewEnabled,
        
        /// <summary>
        /// Guild has access to create private threads
        /// </summary>
        [Description("PRIVATE_THREADS")] 
        PrivateThreads,
        
        /// <summary>
        /// Guild can be previewed before joining via Membership Screening or the directory
        /// </summary>
        [Description("ROLE_ICONS")] 
        RoleIcons,

        /// <summary>
        /// Guild has access to the seven day archive time for threads
        /// </summary>
        [Description("SEVEN_DAY_THREAD_ARCHIVE")] 
        SevenDayThreadArchive,
        
        /// <summary>
        /// Guild has access to the three day archive time for threads
        /// </summary>
        [Description("THREE_DAY_THREAD_ARCHIVE")] 
        ThreeDayThreadArchive,
        
        /// <summary>
        /// Guild has enabled ticketed events
        /// </summary>
        [Description("TICKETED_EVENTS_ENABLED")] 
        TicketedEventsEnabled,
        
        /// <summary>
        /// Guild has access to set a vanity URL
        /// </summary>
        [Description("VANITY_URL")] 
        VanityUrl,
        
        /// <summary>
        /// Guild is verified
        /// </summary>
        [Description("VERIFIED")] 
        Verified,
        
        /// <summary>
        /// Guild has access to set 384kbps bitrate in voice (previously VIP voice servers)
        /// </summary>
        [Description("VIP_REGIONS")] 
        VipRegions,
        
        /// <summary>
        /// Guild has enabled the welcome screen
        /// </summary>
        [Description("WELCOME_SCREEN_ENABLED")] 
        WelcomeScreenEnabled,
    }
}