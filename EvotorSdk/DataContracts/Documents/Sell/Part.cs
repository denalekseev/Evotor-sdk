using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class Part
    {
        [DataMember(Name = "print_group_id")]
        public string PrintGroupId { get; set; }

        [DataMember(Name = "part_sum")]
        public decimal PartSum { get; set; }

        [DataMember(Name = "change")]
        public decimal Change { get; set; }
    }
}
