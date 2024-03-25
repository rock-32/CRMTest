namespace CRMTest.Model
{
    public class TasksHistory
    {
        public int Id { get; set; }
        public int stafftask_id {  get; set; }
        public UserTask staffTask { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int updated_by { get; set; }
        public User staff { get; set; }
    }
}
