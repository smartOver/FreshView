using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    public class CompetitionTeacher
    {
        public Guid CompetitionId { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
