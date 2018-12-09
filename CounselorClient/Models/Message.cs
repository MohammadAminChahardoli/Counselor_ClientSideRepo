using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class Message
    {
        public int Id { get; set; }
        public string ChatMessageText { get; set; }
        public string ChatMessageDate { get; set; }
        public string UserIdSender { get; set; }
        public string UserIdReceiver { get; set; }
    }
}
