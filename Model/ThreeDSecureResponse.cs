
namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// ThreeDsResponse class.
    /// </summary>
    public class ThreeDSecureResponse : ResponseBase
    {
        /// <summary>
        /// Embedded property.
        /// </summary>
        public bool Embedded { get; set; }

        /// <summary>
        /// Cavv property.
        /// </summary>
        public string Cavv { get; set; }

        /// <summary>
        /// Eci property.
        /// </summary>
        public string Eci { get; set; }

        /// <summary>
        /// Url property.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Xid property.
        /// </summary>
        public string Xid { get; set; }
    }
}
