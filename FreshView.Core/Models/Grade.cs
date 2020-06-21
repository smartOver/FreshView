using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Grade
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public Guid? GradeType { get; set; }
        public Guid? Teacher { get; set; }
        public Guid? Student { get; set; }
        public Guid? Speciality { get; set; }

        public virtual GradeType GradeTypeNavigation { get; set; }
        public virtual Speciality SpecialityNavigation { get; set; }
    }
}
