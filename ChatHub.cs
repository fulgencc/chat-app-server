using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    public void SendToAll(string name, string message)
    {
        Clients.All.SendAsync("sendtoall", name, message);
    }

    public void AddNewUser(string userName)
    {
        Clients.All.SendAsync("newuserconnected", userName);
    }

    public void UserDisconnected(string userName)
    {
        Clients.All.SendAsync("userdisconnected");
    }

    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception exception)
    {
        return base.OnDisconnectedAsync(exception);
    }
}
