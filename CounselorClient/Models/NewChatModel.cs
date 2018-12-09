using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class NewChatModel
    {
        public int ChatId;
        public int UserIdStarter;
        public int UserIdSender;
        public string ChatMessageText;
        public int UserIdReciver;
    }
}
