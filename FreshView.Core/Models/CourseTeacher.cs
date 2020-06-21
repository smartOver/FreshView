using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class CourseTeacher
    {
        public Guid CourseId { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
