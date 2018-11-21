using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Key { get; set; }

        internal Answer Answer
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
