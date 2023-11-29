using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts
{
    [DataContract]
    public class PagingItemResponse
    {
        [DataMember(Name = "next_cursor")]
        public string NextCursor { get; set; }
    }
}
