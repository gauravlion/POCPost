namespace PostPOC.Common
{
    /// <summary>
    /// Interface ILogger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes the information.
        /// </summary>
        /// <param name="message">The message.</param>
        void WriteInformation(string message);

        /// <summary>
        /// Writes the verbose.
        /// </summary>
        /// <param name="message">The message.</param>
        void WriteVerbose(string message);
    }
}