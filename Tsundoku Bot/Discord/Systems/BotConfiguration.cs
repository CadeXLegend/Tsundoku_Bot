using System;
using Discord.WebSocket;

namespace Tsundoku_Bot.Discord.Systems
{
    public class BotConfiguration
    {
        /// <summary>
        /// The Discord Bot's Login Token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// The Discord Socket Configuration Information to be Parsed.
        /// </summary>
        public DiscordSocketConfig socketConfig { get; set; }

        public BotConfiguration()
        {
            Console.WriteLine("Bot Configuration Successfully Initialized.");
        }
    }
}
