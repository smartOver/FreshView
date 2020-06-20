using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    public class CourseStudyGroup
    {
        public Guid CourseId { get; set; }
        public Guid StudyGroupId { get; set; }

        public virtual Course Course { get; set; }
        public virtual StudyGroup StudyGroup { get; set; }
    }
}
