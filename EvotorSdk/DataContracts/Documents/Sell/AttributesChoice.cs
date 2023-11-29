using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class AttributesChoice
    {
        [DataMember(Name = "attribute_id")]
        public string AttributeId { get; set; }

        [DataMember(Name = "attribute_name")]
        public string AttributeName { get; set; }

        [DataMember(Name = "choice_id")]
        public string ChoiceId { get; set; }

        [DataMember(Name = "choice_value")]
        public string ChoiceValue { get; set; }
    }
}
