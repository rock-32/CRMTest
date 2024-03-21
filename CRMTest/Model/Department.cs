namespace CRMTest.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int Client_Id { get; set; }
        public Client clients { get; set; }
    }
}
