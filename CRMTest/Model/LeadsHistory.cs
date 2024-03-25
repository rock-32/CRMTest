namespace CRMTest.Model
{
    public class LeadsHistory
    {
        public int Id { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int updated_by { get; set; }
        public int lead_id { get; set; }
        public Leads lead { get; set; }
        public string Description { get; set; }
        public User user { get; set; }
    }
}
