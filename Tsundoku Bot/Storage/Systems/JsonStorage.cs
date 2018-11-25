using System.IO;
using Newtonsoft.Json;
using static System.IO.Directory;

namespace Tsundoku_Bot.Storage.Systems
{
    class JsonStorage : IDataStorage
    {        
        /// <summary>
        /// Stores an Object as Data with the specified 'key'.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="key"></param>
        public void StoreDataObject(object obj, string key)
        {
            string file = $"{key}.json";
            CreateDirectory(Path.GetDirectoryName(file));
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, json);
        }

        /// <summary>
        /// Retrieves the Specified Object Identified by 'key'.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T RetrieveStoredObject<T>(string key)
        {
            string json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
