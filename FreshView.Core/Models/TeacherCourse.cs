using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class TeacherCourse
    {
        public Guid TeacherId { get; set; }
        public Guid CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
