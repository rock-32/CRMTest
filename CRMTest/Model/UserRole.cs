namespace CRMTest.Model
{
    public class UserRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<User> staffs { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int client_id {  get; set; }
        public Client client { get; set; }

        public RolePermission rolePermission { get; set; }
    }
}
