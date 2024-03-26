namespace CRMTest.Model
{
    public class ClientAddressInfo
    {
        public int Id {  get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Client client { get; set; }
    }
}
