﻿//using System;
//using System.Threading.Tasks;
//using Microsoft.Owin;
//using Owin;

//[assembly: OwinStartup(typeof(SignalRTest1.Startup))]

//namespace SignalRTest1
//{
//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
//        }
//    }
//}


using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(SignalRTest1.Startup))]
namespace SignalRTest1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}   