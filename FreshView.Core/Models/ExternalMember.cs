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
        public Guid Id { get; set; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public string SeconName { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Компания.
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Должность.
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Компания входит в топ 100.
        /// </summary>
        public bool IsInToppHundred { get; set; }
    }
}
