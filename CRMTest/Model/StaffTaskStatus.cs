namespace CRMTest.Model
{
    public class StaffTaskStatus
    {
        public int Id {  get; set; }
        public string StatusTitle { get; set; }
        public List<StaffTask> tasks { get; set; }
    }
}
