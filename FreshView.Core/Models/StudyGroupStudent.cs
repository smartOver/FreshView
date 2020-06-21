using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class StudyGroupStudent
    {
        public Guid StudyGroupId { get; set; }
        public Guid StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual StudyGroup StudyGroup { get; set; }
    }
}
