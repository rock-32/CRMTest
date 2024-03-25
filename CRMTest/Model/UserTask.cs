namespace CRMTest.Model
{
    public class UserTask
    {
        public int Id { get; set; }
        public int task_id { get; set; }
        public Tasks tasks { get; set; }
        public int user_id { get; set; }
        public User user { get; set; }
        public int status_id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserTaskStatus status { get; set; }
        public List<TasksHistory> tasksHistories { get; set; }  
    }
}
