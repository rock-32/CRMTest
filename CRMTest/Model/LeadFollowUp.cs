namespace CRMTest.Model
{
    public class LeadFollowUp
    {
        public int Id {  get; set; }
        public DateTime NextFollowUp { get; set; }
        public string FollowUpNote { get; set; }
        public int updated_by { get; set; }
        public int lead_id { get; set; }
        public User user { get; set; }  
        public Leads lead { get; set; }
    }
}
