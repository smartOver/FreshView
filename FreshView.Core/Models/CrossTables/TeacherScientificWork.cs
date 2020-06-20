using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    public class TeacherScientificWork
    {
        public Guid TeacherId { get; set; }
        public Guid ScientificWorkId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ScientificWork ScientificWork { get; set; }
    }
}
