using System;
using System.Collections.Generic;
using System.Text;

namespace Tsundoku_Bot.Storage
{
    interface IDataStorage
    {
        /// <summary>
        /// Stores an Object as Data with the specified 'key'.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="key"></param>
        void StoreDataObject(object obj, string key);

        /// <summary>
        /// Retrieves the Specified Object Identified by 'key'.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T RetrieveStoredObject<T>(string key);
    }
}
