using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace WebApplication1.Hubs
{
    public class Chat : Hub
    {
        public Task Send(String Msg)
        {
            return Clients.All.InvokeAsync("Send", Msg);
        }
    }
}
