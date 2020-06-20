using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Студент - конкурс
    /// </summary>
    public class StudentCompetition
    {
        public Guid StudentId { get; set; }
        public Guid CompetitionId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Competition Competition { get; set; }
    }
}
