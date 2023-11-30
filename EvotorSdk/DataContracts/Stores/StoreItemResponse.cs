using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts
{
    [DataContract]
    public class StoreItemResponse
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "user_id")]
        public string UserID { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
