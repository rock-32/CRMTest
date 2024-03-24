namespace CRMTest.Model
{
    public class ClientCustomers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int source_id { get; set; }
        public LeadSource sources { get; set; }
        public int client_id { get; set; }
        public Client client { get; set; }
        public int agent_id { get; set; }
        public Staffs staffs { get; set; }
        public int campaign_id { get; set; }
        public Campaign campaign { get; set; }
    }
}
