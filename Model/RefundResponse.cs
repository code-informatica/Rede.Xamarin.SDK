using System.Collections.Generic;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// RefundResponse class.
    /// </summary>
    public class RefundResponse : ResponseBase
    {
        /// <summary>
        /// RefundId property.
        /// </summary>
        public string RefundId { get; set; }

        /// <summary>
        /// RefundDateTime property.
        /// </summary>
        public string RefundDateTime { get; set; }

        /// <summary>
        /// Tid property.
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// Nsu property.
        /// </summary>
        public string Nsu { get; set; }

        /// <summary>
        /// Status property.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Amount property.
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// CancelId property.
        /// </summary>
        public string CancelId { get; set; }

        /// <summary>
        /// StatusHistory property.
        /// </summary>
        public List<RefundHistoryResponse> StatusHistory { get; set; }

        // <summary>
        /// Links property.
        /// </summary>
        public List<Link> Links { get; set; }
    }
}
