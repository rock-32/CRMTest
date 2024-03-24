namespace CRMTest.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public int created_by { get; set; }
        public Staffs staff { get; set; }
        public List<StaffTask> stafftask {  get; set; } 
    }
}
