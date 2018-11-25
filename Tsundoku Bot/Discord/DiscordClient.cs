using System;
using System.Threading.Tasks;
using Tsundoku_Bot.Discord.Systems;
using Tsundoku_Bot.Storage;

namespace Tsundoku_Bot.Discord
{
    /// <summary>
    /// 
    /// </summary>
    class DiscordClient
    {
        /// <summary>
        /// Initiates the Discord Bot and establishes the Connection.
        /// </summary>
        /// <returns></returns>
        protected static async Task InitiateBot()
        {
            //Register Storage Instance
            IDataStorage storage = Unity.Resolve<IDataStorage>();

            string token = "EFG";
            //Grabs the Desktop Directory and Formats it Correctly
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory).Replace("\\", "/") + "/Config/JsonData";
            //Then Stores the Information in a JSON File
            storage.StoreDataObject(token, dir);

            //Establish the Connection
            Connection connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new BotConfiguration
            {
                Token = storage.RetrieveStoredObject<string>(dir)
            });
            //keep it from closing 
            await Task.Delay(-1);
        }
    }
}
