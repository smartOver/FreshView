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
    /// Внешний участник.
    /// </summary>
    public class ExternalMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }
        [Required]
        /// <summary>
        /// Отчество.
        /// </summary>
        public string SeconName { get; set; }
        [Required]
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        [Required]
        /// <summary>
        /// Компания.
        /// </summary>
        public string CompanyName { get; set; } = "";
        [Required]
        /// <summary>
        /// Должность.
        /// </summary>
        public string Position { get; set; } = "";
        [Required]
        /// <summary>
        /// Компания входит в топ 100.
        /// </summary>
        public bool IsInToppHundred { get; set; } = true;
    }
}
