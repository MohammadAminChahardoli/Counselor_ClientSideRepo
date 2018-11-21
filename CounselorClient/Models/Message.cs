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
        public string Text { get; set; }
        public string Date { get; set; }

        internal Chat Chat
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
