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
    /// Студент.
    /// </summary>
    public class Student
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
        /// Специальность.
        /// </summary>
        public Guid SpecialityId { get; set; }
        // TODO: Оценки на курсах.
        /// <summary>
        /// Группа.
        /// </summary>
        public Guid StudyGroupId { get; set; }
        /// <summary>
        /// Кафедра.
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Рейтинг.
        /// </summary>
        public double Rating { get; set; }
        /// <summary>
        /// Конкурсы.
        /// </summary>
        public List<Competition> Competitions { get; set; }
        /// <summary>
        /// Оценки.
        /// </summary>
        public List<Grade> Grades { get; set; }

        public virtual Speciality Speciality { get; set; }
        public virtual StudyGroup StudyGroup { get; set; }
    }
}
