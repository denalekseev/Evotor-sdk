using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Employees
{
    [DataContract]
    public class EmployeeItemResponse
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "patronymic_name")]
        public string PatronymicName { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "stores")]
        public IList<string> Stores { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }

        [DataMember(Name = "role_id")]
        public string RoleID { get; set; }

        [DataMember(Name = "user_id")]
        public string UserID { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
