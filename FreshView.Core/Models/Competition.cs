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
    /// Конкурс.
    /// </summary>
    public class Competition
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
        /// Дата проведения.
        /// </summary>
        public DateTime CompetitionDate { get; set; } = new DateTime(2000, 1, 1);
#warning Что делать если несколько дат?
        [Required]
        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; set; } = "";
        [Required]
        /// <summary>
        /// Тематика.
        /// </summary>
        public string Subject { get; set; } = "";
        // TODO: программа
        /// <summary>
        /// Преподаватель.
        /// </summary>
        public List<Teacher> Teachers { get; set; }
        /// <summary>
        /// Студенты.
        /// </summary>
        public List<Student> Students { get; set; }
        /// <summary>
        /// Курсы.
        /// </summary>
        public List<Course> Cources { get; set; }
        public Competition()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Cources = new List<Course>();
        }
    }
}
