using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class EducationalProgram
    {
        public EducationalProgram()
        {
            Course = new HashSet<Course>();
            Speciality = new HashSet<Speciality>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProgramsCode { get; set; }
        public string Description { get; set; }
        public string StandartsDescription { get; set; }
        public int StatusIndicator { get; set; }

        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<Speciality> Speciality { get; set; }
    }
}
