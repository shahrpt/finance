using System;

namespace MixERP.Finance.QueryModels
{
    public sealed class JournalViewQuery
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public long TranId { get; set; }
        public string TranCode { get; set; }
        public string Book { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }
        public string PostedBy { get; set; }
        public string Office { get; set; }
        public string Status { get; set; }
        public string VerifiedBy { get; set; }
        public string Reason { get; set; }
    }
}