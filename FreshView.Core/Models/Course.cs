using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Курс.
    /// </summary>
    public class Course
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Уровень увеличения компетенции.
        /// </summary>
        public double CompetencyLevelIncrease { get; set; }
        /// <summary>
        /// Наличие внешних участников.
        /// </summary>
        public bool IsExternalMembers { get; set; }
        public Guid CourseTypeId { get; set; }

        public virtual CourseType CourseType { get; set; }
        // TODO: Программа, ссылка.
        // TODO: Преподаватель, ссылка.
        // TODO: Учебные группы, многие ко многим
        // TODO: Компетенции (многие ко многим)
        // TODO: Текущее состояние, индикатор
    }
}
