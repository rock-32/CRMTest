namespace CRMTest.Model
{
    public class Permissions
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RolePermission rolePermission { get; set; }
    }
}
