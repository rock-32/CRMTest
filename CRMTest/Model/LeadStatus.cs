namespace CRMTest.Model
{
    public class LeadStatus
    {
        public int Id { get; set; }
        public string StatusTitle { get; set; }
        public List<Leads> leads { get; set; }
    }
}
