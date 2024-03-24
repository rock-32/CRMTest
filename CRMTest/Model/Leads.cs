namespace CRMTest.Model
{
    public class Leads
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int created_by { get; set; }
        public DateTime CreatedAt { get; set; }
        public int updated_by { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime NextFollowUp { get; set; }
        public string FollowUpNote { get; set; }
        public int source_id { get; set; }
        public LeadSource sources { get; set; }
        public int status_id { get; set; }
        public LeadStatus status { get; set; }
        public int client_id { get; set; }
        public Client client { get; set; }
        public int staff_id { get; set; }
        public Staffs staffs { get; set; }
        public int qualification_id {  get; set; }
        public LeadQualification leadQualification { get; set; }
        public int campaign_id { get; set; }
        public Campaign campaign { get; set; }
        public List<LeadsHistory> leadsHistories { get; set; }
        public List<LeadCallHistory> leadCallHistories { get; set; }
    }
}
