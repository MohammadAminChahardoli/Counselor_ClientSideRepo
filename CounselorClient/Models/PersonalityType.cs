using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class PersonalityType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Strength> Strengths { get; set; }
        public List<WeakPoint> WeakPoints { get; set; }
    }
}
