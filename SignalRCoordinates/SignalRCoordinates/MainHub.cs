using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRCoordinates
{
    public class MainHub : Hub
    {
        public void Send(string name)
        {
            Clients.All.broadcastMessage(name);
        }
    }
}