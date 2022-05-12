namespace WebServer.Models
{
    public class Sign
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
