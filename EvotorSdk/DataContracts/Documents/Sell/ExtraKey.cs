using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class ExtraKey
    {
        [DataMember(Name = "extra_key")]
        public ExtraKeyItem ExtraKeyItem { get; set; }
    }
}
