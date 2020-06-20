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
    /// Компетенция.
    /// </summary>
    public class Competence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        [Required]
        /// <summary>
        /// Шифр.
        /// </summary>
        public string Code { get; set; } = "";
        [Required]
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; } = "";
    }
}
