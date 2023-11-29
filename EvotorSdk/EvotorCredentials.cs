using EvotorSdk.DataContracts;
using Restub;

namespace EvotorSdk
{
    /// <summary>
    /// Evotor API Credentials.
    /// </summary>
    public class EvotorCredentials : Credentials<EvotorClient, EvotorAuthToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvotorCredentials"/> class.
        /// </summary>
        public EvotorCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvotorCredentials"/> class.
        /// </summary>
        /// <param name="clientAccount">Client account.</param>
        /// <param name="clientSecret">Client secret.</param>
        public EvotorCredentials(string token)
        {
            Token = token;
        }

        /// <summary>
        /// Gets or sets token
        /// </summary>
        public string Token { get; set; }

        public override EvotorAuthToken Authenticate(EvotorClient client)
        {
            return new EvotorAuthToken()
            {
                Token = this.Token,
            };
        }
    }
}
