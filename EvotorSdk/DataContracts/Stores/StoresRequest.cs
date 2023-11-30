using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Stores
{
    [DataContract]
    public class StoresRequest
    {
        [DataMember(Name = "cursor")]
        public string Cursor { get; set; }
    }
}
