using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvotorSdk.DataContracts.Documents.Sell
{
    [DataContract]
    public class PosPrintResultItem
    {
        [DataMember(Name = "print_group_id")]
        public string PrintGroupId { get; set; }

        [DataMember(Name = "receipt_number")]
        public int ReceiptNumber { get; set; }

        [DataMember(Name = "document_number")]
        public int DocumentNumber { get; set; }

        [DataMember(Name = "session_number")]
        public int SessionNumber { get; set; }

        [DataMember(Name = "check_sum")]
        public int CheckSum { get; set; }

        [DataMember(Name = "receipt_date")]
        public string ReceiptDate { get; set; }

        [DataMember(Name = "fn_serial_number")]
        public string FnSerialNumber { get; set; }

        [DataMember(Name = "kkt_serial_number")]
        public string KktSerialNumber { get; set; }

        [DataMember(Name = "kkt_reg_number")]
        public string KktRegNumber { get; set; }

        [DataMember(Name = "fiscal_sign_doc_number")]
        public string FiscalSignDocNumber { get; set; }

        [DataMember(Name = "fiscal_document_number")]
        public int FiscalDocumentNumber { get; set; }
    }
}
