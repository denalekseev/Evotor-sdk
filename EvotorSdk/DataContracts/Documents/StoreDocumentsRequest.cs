using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents
{
    [DataContract]
    public class StoreDocumentsRequest
    {
        [DataMember(Name = "since")]
        public long? Since { get; set; }

        [DataMember(Name = "until")]
        public long? Until { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "cursor")]
        public string Cursor { get; set; }

    }
}
