using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Student
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public Guid? Department { get; set; }
        public Guid? StudyGroup { get; set; }
        public Guid? Speciality { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual Speciality SpecialityNavigation { get; set; }
        public virtual StudyGroup StudyGroupNavigation { get; set; }
    }
}
