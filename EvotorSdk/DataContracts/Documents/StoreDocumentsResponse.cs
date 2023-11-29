using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents
{
    [DataContract]
    public class StoreDocumentsResponse
    {
        [DataMember(Name = "items")]
        public StoreDocumentItemResponse[] Items { get; set; }

        [DataMember(Name = "paging")]
        public PagingItemResponse Paging { get; set; }
    }
}
