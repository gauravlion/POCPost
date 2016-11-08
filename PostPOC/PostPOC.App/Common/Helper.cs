using Newtonsoft.Json;
using PostPOC.Model;
using System.Configuration;
using System.Windows;
using System.Windows.Input;

namespace PostPOC.App.Common
{
    /// <summary>
    /// Class Helper.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <param name="requestObject">The request object.</param>
        /// <returns>System.String.</returns>
        public static string GetURL(RequestObject requestObject)
        {
            if (!string.IsNullOrEmpty(requestObject.URL))
            {
                requestObject.URL = string.Format(Constants.URLFormat, ConfigurationManager.AppSettings[Constants.JsonURL], requestObject.URL);
            }
            else
                requestObject.URL = ConfigurationManager.AppSettings[Constants.JsonURL];

            if (requestObject.id != -1)
            {
                requestObject.URL = string.Format(Constants.URLFormat, requestObject.URL, requestObject.id);
            }
            return requestObject.URL;
        }

        /// <summary>
        /// Jasons the converter.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>System.String.</returns>
        public static string JasonConverter(object obj)
        {
            if (obj != null)
                return JsonConvert.SerializeObject(obj);
            else
                return string.Empty;
        }

        /// <summary>
        /// Converters the specified data formats.
        /// </summary>
        /// <param name="dataFormats">The data formats.</param>
        /// <returns>System.String.</returns>
        public static string Converter(TextDataFormat dataFormats)
        {
            return (string)Clipboard.GetText(dataFormats);
        }

        /// <summary>
        /// Sets the clipboard.
        /// </summary>
        /// <param name=Constants.Text>The text.</param>
        public static void SetClipboard(string text)
        {
            Clipboard.SetText(text);
        }

        /// <summary>
        /// Copies the command.
        /// </summary>
        /// <param name="inputElement">The input element.</param>
        public static void CopyCommand(IInputElement inputElement)
        {
            if (inputElement != null)
            {
                ApplicationCommands.Copy.Execute(null, inputElement);
            }
        }

    }
}
