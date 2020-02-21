using System;
using System.Net.Http;

namespace Rede.Acquiring.SDK.Rest
{
    /// <summary>
    /// eRede Api connection configuration.
    /// </summary>
    public static class ERedeApiConfiguration
    {
        /// <summary>
        /// Allows you to provide your own HttpMessageHandler (optional, useful with Android/iPhone).
        /// </summary>
        public static HttpMessageHandler HttpMessageHandler { get; set; }

        /// <summary>
        /// Timeout.
        /// </summary>
        public static TimeSpan? Timeout { get; set; }
    }
}
