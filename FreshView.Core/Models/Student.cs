using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Студент.
    /// </summary>
    public class Student
    {
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
        /// Специальность.
        /// </summary>
        public Guid SpecialityId { get; set; }
        // TODO: Конкурсы.
        // TODO: Оценки на курсах.
        /// <summary>
        /// Номер группы.
        /// </summary>
        public int? GroupNumber { get; set; }
        /// <summary>
        /// Кафедра.
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Рейтинг.
        /// </summary>
        public double Rating { get; set; }

        public virtual Speciality Speciality { get; set; }
    }
}
