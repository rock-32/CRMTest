namespace CRMTest.Model
{
    public class LeadCampaign
    {
        public int Id { get; set; }
        public int lead_id { get; set; }
        public int campaign_id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public Leads leads { get; set; }
        public Campaign campaign { get; set; }


    }
}
