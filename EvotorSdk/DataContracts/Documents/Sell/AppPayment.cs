using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class AppPayment
    {
        [DataMember(Name = "app_id")]
        public string AppId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
