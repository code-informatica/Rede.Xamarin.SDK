using System.Collections.Generic;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// TransactionRequest class.
    /// </summary>
    public class TransactionRequest
    {
        /// <summary>
        /// Capture property.
        /// </summary>
        public bool? Capture { get; set; }

        /// <summary>
        /// Kind property.
        /// </summary>
        public TransactionKind Kind { get; set; }

        /// <summary>
        /// Reference property.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Amount property.
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// Installments property.
        /// </summary>
        public int? Installments { get; set; }

        /// <summary>
        /// CardHolderName property.
        /// </summary>
        public string CardHolderName { get; set; }

        /// <summary>
        /// CardNumber property.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// ExpirationMonth property.
        /// </summary>
        public int ExpirationMonth { get; set; }

        /// <summary>
        /// ExpirationYear property.
        /// </summary>
        public int ExpirationYear { get; set; }

        /// <summary>
        /// SecurityCode property.
        /// </summary>
        public string SecurityCode { get; set; }

        /// <summary>
        /// SoftDescriptor property.
        /// </summary>
        public string SoftDescriptor { get; set; }

        /// <summary>
        /// Subscription property.
        /// </summary>
        public bool? Subscription { get; set; }

        /// <summary>
        /// Origin property.
        /// </summary>
        public int? Origin { get; set; }

        /// <summary>
        /// DistributorAffiliation property.
        /// </summary>
        public string DistributorAffiliation { get; set; }

        /// <summary>
        /// ThreeDSecure property.
        /// </summary>
        public ThreeDSecureRequest ThreeDSecure { get; set; }

        /// <summary>
        /// Iata property.
        /// </summary>
        public IataRequest Iata { get; set; }

        /// <summary>
        /// Urls property.
        /// </summary>
        public List<UrlRequest> Urls { get; set; }
    }
}
