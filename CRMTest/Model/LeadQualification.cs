namespace CRMTest.Model
{
    public class LeadQualification
    {
        public int Id {  get; set; }
        public string Qualification { get; set; }
        public List<Leads> leads { get; set; }
        public int client_id {  get; set; }
        public Client client { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
