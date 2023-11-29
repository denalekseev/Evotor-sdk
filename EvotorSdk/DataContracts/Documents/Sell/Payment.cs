using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class Payment
    {
        [DataMember(Name = "payment")]
        public PaymentItem PaymentItem { get; set; }
    }
}
