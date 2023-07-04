using Microsoft.AspNetCore.SignalR;

namespace ASP.NET_CoreWebApp_MVC_SingalR_Chat_
{
    public class ChatHub : Hub
    {
        // Send Method
        public async Task SendMessage(string room, string user, string message)
        {
            // Who receive the message
            await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
        }

        // Send Method
        public async Task AddToGroup(string room)
        {
            // Add to group
            await Groups.AddToGroupAsync(Context.ConnectionId, room);

            // Who did connect
            await Clients.Group(room).SendAsync("ShowWho", $"Someone did connect {Context.ConnectionId}");
        }

    }
}
