namespace CRMTest.Model
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Amount {  get; set; }
        public int Validity { get; set; }
        public List<ClientSubscription> clientSubscriptions { get; set; }
    }
}
