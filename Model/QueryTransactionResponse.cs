using System.Collections.Generic;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// QueryTransactionResponse class.
    /// </summary>
    public class QueryTransactionResponse : ResponseBase
    {
        /// <summary>
        /// RequestDateTime property.
        /// </summary>
        public string RequestDateTime { get; set; }

        /// <summary>
        /// Authorization property.
        /// </summary>
        public AuthorizationResponse Authorization { get; set; }

        /// <summary>
        /// Capture property.
        /// </summary>
        public CaptureResponse Capture { get; set; }

        /// <summary>
        /// Iata property.
        /// </summary>
        public IataResponse Iata { get; set; }

        /// <summary>
        /// ThreeDSecure property.
        /// </summary>
        public ThreeDSecureResponse ThreeDSecure { get; set; }

        /// <summary>
        /// Refunds property.
        /// </summary>
        public List<RefundResponse> Refunds { get; set; }

        // <summary>
        /// Links property.
        /// </summary>
        public List<Link> Links { get; set; }
    }
}
