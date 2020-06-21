using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Department
    {
        public Department()
        {
            Student = new HashSet<Student>();
            Teacher = new HashSet<Teacher>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
