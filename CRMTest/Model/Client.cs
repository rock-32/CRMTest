namespace CRMTest.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Accountinfo_id { get; set; }
        public int billingInfo_id { get; set; }
        public int addressInfo_id { get; set; }
        public int subscription_id { get; set; }
        public List<Leads> leads { get; set; }
        public List<Campaign> campaigns { get; set; }
        public List<User> users { get; set; }
        public List<ClientCustomers> clientCustomers { get; set; }
        public List<LeadQualification> leadQualifications { get; set; }
        public List<ClientFeedback> clientFeedbacks { get; set; }
        public ClientAccountInfo AccountInfo { get; set; }
        public ClientBillingInfo billingInfo { get; set; }
        public ClientAddressInfo AddressInfo { get; set; }
        public ClientSubscription clientSubscription { get; set; }
        public List<Source> sources { get; set; }
        public List<CustomFields> customFields { get; set; }
      /*  public List<UserRole> userRoles { get; set; }*/
    }
}
