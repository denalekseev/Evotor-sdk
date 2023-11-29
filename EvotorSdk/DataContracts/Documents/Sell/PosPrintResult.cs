using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class PosPrintResult
    {
        [DataMember(Name = "pos_print_result")]
        public PosPrintResultItem PosPrintResultItem { get; set; }
    }
}
