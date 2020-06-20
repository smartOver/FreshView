using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    public class CourseTeacher
    {
        public Guid CourseId { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
