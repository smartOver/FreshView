using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    public class CourseCompetence
    {
        public Guid CourceId { get; set; }
        public Guid CompetenceId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Competence Competence { get; set; }
    }
}
