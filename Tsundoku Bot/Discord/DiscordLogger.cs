using System;
using System.Threading.Tasks;
using Discord;

namespace Tsundoku_Bot.Discord
{
    public class DiscordLogger
    {
        private ILogger _logger;

        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }

        public Task Log(LogMessage logData)
        {
            _logger.Log(logData.Message);
            return Task.CompletedTask;
        }
    }
}
