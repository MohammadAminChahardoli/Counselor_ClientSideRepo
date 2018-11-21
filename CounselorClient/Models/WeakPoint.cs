using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class WeakPoint
    {
        public int Id { get; set; }
        public string Title { get; set; }

        internal PersonalityType PersonalityType
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
