using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Rede.Acquiring.SDK.Rest.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rede.Acquiring.SDK.Rest.Common
{
    /// <summary>
    /// Request class.
    /// </summary>
    internal static class Request
    {
        static HttpClient httpClient;
        static JsonSerializerSettings serializerSettings;

        static Request()
        {
            httpClient = 
                ERedeApiConfiguration.HttpMessageHandler != null
                ? new HttpClient(ERedeApiConfiguration.HttpMessageHandler)
                : new HttpClient();

            if (ERedeApiConfiguration.Timeout.HasValue)
                httpClient.Timeout = ERedeApiConfiguration.Timeout.Value;

            serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            serializerSettings.Converters.Add(new StringEnumConverter());
        }

        static string GetUrl(string path, EnvironmentType environment)
        {
            string baseUrl;

            switch (environment)
            {
                case EnvironmentType.Homolog:
                    baseUrl = "https://api.userede.com.br/desenvolvedores/v1/";
                    break;
                case EnvironmentType.Production:
                    baseUrl = "https://api.userede.com.br/erede/v1/";
                    break;
                default:
                    baseUrl = String.Empty;
                    break;
            }

            return String.Concat(baseUrl, path);
        }

        static HttpRequestMessage GetRequestMessage(string path, HttpMethod method, Security security, object content)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var uri = new Uri(GetUrl(path, security.Environment));
            var request = new HttpRequestMessage(method, uri);

            if (method == HttpMethod.Post || method == HttpMethod.Put)
                request.Content = new StringContent(JsonConvert.SerializeObject(content, serializerSettings), Encoding.UTF8, "application/json");

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}", security.Affiliation, security.Password))));
            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return request;
        }

        static HttpRequestMessage GetRequestMessage(string path, HttpMethod method, Security security)
        {
            return GetRequestMessage(path, method, security, null);
        }

        /// <summary>
        /// Sends a GET request async.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="cancellationToken">CancellationToken.</param>
        /// <returns>HttpResponseMessage.</returns>
        public static async Task<HttpResponseMessage> GetAsync(string path, Security security, CancellationToken cancellationToken)
        {
            var request = GetRequestMessage(path, HttpMethod.Get, security);

            return await httpClient.SendAsync(request, cancellationToken);
        }

        /// <summary>
        /// Sends a GET request async.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <returns>HttpResponseMessage.</returns>
        public static async Task<HttpResponseMessage> GetAsync(string path, Security security)
        {
            return await GetAsync(path, security, default(CancellationToken));
        }

        /// <summary>
        /// Sends a POST request async.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="content">Content.</param>
        /// <param name="cancellationToken">CancellationToken.</param>
        /// <returns>HttpResponseMessage.</returns>
        public static async Task<HttpResponseMessage> PostAsync(string path, object content, Security security, CancellationToken cancellationToken)
        {
            var request = GetRequestMessage(path, HttpMethod.Post, security, content);

            return await httpClient.SendAsync(request, cancellationToken);
        }

        /// <summary>
        /// Sends a POST request async.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="content">Content.</param>
        /// <returns>HttpResponseMessage.</returns>
        public static async Task<HttpResponseMessage> PostAsync(string path, object content, Security security)
        {
            return await PostAsync(path, content, security, default(CancellationToken));
        }

        /// <summary>
        /// Sends a PUT request async.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="content">Content.</param>
        /// <param name="cancellationToken">CancellationToken.</param>
        /// <returns>HttpResponseMessage.</returns>
        public static async Task<HttpResponseMessage> PutAsync(string path, object content, Security security, CancellationToken cancellationToken)
        {
            var request = GetRequestMessage(path, HttpMethod.Put, security, content);

            return await httpClient.SendAsync(request, cancellationToken);
        }

        /// <summary>
        /// Sends a PUT request async.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="content">Content.</param>
        /// <returns>HttpResponseMessage.</returns>
        public static async Task<HttpResponseMessage> PutAsync(string path, object content, Security security)
        {
            return await PutAsync(path, content, security, default(CancellationToken));
        }
    }
}
