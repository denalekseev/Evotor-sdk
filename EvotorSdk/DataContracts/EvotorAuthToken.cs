using System.Runtime.Serialization;
using Restub.DataContracts;

namespace EvotorSdk.DataContracts
{
    [DataContract]
    public class EvotorAuthToken : AuthToken
    {
        [DataMember(Name = "token")]
        public string Token { get; set; } // "';.\;..."
    }
}
