namespace WebServer.Models
{
    public class Chat
    {
        public int Id { get; set; }

        public List<User> UserList { get; set; }

        public string Name { get; set; }
    }
}
