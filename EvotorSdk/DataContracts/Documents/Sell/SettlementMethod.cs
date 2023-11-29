using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class SettlementMethod
    {
        [DataMember(Name = "amount")]
        public int Amount { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
