using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Employees
{
    [DataContract]
    public class EmployeesResponse
    {
        [DataMember(Name = "items")]
        public IList<EmployeeItemResponse> Items { get; set; }

        [DataMember(Name = "paging")]
        public PagingItemResponse Paging { get; set; }
    }
}
