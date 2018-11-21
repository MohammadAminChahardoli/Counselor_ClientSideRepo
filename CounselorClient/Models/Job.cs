using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }

        internal JobGroup JobGroup
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
