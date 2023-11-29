using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts
{
    [DataContract]
    public class StoreDocumentItemResponse
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "extras")]
        public object Extras { get; set; }

        [DataMember(Name = "number")]
        public int Number { get; set; }

        [DataMember(Name = "close_date")]
        public DateTime? CloseDate { get; set; }

        [DataMember(Name = "time_zone_offset")]
        public int TimeZoneOffset { get; set; }

        [DataMember(Name = "session_id")]
        public string SessionID { get; set; }
        
        [DataMember(Name = "session_number")]
        public int SessionNumber { get; set; }

        [DataMember(Name = "close_user_id")]
        public string CloseUserID { get; set; }

        [DataMember(Name = "device_id")]
        public string DeviceID { get; set; }

        [DataMember(Name = "store_id")]
         public string StoreID { get; set; }

        [DataMember(Name = "user_id")]
        public string UserID { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        ////[DataMember(Name = "body")]
        ////public object Object { get; set; }

        [DataMember(Name = "body")]
        public SellBody SellBody { get; set; }
    }
}
