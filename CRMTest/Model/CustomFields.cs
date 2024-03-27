namespace CRMTest.Model
{
    public class CustomFields
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string DefaultFieldName { get; set; }
        public string CustomFieldName { get; set; }
        public int client_id { get; set; }
        public Client client { get; set; }
    }
}
