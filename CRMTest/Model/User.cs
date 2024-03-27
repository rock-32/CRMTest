using System.Data;

namespace CRMTest.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int role_id { get; set; }
        public UserRole roles { get; set; }
        public int client_id { get; set; }
        public Client clients { get; set; }
        public int userinfo_id {  get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Leads> leads { get; set; }
        public List<UserTask> stafftasks { get; set; }
        public List<Campaign> campaigns { get; set; }
        public List<LeadsHistory> leadsHistories { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
        public List<Tasks> tasks { get; set; }
        public List<LeadCallHistory> leadCallHistories { get; set; }
        public List<LeadFollowUp> leadFollowUps { get; set; }
        public UserInfo userInfo { get; set; }
        public List<UserTeam> userTeams { get; set; }
 
    }
}
