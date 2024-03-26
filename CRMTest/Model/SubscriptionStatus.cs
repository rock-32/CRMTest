namespace CRMTest.Model
{
    public class SubscriptionStatus
    {
        public int Id { get; set; }
        public int StatusTitle { get; set; }
        public List<ClientSubscription> clientSubscriptions { get; set; }
    }
}
