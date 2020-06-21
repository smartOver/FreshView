using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class EducationalProgramCourse
    {
        public Guid EducationalProgramId { get; set; }
        public Guid CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual EducationalProgram EducationalProgram { get; set; }
    }
}
