namespace CRMTest.Model
{
    public class RolePermission
    {
        public int Id { get; set; }
        public int role_id {  get; set; }
        public int permission_id { get; set; }
        public bool CanView {  get; set; }
        public bool CanEdit {  get; set; }
        public bool CanDelete {  get; set; }
        public bool CanAdd {  get; set; }
        public int client_id {  get; set; }

        public UserRole user_role { get; set; }
        public Permissions permissions { get; set; }
        public Client client { get; set; }
    }
}
