namespace Lab4v2.Models
{
    public class Subscription
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string NewsBoardId { get; set; }
        public NewsBoard NewsBoard { get; set; }

    }
}
