using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class PrintGroupItem
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "org_name")]
        public string OrgName { get; set; }

        [DataMember(Name = "org_inn")]
        public string OrgInn { get; set; }

        [DataMember(Name = "org_address")]
        public string OrgAddress { get; set; }

        [DataMember(Name = "taxation_system")]
        public string TaxationSystem { get; set; }
    }
}
