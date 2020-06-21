using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Speciality
    {
        public Speciality()
        {
            Course = new HashSet<Course>();
            Grade = new HashSet<Grade>();
            Student = new HashSet<Student>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? EducationalProgram { get; set; }
        public int VacansiesCountHh { get; set; }
        public decimal AverageSalary { get; set; }
        public int VacansiesCountInRegion { get; set; }
        public int AverageSalaryInRegion { get; set; }

        public virtual EducationalProgram EducationalProgramNavigation { get; set; }
        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<Grade> Grade { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
