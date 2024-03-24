namespace CRMTest.Model
{
    public class StaffRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<Staffs> staffs { get; set; }
    }
}
