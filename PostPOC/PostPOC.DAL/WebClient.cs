using System;
using System.Net.Http;

namespace PostPOC.DAL
{
    /// <summary>
    /// Class WebClient.
    /// </summary>
    /// <seealso cref="PostPOC.DAL.IClient" />
    public class WebClient : IClient
    {
        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <returns>HttpClient.</returns>
        public HttpClient GetClient()
        {
            var requestHandler = new WebRequestHandler();

            var httpClient = new System.Net.Http.HttpClient(requestHandler);

            httpClient.DefaultRequestHeaders.Add("Correlationid", Guid.NewGuid().ToString());

            httpClient.Timeout = TimeSpan.FromMinutes(3);

            return httpClient;
        }

        /// <summary>
        /// Gets the response.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="url">The URL.</param>
        /// <returns>System.String.</returns>
        public string GetResponse(HttpClient httpClient, string url)
        {
            return httpClient.GetStringAsync(url).Result;
        }
    }
}

