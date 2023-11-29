using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class PositionDiscount
    {
        [DataMember(Name = "discount_type")]
        public string DiscountType { get; set; }

        [DataMember(Name = "discount_sum")]
        public decimal DiscountSum { get; set; }

        [DataMember(Name = "discount_percent")]
        public decimal DiscountPercent { get; set; }

        [DataMember(Name = "discount_price")]
        public decimal DiscountPrice { get; set; }
    }
}
