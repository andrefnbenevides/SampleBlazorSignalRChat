using Microsoft.AspNetCore.SignalR;
using SampleBlazorSignalRChat.Shared.Constants;

namespace SampleBlazorSignalRChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        private static Dictionary<string, string> Users = new Dictionary<string, string>();

        public override async Task OnConnectedAsync()
        {
            string username = Context.GetHttpContext().Request.Query["username"];
            Users.Add(Context.ConnectionId, username);

            await SendMessage(string.Empty, $"{username} has connected to your channel!");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            string username = Users.FirstOrDefault(u => u.Key == Context.ConnectionId).Value;
            await SendMessage(string.Empty, $"User: {username} has disconnected from your channel.");
            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync(Constants.ChatHubReceiveMessageMethodName, user, message);

        }
    }
}
