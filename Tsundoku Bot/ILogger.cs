namespace Tsundoku_Bot
{
    /// <summary>
    /// Provides a Basis for Logging.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Generic Logging of a Message.
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
    }
}
