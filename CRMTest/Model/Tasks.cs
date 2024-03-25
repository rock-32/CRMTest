namespace CRMTest.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        public DateTime ScheduleDate { get; set; }
        public int created_by { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User staff { get; set; }
        public List<UserTask> stafftask {  get; set; } 
    }
}
