using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class TeachersCategory
    {
        public TeachersCategory()
        {
            Teacher = new HashSet<Teacher>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
