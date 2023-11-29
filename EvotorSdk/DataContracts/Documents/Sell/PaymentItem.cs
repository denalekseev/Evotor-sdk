using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class PaymentItem
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "sum")]
        public decimal Sum { get; set; }

        [DataMember(Name = "app_payment")]
        public AppPayment AppPayment { get; set; }

        [DataMember(Name = "parts")]
        public IList<Part> Parts { get; set; }
    }

}
