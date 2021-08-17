namespace Oxide.Ext.Discord.Entities.Interactions
{
    /// <summary>
    /// Represents <a href="https://discord.com/developers/docs/interactions/receiving-and-responding#interaction-response-object-interaction-callback-type">InteractionResponseType</a>
    /// </summary>
    public enum InteractionResponseType
    {
        /// <summary>
        /// Acknowledges a Ping
        /// </summary>
        Pong = 1,

        /// <summary>
        /// Respond with a message, showing the user's input
        /// </summary>
        ChannelMessageWithSource = 4,
        
        /// <summary>
        /// Acknowledge a command without sending a message, showing the user's input
        /// </summary>
        DeferredChannelMessageWithSource = 5,
        
        /// <summary>
        /// For components, Acknowledge an interaction and edit the original message later
        /// The user does not see a loading state
        /// </summary>
        DeferredUpdateMessage = 6,
        
        /// <summary>
        /// For components, edit the message the component was attached to
        /// </summary>
        UpdateMessage = 7
    }
}