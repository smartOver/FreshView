using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Teacher
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string University { get; set; }
        public string Position { get; set; }
        public int WorkExperience { get; set; }
        public int WorkExperienceInSpeciality { get; set; }
        public bool IsExternalWork { get; set; }
        public int PartTimeWorkExperience { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicRank { get; set; }
        public int WorksCountPerYear { get; set; }
        public decimal Hindex { get; set; }
        public string ExternalWorkAddress { get; set; }
        public string Comment { get; set; }
        public string Company { get; set; }
        public Guid? Department { get; set; }
        public Guid? TeachersCategory { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual TeachersCategory TeachersCategoryNavigation { get; set; }
    }
}
