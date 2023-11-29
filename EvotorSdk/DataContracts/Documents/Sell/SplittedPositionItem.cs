using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class SplittedPositionItem
    {
        [DataMember(Name = "quantity")]
        public decimal Quantity { get; set; }

        [DataMember(Name = "result_price")]
        public decimal ResultPrice { get; set; }

        [DataMember(Name = "result_sum")]
        public decimal ResultSum { get; set; }

        [DataMember(Name = "position_discount")]
        public decimal PositionDiscount { get; set; }

        [DataMember(Name = "doc_distributed_discount")]
        public decimal DocDistributedDiscount { get; set; }

        [DataMember(Name = "tax_type")]
        public string TaxType { get; set; }

        [DataMember(Name = "result_tax_sum")]
        public decimal ResultTaxSum { get; set; }
    }
}
