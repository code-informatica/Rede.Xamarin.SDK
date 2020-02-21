using System.Collections.Generic;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// TransactionResponse class.
    /// </summary>
    public class TransactionResponse : ResponseBase
    {
        /// <summary>
        /// Reference property.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Tid property.
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// Nsu property.
        /// </summary>
        public string Nsu { get; set; }
        
        /// <summary>
        /// AuthorizationCode property.
        /// </summary>
        public string AuthorizationCode { get; set; }
        
        /// <summary>
        /// DateTime property.
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// Amount property.
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// Installments property.
        /// </summary>
        public int? Installments { get; set; }

        /// <summary>
        /// CardBin property.
        /// </summary>
        public string CardBin { get; set; }

        /// <summary>
        /// Last4 property.
        /// </summary>
        public string Last4 { get; set; }

        /// <summary>
        /// ThreeDSecure property.
        /// </summary>
        public ThreeDSecureResponse ThreeDSecure { get; set; }

        // <summary>
        /// Links property.
        /// </summary>
        public List<Link> Links { get; set; }
    }
}
