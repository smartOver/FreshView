using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class CourseStudyGroup
    {
        public Guid CourseId { get; set; }
        public Guid StudyGroupId { get; set; }

        public virtual Course Course { get; set; }
        public virtual StudyGroup StudyGroup { get; set; }
    }
}
