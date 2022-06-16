using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlazorSignalRChat.Shared.Constants
{
    public static class Constants
    {
        public static string ChatHubReceiveMessageMethodName = "ReceiveMessage";
        /// <summary>
        /// This method name should be exactly the same as the method that was implemented in the ChatHub class
        /// </summary>
        public static string ChatHubSendMessageMethodName = "SendMessage";
    }
}
