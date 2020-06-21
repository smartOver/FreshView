using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Course
    {
        public Course()
        {
            ScientificWork = new HashSet<ScientificWork>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CompetencyLevelIncrease { get; set; }
        public bool IsExternalMembers { get; set; }
        public int StatusIndicator { get; set; }
        public Guid? CourseType { get; set; }
        public Guid? Speciality { get; set; }
        public Guid? EducationalProgram { get; set; }

        public virtual CourseType CourseTypeNavigation { get; set; }
        public virtual EducationalProgram EducationalProgramNavigation { get; set; }
        public virtual Speciality SpecialityNavigation { get; set; }
        public virtual ICollection<ScientificWork> ScientificWork { get; set; }
    }
}
