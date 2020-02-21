using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// UrlsKind enum.
    /// </summary>
    public enum UrlKind
    {
        /// <summary>
        /// ThreeDSSuccess.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumMember(Value = "ThreeDSecureSuccess")]
        ThreeDSSuccess = 0,

        /// <summary>
        /// ThreeDSFailure.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumMember(Value = "ThreeDSecureFailure")]
        ThreeDSFailure = 1,

        /// <summary>
        /// CallBack.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumMember(Value = "Callback")]
        CallBack = 2
    }
}
