using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EvotorSdk.DataContracts
{
    [DataContract]
    public class StoresResponse
    {
        [DataMember(Name = "items")]
        public IList<StoreItemResponse> Items { get; set; }

        [DataMember(Name = "paging")]
        public PagingItemResponse Paging { get; set; }
    }
}
