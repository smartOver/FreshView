using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class CourseStudyCompetence
    {
        public Guid CourseId { get; set; }
        public Guid CompetenceId { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Course Course { get; set; }
    }
}
