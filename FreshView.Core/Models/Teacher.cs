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
    /// Преподаватель.
    /// </summary>
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }
        [Required]
        /// <summary>
        /// Отчество.
        /// </summary>
        public string SeconName { get; set; }
        [Required]
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        [Required]
        /// <summary>
        /// ВУЗ.
        /// </summary>
        public string University { get; set; } = "";
        [Required]
        /// <summary>
        /// Кафедра.
        /// </summary>
        public Guid DepartmentId { get; set; }
        [Required]
        /// <summary>
        /// Должность.
        /// </summary>
        public string Position { get; set; } = "";
        [Required]
        /// <summary>
        /// Стаж работы.
        /// </summary>
        public int WorkExperience { get; set; } = 0;
        [Required]
        /// <summary>
        /// Стаж работы по специальности.
        /// </summary>
        public int WorkExperienceInSpeciality { get; set; } = 0;
        [Required]
        /// <summary>
        /// Работает вне ВУЗа.
        /// </summary>
        public bool IsExternalWork { get; set; } = false;
        [Required]
        /// <summary>
        /// Стаж работы по совместительству.
        /// </summary>
        public int PartTimeWorkExperience { get; set; } = 0;
        [Required]
        /// <summary>
        /// Категория.
        /// </summary>
        public Guid TeachersCategoryId { get; set; }
        [Required]
        /// <summary>
        /// Ученая степень.
        /// </summary>
        public string AcademicDegree { get; set; } = "";
        [Required]
        /// <summary>
        /// Ученое звание.
        /// </summary>
        public string AcademicRank { get; set; } = "";
        [Required]
        /// <summary>
        /// Число работ за год.
        /// </summary>
        public int WorksCountPerYear { get; set; } = 0;
        [Required]
        /// <summary>
        /// Индекс Хирша.
        /// </summary>
        public double HIndex { get; set; } = 0.0;
        // TODO: Пройденные курсы.
        [Required]
        /// <summary>
        /// Место дополнительной работы.
        /// </summary>
        public string ExternalWorkAddress { get; set; } = "";
        [Required]
        /// <summary>
        /// Комментарий.
        /// </summary>
        public string Comment { get; set; } = "";
        [Required]
        /// <summary>
        /// Предприятие.
        /// </summary>
        public string Company { get; set; } = "";
        /// <summary>
        /// Курсы.
        /// </summary>
        public List<Course> Courses { get; set; }
        public List<Competition> Competitions { get; set; }
        public List<ScientificWork> ScientificWorks { get; set; }

        public virtual TeachersCategory TeachersCategory { get; set; }
        public virtual Department Department { get; set; }
    }
}
