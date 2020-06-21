using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class ScientificWorkTeacher
    {
        public Guid ScientificWorkId { get; set; }
        public Guid TeacherId { get; set; }

        public virtual ScientificWork ScientificWork { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
