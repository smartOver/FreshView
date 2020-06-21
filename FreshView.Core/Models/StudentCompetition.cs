using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class StudentCompetition
    {
        public Guid StudentId { get; set; }
        public Guid CompetitionId { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual Student Student { get; set; }
    }
}
