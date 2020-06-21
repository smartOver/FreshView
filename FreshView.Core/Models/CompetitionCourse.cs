using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class CompetitionCourse
    {
        public Guid CompetitionId { get; set; }
        public Guid CourseId { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual Course Course { get; set; }
    }
}
