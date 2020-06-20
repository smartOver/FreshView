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
    /// Предприятие.
    /// </summary>
    public class Company
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
        /// Адрес.
        /// </summary>
        public string Address { get; set; } = "";
    }
}
