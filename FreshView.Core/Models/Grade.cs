using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Оценка.
    /// </summary>
    public class Grade
    {
        public Guid SpecialityId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid StudentId { get; set; }
        // TODO: Ментор.
        public Guid GradeTypeId { get; set; }
        /// <summary>
        /// Значение.
        /// </summary>
        public double Value { get; set; }

        public virtual Speciality Speciality { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
    }
}
