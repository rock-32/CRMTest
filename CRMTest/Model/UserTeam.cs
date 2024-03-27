namespace CRMTest.Model
{
    public class UserTeam
    {
        public int Id { get; set; }
        public int user_id {  get; set; }
        public int leader_id {  get; set; }
        public User user { get; set; }
    }
}
