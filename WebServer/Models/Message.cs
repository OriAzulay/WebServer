namespace WebServer.Models
{
    public class Message
    {
        private string message;
        private string time;

        public Message(string _msg, string _time)
        {
            message = _msg;
            time = _time;   
        }
       public string content { get; set; }
        public string MsgTime { get; set; }
        
    }

}
