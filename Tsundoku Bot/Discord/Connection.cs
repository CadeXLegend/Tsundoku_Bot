using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Tsundoku_Bot.Discord.Systems;

namespace Tsundoku_Bot.Discord
{
    public class Connection
    {
        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        /// <summary>
        /// Establish a Connection with Discord.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="client"></param>
        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }

        /// <summary>
        /// Connect to Discord using the Configured Client.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        internal async Task ConnectAsync(BotConfiguration config)
        {
            _client.Log += _logger.Log;

            await _client.LoginAsync(TokenType.Bot, config.Token);
            await _client.StartAsync();

            //Keep it from closing
            await Task.Delay(-1);
        }
    }
}
