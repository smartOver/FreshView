using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class TeacherScientificWork
    {
        public Guid TeacherId { get; set; }
        public Guid ScientificWorkId { get; set; }

        public virtual ScientificWork ScientificWork { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
