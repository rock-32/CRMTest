namespace CRMTest.Model
{
    public class Source
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
        public int client_id { get; set; }
        public Client client { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Campaign> campaigns { get; set; }
        public List<LeadSource> leadSources { get; set; }
        public List<Leads> leads { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
    }
}
