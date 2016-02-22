using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(SignalRPersistent.Startup))]

namespace SignalRPersistent
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //GlobalHost.Configuration.KeepAlive = TimeSpan.FromSeconds(5);

            app.MapSignalR<ChatConnection>("/echo");
        }
    }
}
