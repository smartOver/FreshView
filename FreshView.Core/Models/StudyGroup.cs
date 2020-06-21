using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class StudyGroup
    {
        public StudyGroup()
        {
            Student = new HashSet<Student>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
