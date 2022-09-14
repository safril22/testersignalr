using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Microsoft.AspNet.SignalR;

namespace TesterSentToSAP2.Class
{
    public class Test
    {
        public void testTxt()
        {
            //ChatHub obj = new ChatHub();

            var hubcontext = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();

            for(int i = 0; i < 10000; i++) // diganti dengan perdata
            {
                var presentage = "50%";
                hubcontext.Clients.All.TestSend("test name", "On Progress " + presentage);
            }

            //obj.Send("test name", "test message");
        }
    }
}