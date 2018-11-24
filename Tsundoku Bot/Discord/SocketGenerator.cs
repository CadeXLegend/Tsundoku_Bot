using Discord;
using Discord.WebSocket;

namespace Tsundoku_Bot.Discord
{
    /// <summary>
    /// Generates Sockets for Discord.
    /// </summary>
    public static class SocketGenerator
    {
        /// <summary>
        /// Generates a Discord Socket Config.
        /// </summary>
        public static DiscordSocketConfig GenerateDefault()
        {
            return new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Verbose
            };
        }
    }
}
