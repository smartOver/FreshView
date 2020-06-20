using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Внешний участник - курс.
    /// </summary>
    public class ExternalMemberCourse
    {
        /// <summary>
        /// Курс.
        /// </summary>
        public Guid CourseId { get; set; }
        /// <summary>
        /// Внешний участник.
        /// </summary>
        public Guid ExternalMemberId { get; set; }
        /// <summary>
        /// Количество лекций.
        /// </summary>
        public int LecturesCount { get; set; }
        /// <summary>
        /// Количество заданий.
        /// </summary>
        public int TasksCount { get; set; }
        /// <summary>
        /// Оценка.
        /// </summary>
        public double Grade { get; set; }
        // TODO: На будущее иметь данные о: лекция, тема, дата, тип задания

        public virtual Course Course { get; set; }
        public virtual ExternalMember ExternalMember { get; set; }
    }
}
