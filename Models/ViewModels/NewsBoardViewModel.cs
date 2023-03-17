namespace Lab4v2.Models.ViewModels
{
    public class NewsBoardViewModel
    {
        public IEnumerable<NewsBoard> Title { get; set; }
        public IEnumerable<NewsBoard> Fee { get; set; }
        public IEnumerable<Subscription> Subscriptions { get; set; }
        public IEnumerable<NewsBoard> NewsBoards { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
