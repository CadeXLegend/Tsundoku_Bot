using System.Threading.Tasks;

namespace Tsundoku_Bot
{
    /// <summary>
    /// The Program Shell used to Execute the Bot.
    /// </summary>
    internal class Program : Discord.DiscordClient
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            await InitiateBot();
        }
    }

    
}
