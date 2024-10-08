﻿using Microsoft.AspNetCore.SignalR;

namespace SignalRExample.API.Services
{
    public class ChatHub : Hub, IChatHub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }

    }
}
