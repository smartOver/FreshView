using System;
using System.Collections.Generic;
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
        public Guid Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата проведения.
        /// </summary>
        public DateTime CompetitionDate { get; set; }
#warning Что делать если несколько дат?
        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Тематика.
        /// </summary>
        public string Subject { get; set; }
        // TODO: программа
        /// <summary>
        /// Преподаватель.
        /// </summary>
        public Guid TeacherId { get; set; }
        /// <summary>
        /// Студенты.
        /// </summary>
        public List<Student> Students { get; set; }

        public virtual Teacher Teacher { get; set; }

    }
}
