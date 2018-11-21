using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class JobSuggestion
    {
        public List<JobGroup> JobGroups { get; set; }
        public PersonalityType PersonalityType { get; set; }
    }
}
