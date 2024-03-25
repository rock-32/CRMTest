namespace CRMTest.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Leads> leads { get; set; }
        public List<Campaign> campaigns { get; set; }
        public List<User> users { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
        public List<LeadQualification> leadQualifications { get; set; }
        public List<ClientFeedback> clientFeedbacks { get; set; }
    }
}
