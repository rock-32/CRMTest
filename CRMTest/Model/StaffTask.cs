namespace CRMTest.Model
{
    public class StaffTask
    {
        public int Id { get; set; }
        public int task_id { get; set; }
        public Tasks tasks { get; set; }
        public int staff_id { get; set; }
        public Staffs staffs { get; set; }
        public int status_id { get; set; }
        public StaffTaskStatus status { get; set; }
        public List<TasksHistory> tasksHistories { get; set; }  
    }
}
