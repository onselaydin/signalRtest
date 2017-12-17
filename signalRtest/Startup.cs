using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly:OwinStartup(typeof(signalRtest.Startup))]
namespace signalRtest
{
    public class Startup
    {
        public void Configuration(IAppBuilder App)
        {
            App.MapSignalR();
        }
    }
}