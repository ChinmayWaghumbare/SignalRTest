//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Microsoft.AspNet.SignalR;

//namespace SignalRTest1
//{
//    public class ChatHub : Hub
//    {
//        public void Hello()
//        {D:\Chinmay\SignalRTest1\SignalRTest1\index.html
//            Clients.All.hello();
//        }
//    }
//}


using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRTest1
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}
