using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class AgentRequisites
    {
        [DataMember(Name = "counterparty_indexes")]
        public IList<int> CounterpartyIndexes { get; set; }

        [DataMember(Name = "operation_description")]
        public string OperationDescription { get; set; }
    }
}
