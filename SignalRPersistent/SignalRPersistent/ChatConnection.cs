using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Web.Script.Serialization;

namespace SignalRPersistent
{
    public class ChatConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            var json = new JavaScriptSerializer().Serialize("Salman Local Server!!");
            var x = new GpsCoordinates();
            return Connection.Send(connectionId, x);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            var gps = new JavaScriptSerializer().Deserialize<GpsCoordinates>(data);
            return Connection.Broadcast(gps);
        }
    } 

    public class GpsCoordinates
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}