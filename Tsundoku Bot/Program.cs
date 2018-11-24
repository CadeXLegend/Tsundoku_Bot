using System.Threading.Tasks;
using Tsundoku_Bot.Discord;
using Tsundoku_Bot.Discord.Systems;

namespace Tsundoku_Bot
{
    internal class Program
    {
        private static async Task Main()
        {
            await InitiateBot();
        }

        //[WILL BE MOVED TO A SEPERATE CLASS LATER]
        /// <summary>
        /// Initiates the Discord Bot and establishes the Connection.
        /// </summary>
        /// <returns></returns>
        private static async Task InitiateBot()
        {
            BotConfiguration config = new BotConfiguration
            {
                Token = "TOKEN ID HERE",
                socketConfig = SocketGenerator.GenerateDefault()
            };

            //keep it from closing 
            await Task.Delay(-1);
        }
    }

    
}
