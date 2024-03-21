namespace CRMTest.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignTitle { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int client_id { get; set; }
        //public Client clients { get; set; }
    }
}
