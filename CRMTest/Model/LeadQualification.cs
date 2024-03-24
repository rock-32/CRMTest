namespace CRMTest.Model
{
    public class LeadQualification
    {
        public int Id {  get; set; }
        public string Qualification { get; set; }
        public List<Leads> leads { get; set; }
    }
}
