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
    /// Обучающая программа.
    /// </summary>
    public class EducationalProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        /// <summary>
        /// Код направления.
        /// </summary>
        public string CourcesCode { get; set; } = "";
        [Required]
        /// <summary>
        /// Название программы.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание программы.
        /// </summary>
        public string Descriptions { get; set; }
        /// <summary>
        /// Ссылка на описание стандарта.
        /// </summary>
        public string StandsrtsDescription { get; set; }
        /// <summary>
        /// Список курсов.
        /// </summary>
        public List<Course> Courses { get; set; }
        /// <summary>
        /// Индикатор состояния.
        /// </summary>
        public int StatusIdicator { get; set; }
    }
}
