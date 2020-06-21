using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class GradeType
    {
        public GradeType()
        {
            Grade = new HashSet<Grade>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }

        public virtual ICollection<Grade> Grade { get; set; }
    }
}
