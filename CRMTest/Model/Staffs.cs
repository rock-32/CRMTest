using System.Data;

namespace CRMTest.Model
{
    public class Staffs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int role_id { get; set; }
        public StaffRole roles { get; set; }
        public int client_id { get; set; }
        public Client clients { get; set; }
        public List<Leads> leads { get; set; }
        public List<StaffTask> stafftasks { get; set; }
        public List<Campaign> campaigns { get; set; }
        public List<LeadsHistory> leadsHistories { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
        public List<Tasks> tasks { get; set; }
        public List<LeadCallHistory> leadCallHistories { get; set; }
    }
}
