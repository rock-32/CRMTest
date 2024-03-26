namespace CRMTest.Model
{
    public class ClientAccountInfo
    {
        public int Id {  get; set; }
        public string Image { get; set; }
        public string CompanyName { get; set; }
        public string ApplicationTitle { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyWebSite {  get; set; }
        public string PAN {  get; set; }
        public string GST_IN {  get; set; }
        public Client client { get; set; }
        
    }
}
