namespace CRMTest.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public int created_by { get; set; }
        public Staffs staffs { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int client_id { get; set; }
        public Client clients { get; set; }
        public List<Leads> leads { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
    }
}
