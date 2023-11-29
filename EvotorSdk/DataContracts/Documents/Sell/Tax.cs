using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class Tax
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "sum")]
        public int Sum { get; set; }

        [DataMember(Name = "result_sum")]
        public int ResultSum { get; set; }
    }
}
