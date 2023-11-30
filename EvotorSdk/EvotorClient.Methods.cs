using EvotorSdk.DataContracts;
using EvotorSdk.DataContracts.Documents;
using EvotorSdk.DataContracts.Employees;
using EvotorSdk.DataContracts.Stores;
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
        public StoresResponse GetStores(StoresRequest request) =>
            Get<StoresResponse>("/stores", r => AddQueryString(request, r));

        /// <summary>
        /// Получить список сотрудников
        /// https://developer.evotor.ru/docs/rest_employees.html
        /// </summary>
        public EmployeesResponse GetEmployees(EmployeesRequest request) =>
            Get<EmployeesResponse>("/employees", r => AddQueryString(request, r));


        /// <summary>
        /// Получить список документов
        /// https://developer.evotor.ru/docs/rest_api_get_store_documents.html
        /// </summary>
        public StoreDocumentsResponse GetStoreDocuments(string storeID, StoreDocumentsRequest request) =>
            Get<StoreDocumentsResponse>($"/stores/{storeID}/documents", r => AddQueryString(request, r));

        public void InitRequest(IRestRequest initReq)
        {
            initReq.AddHeader("Content-Type", "application/vnd.evotor.v2+json");
            initReq.AddHeader("Accept", "application/vnd.evotor.v2+json");
        }

        public void AddQueryString(object req, IRestRequest initReq)
        {
            InitRequest(initReq);
            initReq.AddQueryString(req);
        }
    }
}