using System;
using System.Collections.Generic;
using System.Linq;
using EvotorSdk.DataContracts;
using EvotorSdk.Toolbox;
using RestSharp;
using RestSharp.Authenticators;
using Restub;
using Restub.DataContracts;

namespace EvotorSdk
{
    /// <summary>
    /// Evotor API Client.
    /// </summary>
    public partial class EvotorClient : RestubClient
    {
        /// <summary>
        /// Production API endpoint.
        /// </summary>
        public const string ProductionApiUrl = "https://api.evotor.ru/";

        /// <summary>
        /// Initializes a new instance of the <see cref="EvotorClient"/> class.
        /// </summary>
        /// <param name="baseUrl">Base API endpoint.</param>
        /// <param name="credentials">Credentials.</param>
        public EvotorClient(string baseUrl, EvotorCredentials credentials)
            : base(baseUrl, credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvotorClient"/> class.
        /// </summary>
        /// <param name="сlient">REST API client.</param>
        /// <param name="credentials">Credentials.</param>
        public EvotorClient(string baseUrl, string token)
            : base(baseUrl, new EvotorCredentials(token))
        {
        }

        public EvotorClient(string token)
            : base(ProductionApiUrl, new EvotorCredentials(token))
        {
        }

        /// <inheritdoc/>
        public override string LibraryName =>
            $"{nameof(EvotorSdk)}.{nameof(EvotorClient)} v{LibraryVersion}, {base.LibraryName}";

        /// <inheritdoc/>
        protected override IAuthenticator GetAuthenticator() =>
            new EvotorAuthenticator(this, (EvotorCredentials)Credentials);

        /// <inheritdoc/>
        protected override IRestubSerializer CreateSerializer() =>
            new EvotorSerializer();

        /// <inheritdoc/>
        protected override Exception CreateException(IRestResponse res, string msg, IHasErrors errors) =>
            new EvotorException(res.StatusCode, msg, base.CreateException(res, msg, errors))
            {
                ErrorResponseText = res.Content,
            };
    }
}