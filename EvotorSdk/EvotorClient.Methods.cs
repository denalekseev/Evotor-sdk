using EvotorSdk.DataContracts;
using EvotorSdk.DataContracts.Documents;
using RestSharp;
using Restub.Toolbox;

namespace EvotorSdk
{
    /// <remarks>
    /// Evotor API Client, methods.
    /// </remarks>
    public partial class EvotorClient
    {
        /// <summary>
        /// Получить список магазинов
        /// https://developer.evotor.ru/docs/rest_stores.html
        /// </summary>
        public StoresResponse GetStores() =>
            Get<StoresResponse>("/stores", InitRequest);

        public void InitRequest(IRestRequest initReq)
        {
            initReq.AddHeader("Content-Type", "application/vnd.evotor.v2+json");
            initReq.AddHeader("Accept", "application/vnd.evotor.v2+json");
        }

        public void AddQueryString(StoreDocumentsRequest req, IRestRequest initReq)
        {
            InitRequest(initReq);
            initReq.AddQueryString(req);
        }

        /// <summary>
        /// Получить список документов
        /// https://developer.evotor.ru/docs/rest_api_get_store_documents.html
        /// </summary>
        public StoreDocumentsResponse GetStoreDocuments(string storeID, StoreDocumentsRequest request) =>
            Get<StoreDocumentsResponse>($"/stores/{storeID}/documents", r => AddQueryString(request, r));

    }
}