using System.Net.Http;

namespace PostPOC.DAL
{
    /// <summary>
    /// Interface IClient
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <returns>HttpClient.</returns>
        HttpClient GetClient();
        /// <summary>
        /// Gets the response.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="url">The URL.</param>
        /// <returns>System.String.</returns>
        string GetResponse(HttpClient httpClient, string url);
    }
}
