namespace CRMTest.Model
{
    public class LeadSource
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
        public List<Leads> leads { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
    }
}
