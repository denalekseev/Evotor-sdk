using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class Position
    {
        [DataMember(Name = "agent_requisites")]
        public AgentRequisites AgentRequisites { get; set; }

        [DataMember(Name = "product_id")]
        public string ProductId { get; set; }

        [DataMember(Name = "attributes_choices")]
        public IList<AttributesChoice> AttributesChoices { get; set; }

        [DataMember(Name = "quantity")]
        public decimal Quantity { get; set; }

        [DataMember(Name = "initial_quantity")]
        public decimal InitialQuantity { get; set; }

        [DataMember(Name = "quantityInPackage")]
        public int QuantityInPackage { get; set; }

        [DataMember(Name = "product_type")]
        public string ProductType { get; set; }

        [DataMember(Name = "mark")]
        public object Mark { get; set; }

        [DataMember(Name = "alcohol_by_volume")]
        public decimal AlcoholByVolume { get; set; }

        [DataMember(Name = "alcohol_product_kind_code")]
        public decimal AlcoholProductKindCode { get; set; }

        [DataMember(Name = "tare_volume")]
        public decimal TareVolume { get; set; }

        [DataMember(Name = "settlement_method")]
        public SettlementMethod SettlementMethod { get; set; }

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "bar_сode")]
        public object BarСode { get; set; }

        [DataMember(Name = "product_name")]
        public string ProductName { get; set; }

        [DataMember(Name = "measure_name")]
        public object MeasureName { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "uuid")]
        public string Uuid { get; set; }

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

        [DataMember(Name = "tax")]
        public Tax Tax { get; set; }

        [DataMember(Name = "doc_distributed_discount")]
        public DocDistributedDiscount DocDistributedDiscount { get; set; }

        [DataMember(Name = "position_discount")]
        public PositionDiscount PositionDiscount { get; set; }

        [DataMember(Name = "extra_keys")]
        public IList<ExtraKey> ExtraKeys { get; set; }

        [DataMember(Name = "print_group_id")]
        public string PrintGroupId { get; set; }

        [DataMember(Name = "splitted_positions")]
        public IList<SplittedPosition> SplittedPositions { get; set; }

        [DataMember(Name = "sub_positions")]
        public IList<SubPosition> SubPositions { get; set; }
    }
}
