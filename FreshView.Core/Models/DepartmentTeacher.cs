using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class DepartmentTeacher
    {
        public Guid DepartmentId { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
