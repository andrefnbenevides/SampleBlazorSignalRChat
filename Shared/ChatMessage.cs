using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlazorSignalRChat.Shared
{
    public class ChatMessage
    {
        public DateTime Timestamp { get; set; }
        public string Username { get; set; }
        public string Text { get; set; }

    }
}
