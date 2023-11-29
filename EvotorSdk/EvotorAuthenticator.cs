using EvotorSdk.DataContracts;
using Restub;

namespace EvotorSdk
{
    /// <summary>
    /// Evotor API authenticator using credentials.
    /// </summary>
    internal class EvotorAuthenticator : Authenticator<EvotorClient, EvotorAuthToken>
    {
        public EvotorAuthenticator(EvotorClient apiClient, EvotorCredentials credentials)
            : base(apiClient, credentials)
        {
        }

        public override void InitAuthHeaders(EvotorAuthToken authToken) =>
            AuthHeaders["Authorization"] = $"{authToken.Token}";
    }
}
