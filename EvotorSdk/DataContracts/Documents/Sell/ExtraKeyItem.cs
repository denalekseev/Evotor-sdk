using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class ExtraKeyItem
    {
        [DataMember(Name = "identity")]
        public string Identity { get; set; }

        [DataMember(Name = "app_id")]
        public string AppId { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
