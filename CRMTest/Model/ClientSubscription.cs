namespace CRMTest.Model
{
    public class ClientSubscription
    {
        public int Id { get; set; }
        public int current_subscription { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ValidUpTo { get; set; }
        public int status_id { get; set; }
        public Subscription subscription { get; set; }
        public SubscriptionStatus status {get; set;}
        public Client client { get; set; }

    }
}
