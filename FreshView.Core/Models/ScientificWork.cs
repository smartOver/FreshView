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
    /// Научная работа.
    /// </summary>
    public class ScientificWork
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
        /// Дата публикации.
        /// </summary>
        public DateTime PublicationDate { get; set; } = new DateTime(2000, 1, 1);
        [Required]
        /// <summary>
        /// Тематика.
        /// </summary>
        public string Subject { get; set; } = "";
        [Required]
        /// <summary>
        /// Направление.
        /// </summary>
        public Guid CourseId { get; set; }
        [Required]
        /// <summary>
        /// Ключевые слова.
        /// </summary>
        public string Keywords { get; set; } = "";
#warning Может сделать как отдельную таблицу + кросстаблица для удобства поиска? На будущее.
        [Required]
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; } = "";
        [Required]
        /// <summary>
        /// Аннотация.
        /// </summary>
        public string Annotation { get; set; } = "";

        public virtual Course Course { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
