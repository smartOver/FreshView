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
    /// Задача партнеров.
    /// </summary>
    public class PartnersTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /// <summary>
        /// Курс.
        /// </summary>
        public Guid CourseId { get; set; }
        /// <summary>
        /// Предприятие.
        /// </summary>
        public Guid CompanyId { get; set; }
        public Guid TaskTypeId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Company Company { get; set; }
        public virtual TaskType TaskType { get; set; }
    }
}
