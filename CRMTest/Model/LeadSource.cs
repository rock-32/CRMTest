namespace CRMTest.Model
{
    public class LeadSource
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
        public List<Leads> leads { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Campaign> campaigns { get; set; }
    }
}
