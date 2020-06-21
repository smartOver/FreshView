using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class CompetitionTeacher
    {
        public Guid CompetitionId { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
