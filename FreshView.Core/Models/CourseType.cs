using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class CourseType
    {
        public CourseType()
        {
            Course = new HashSet<Course>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
