namespace CRMTest.Model
{
    public class LeadCallHistory
    {
        public int Id {  get; set; }
        public int lead_id {  get; set; }
        public Leads leads { get; set; }
        public int agent_id {  get; set; }
        public Staffs staffs { get; set; }
        public DateTime CallDateTime { get; set; }
        public string RecordedFile {  get; set; }
        public DateTime StartedTime {  get; set; }
        public DateTime EndedTime {  get; set; }

    }
}
