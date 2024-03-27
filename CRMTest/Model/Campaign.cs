namespace CRMTest.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int client_id { get; set; }
        public Client clients { get; set; }
        public List<Leads> leads { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
        public int created_by { get; set; }
        public User user { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public float Coast {  get; set; }
        public int source_id { get; set; }
        public Source leadSource { get; set; }
        public List<LeadCampaign> leadCampaigns { get; set; }
    }
}
