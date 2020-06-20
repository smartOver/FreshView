using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Преподаватель.
    /// </summary>
    public class Teacher
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
        // TODO: ВУЗ
        // TODO: Кафедра
        /// <summary>
        /// Должность.
        /// </summary>
        public string Position { get; set; }
        // TODO: Список курсов, многие ко многим
        /// <summary>
        /// Стаж работы.
        /// </summary>
        public int WorkExperience { get; set; }
        /// <summary>
        /// Стаж работы по специальности.
        /// </summary>
        public int WorkExperienceInSpeciality { get; set; }
        /// <summary>
        /// Работает вне ВУЗа.
        /// </summary>
        public bool IsExternalWork { get; set; }
        /// <summary>
        /// Стаж работы по совместительству.
        /// </summary>
        public int PartTimeWorkExperience { get; set; }
        /// <summary>
        /// Категория.
        /// </summary>
        public Guid TeachersCategoryId { get; set; }
        /// <summary>
        /// Ученая степень.
        /// </summary>
        public string AcademicDegree { get; set; }
        /// <summary>
        /// Ученое звание.
        /// </summary>
        public string AcademicRank { get; set; }
        // TODO: Научные работы, многие ко многим
        /// <summary>
        /// Число работ за год.
        /// </summary>
        public int WorksCountPerYear { get; set; }
        /// <summary>
        /// Индекс Хирша.
        /// </summary>
        public double HIndex { get; set; }
        // TODO: Пройденные курсы.
        // TODO: Конкурсы, многие ко многим.
        public string ExternalWorkAddress { get; set; }
        public string Comment { get; set; }
        // TODO: Предприятие.

        public virtual TeachersCategory TeachersCategory { get; set; }
    }
}
