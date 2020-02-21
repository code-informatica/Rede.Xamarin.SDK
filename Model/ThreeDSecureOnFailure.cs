using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// ThreeDSecureOnFailure enum.
    /// </summary>
    public enum ThreeDSecureOnFailure
    {
        /// <summary>
        /// Continue.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumMember(Value = "continue")]
        CONTINUE = 0,

        /// <summary>
        /// Decline.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumMember(Value = "decline")]
        DECLINE = 1,
    }
}
