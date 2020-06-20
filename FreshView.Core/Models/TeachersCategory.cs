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
    /// Категория преподавателя.
    /// </summary>
    public class TeachersCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        // TODO: Заполнить таблицу значениями: внутренний, внешний совместитель
    }
}
