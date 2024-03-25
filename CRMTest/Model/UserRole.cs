namespace CRMTest.Model
{
    public class UserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<User> staffs { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
