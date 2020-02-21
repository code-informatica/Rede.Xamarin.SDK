using System.Collections.Generic;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// RefundListResponse class.
    /// </summary>
    public class RefundListResponse : ResponseBase
    {
        /// <summary>
        /// Refunds property.
        /// </summary>
        public List<RefundResponse> Refunds { get; set; }

        /// <summary>
        /// Links property.
        /// </summary>
        public List<Link> Links { get; set; }
    }
}
