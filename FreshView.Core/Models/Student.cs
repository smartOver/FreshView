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
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }
        [Required]
        /// <summary>
        /// Отчество.
        /// </summary>
        public string SecondName { get; set; }
        [Required]
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        [Required]
        /// <summary>
        /// Специальность.
        /// </summary>
        public Guid SpecialityId { get; set; }
        // TODO: Оценки на курсах.
        [Required]
        /// <summary>
        /// Группа.
        /// </summary>
        public Guid StudyGroupId { get; set; }
        [Required]
        /// <summary>
        /// Кафедра.
        /// </summary>
        public Guid DepartmentId { get; set; }
        [Required]
        /// <summary>
        /// Рейтинг.
        /// </summary>
        public double Rating { get; set; } = 50.5;
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
        public virtual Department Department { get; set; }
        public Student()
        {
            Competitions = new List<Competition>();
            Grades = new List<Grade>();
        }
    }
}
