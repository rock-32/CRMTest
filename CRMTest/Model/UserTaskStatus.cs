namespace CRMTest.Model
{
    public class UserTaskStatus
    {
        public int Id {  get; set; }
        public string StatusTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<UserTask> tasks { get; set; }
    }
}
