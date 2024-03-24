namespace CRMTest.Model
{
    public class TasksHistory
    {
        public int Id { get; set; }
        public int stafftask_id {  get; set; }
        public StaffTask staffTask { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int updated_by { get; set; }
        public Staffs staff { get; set; }
    }
}
