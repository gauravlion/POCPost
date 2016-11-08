using System.IO;
using System.Text;

namespace PostPOC.Common
{
    /// <summary>
    /// Class FileLogger.
    /// </summary>
    /// <seealso cref="PostPOC.Common.ILogger" />
    public class FileLogger : ILogger
    {
        /// <summary>
        /// The output file name
        /// </summary>
        private static string _outputFileName = "Output.log";
        /// <summary>
        /// The header
        /// </summary>
        private static string _header = "==============================================";


        /// <summary>
        /// Writes the information.
        /// </summary>
        /// <param name="message">The message.</param>
        public void WriteInformation(string message)
        {
            File.AppendAllText(_outputFileName, GetFormattedMessage(message));
        }

        /// <summary>
        /// Writes the verbose.
        /// </summary>
        /// <param name="message">The message.</param>
        public void WriteVerbose(string message)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine();

            stringBuilder.AppendLine(message);

            File.AppendAllText(_outputFileName, stringBuilder.ToString());
        }

        /// <summary>
        /// Gets the formatted message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>System.String.</returns>
        private static string GetFormattedMessage(string message)
        {
            var stringBuilder = new StringBuilder(_header);

            stringBuilder.AppendLine();

            stringBuilder.AppendLine(message);

            return stringBuilder.ToString();
        }
    }
}
