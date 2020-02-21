
namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// AuthorizationResponse class.
    /// </summary>
    public class AuthorizationResponse : ResponseBase
    {
        /// <summary>
        /// DateTime property.
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// Affiliation property.
        /// </summary>
        public string Affiliation { get; set; }

        /// <summary>
        /// Status property.
        /// </summary>
        public string Status { get; set; }

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
        /// Kind property.
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// Amount property.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Installments property.
        /// </summary>
        public int Installments { get; set; }

        /// <summary>
        /// CardHolderName property.
        /// </summary>
        public string CardHolderName { get; set; }

        /// <summary>
        /// CardBin property.
        /// </summary>
        public string CardBin { get; set; }

        /// <summary>
        /// Last4 property.
        /// </summary>
        public string Last4 { get; set; }

        /// <summary>
        /// SoftDescriptor.
        /// </summary>
        public string SoftDescriptor { get; set; }

        /// <summary>
        /// Origin property.
        /// </summary>
        public int Origin { get; set; }

        /// <summary>
        /// Subscription property.
        /// </summary>
        public bool Subscription { get; set; }

        /// <summary>
        /// DistributorAffiliation property.
        /// </summary>
        public string DistributorAffiliation { get; set; }
    }
}
