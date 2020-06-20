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
    /// Тип курса.
    /// </summary>
    public class CourseType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        /// <summary>
        /// Тип.
        /// </summary>
        public string Name { get; set; }
        // TODO: Заполнить таблицу значениями: общеобразовательный, специальный
    }
}
