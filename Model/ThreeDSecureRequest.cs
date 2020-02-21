
namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// ThreeDsRequest class.
    /// </summary>
    public class ThreeDSecureRequest
    {
        /// <summary>
        /// Embedded property.
        /// </summary>
        public bool? Embedded { get; set; }

        /// <summary>
        /// Cavv property.
        /// </summary>
        public string Cavv { get; set; }

        /// <summary>
        /// Eci property.
        /// </summary>
        public string Eci { get; set; }

        /// <summary>
        /// Xid property.
        /// </summary>
        public string Xid { get; set; }

        /// <summary>
        /// OnFailure property.
        /// </summary>
        public ThreeDSecureOnFailure OnFailure { get; set; }

        /// <summary>
        /// UserAgent property.
        /// </summary>
        public string UserAgent { get; set; }
    }
}
