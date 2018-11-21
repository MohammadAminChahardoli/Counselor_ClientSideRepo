using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class JobGroup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Job> Jobs { get; set; }

        internal JobSuggestion JobSuggestion
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
