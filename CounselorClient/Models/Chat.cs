using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class Chat
    {
        public int Id { get; set; }
        public List<Message> Messages { get; set; }
    }
}
