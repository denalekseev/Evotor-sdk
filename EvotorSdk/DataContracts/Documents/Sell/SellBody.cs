using EvotorSdk.DataContracts.Documents.Sell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts
{
    [DataContract]
    public class SellBody
    {
        [DataMember(Name = "positions")]
        public IList<Position> Positions { get; set; }

        [DataMember(Name = "doc_discounts")]
        public IList<DocDiscount> DocDiscounts { get; set; }

        [DataMember(Name = "payments")]
        public IList<Payment> Payments { get; set; }

        [DataMember(Name = "print_groups")]
        public IList<PrintGroup> PrintGroups { get; set; }

        [DataMember(Name = "pos_print_results")]
        public IList<PosPrintResult> PosPrintResults { get; set; }

        [DataMember(Name = "sum")]
        public decimal Sum { get; set; }

        [DataMember(Name = "result_sum")]
        public decimal ResultSum { get; set; }

        [DataMember(Name = "customer_email")]
        public string CustomerEmail { get; set; }

        [DataMember(Name = "customer_phone")]
        public long CustomerPhone { get; set; }
    }
}
