namespace CRMTest.Model
{
    public class LeadDocuments
    {
        public int Id { get; set; }
        public string DocumentType { get; set; }
        public string Document { get; set; }
        public int lead_id { get; set; }
        public Leads leads { get; set; }
    }
}
