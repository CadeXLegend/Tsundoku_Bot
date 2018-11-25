using Unity;
using Unity.Injection;
using Unity.Resolution;
using Discord.WebSocket;
using Tsundoku_Bot.Discord;
using Tsundoku_Bot.Storage;
using Tsundoku_Bot.Storage.Systems;

namespace Tsundoku_Bot
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        /// <summary>
        /// Register Singletons.
        /// </summary>
        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterSingleton<IDataStorage, JsonStorage>();
            _container.RegisterSingleton<ILogger, Logger>();

            //injects member from factory
            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(sockConfig => SocketGenerator.GenerateDefault()));
            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            _container.RegisterSingleton<Connection>();
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }
    }
}
