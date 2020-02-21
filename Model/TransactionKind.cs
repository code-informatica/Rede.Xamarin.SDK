using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Rede.Acquiring.SDK.Rest.Model
{
    /// <summary>
    /// TransactionKind enum.
    /// </summary>
    public enum TransactionKind
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumMember(Value = "credit")] 
        Credit = 0,

        /// <summary>
        /// Debit.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [EnumMember(Value = "debit")] 
        Debit = 1,
    }
}
