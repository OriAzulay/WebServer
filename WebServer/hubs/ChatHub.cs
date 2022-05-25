using Microsoft.AspNetCore.SignalR;
namespace WebServer.SignalR.hubs
{
    public class ChatHub : Hub
    {
        public async Task Changed(string value)
        {
            await Clients.All.SendAsync("ChangeReceived", value);
        }
    }
}

