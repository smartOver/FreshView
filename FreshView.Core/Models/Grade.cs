using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        /// <summary>
        /// Специальность.
        /// </summary>
        public Guid SpecialityId { get; set; }
        [Required]
        /// <summary>
        /// Преподаватель.
        /// </summary>
        public Guid TeacherId { get; set; }
        [Required]
        /// <summary>
        /// Студент.
        /// </summary>
        public Guid StudentId { get; set; }
        // TODO: Ментор.
        [Required]
        public Guid GradeTypeId { get; set; }
        [Required]
        /// <summary>
        /// Значение.
        /// </summary>
        public double Value { get; set; } = 0.0;

        public virtual Speciality Speciality { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
    }
}
