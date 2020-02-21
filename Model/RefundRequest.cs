using System.Collections.Generic;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// RefundRequest class.
    /// </summary>
    public class RefundRequest
    {
        /// <summary>
        /// Amount property.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Urls property.
        /// </summary>
        public List<UrlRequest> Urls { get; set; }
    }
}
