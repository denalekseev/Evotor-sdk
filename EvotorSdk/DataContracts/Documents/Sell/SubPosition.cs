using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class SubPosition
    {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "uuid")]
        public string Uuid { get; set; }

        [DataMember(Name = "product_id")]
        public string ProductId { get; set; }

        [DataMember(Name = "product_name")]
        public string ProductName { get; set; }

        [DataMember(Name = "product_type")]
        public string ProductType { get; set; }

        [DataMember(Name = "measure_name")]
        public object MeasureName { get; set; }

        [DataMember(Name = "initial_quantity")]
        public decimal InitialQuantity { get; set; }

        [DataMember(Name = "quantity")]
        public decimal Quantity { get; set; }

        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        [DataMember(Name = "cost_price")]
        public decimal CostPrice { get; set; }

        [DataMember(Name = "result_price")]
        public decimal ResultPrice { get; set; }

        [DataMember(Name = "sum")]
        public decimal Sum { get; set; }

        [DataMember(Name = "result_sum")]
        public decimal ResultSum { get; set; }

        [DataMember(Name = "alcohol_by_volume")]
        public decimal AlcoholByVolume { get; set; }

        [DataMember(Name = "alcohol_product_kind_code")]
        public decimal AlcoholProductKindCode { get; set; }
    }

}
