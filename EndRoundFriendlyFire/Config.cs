using System.ComponentModel;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace EndRoundFriendlyFire
{
    public class Config
    {
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug logs should be shown.
        /// </summary>
        [Description("Whether debug logs should be shown.")]
        public bool Debug { get; set; } = false;
        
        /// <summary>
        /// Gets or sets a value indicating whether override value is provided.
        /// </summary>
        [Description("Overrides ConfigFile FriendlyFireMultiplier (or you can do it there).")]
        public float OverriddenFriendlyFireMultiplier { get; set; } = 0.2f;

        /// <summary>
        /// Gets of sets a value determining what is sent to the player when FF is enabled
        /// </summary>
        [Description("Sets the message players will get when friendly fire is turned on")]
        public string Message { get; set; } = "<align=center><voffset=28em> <color=#F6511D> Friendly Fire has been enabled! </color></voffset></align>";

        /// <summary>
        /// Whether the message above will be a broadcast or hint
        /// </summary>
        [Description("The message type for notifying players, broadcast / hint")]
        public MessageType FriendlyFireNotifyingType { get; set; } = MessageType.Hint;
        
        /// <summary>
        /// How long to display FF message
        /// </summary>
        [Description("How long to display FF message")]
        public float MessageDuration { get; set; }  = 0.3f;
        
    }
    public enum MessageType
    {
        Broadcast,
        Hint
    };
}