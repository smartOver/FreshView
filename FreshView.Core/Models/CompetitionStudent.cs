using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class CompetitionStudent
    {
        public Guid CompetitionId { get; set; }
        public Guid StudentId { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual Student Student { get; set; }
    }
}
