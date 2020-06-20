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
    /// Курс.
    /// </summary>
    public class Course
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
        /// Описание.
        /// </summary>
        public string Description { get; set; } = "";
        [Required]
        /// <summary>
        /// Уровень увеличения компетенции.
        /// </summary>
        public double CompetencyLevelIncrease { get; set; } = 0.0;
        [Required]
        /// <summary>
        /// Наличие внешних участников.
        /// </summary>
        public bool IsExternalMembers { get; set; } = false;
        [Required]
        [Range(0, 10)]
        /// <summary>
        /// Индикатор состояния [0..10]
        /// </summary>
        public int StatusIndicator { get; set; } = 0;
        [Required]
        /// <summary>
        /// Тип курса.
        /// </summary>
        public Guid CourseTypeId { get; set; }
        [Required]
        /// <summary>
        /// Специальность.
        /// </summary>
        public Guid SpecialityId { get; set; }
        [Required]
        /// <summary>
        /// Преподаватели.
        /// </summary>
        public List<Teacher> Teachers { get; set; }
        /// <summary>
        /// Группы.
        /// </summary>
        public List<StudyGroup> StudyGroups { get; set; }
        /// <summary>
        /// Компетиции.
        /// </summary>
        public List<Competence> Competencies { get; set; }

        public virtual CourseType CourseType { get; set; }
        public virtual Speciality Speciality { get; set; }
        /// <summary>
        /// Образовательная программа.
        /// </summary>
        public Guid EducationalProgramId { get; set; }
        public virtual EducationalProgram EducationalProgram { get; set; }
        public Course()
        {
            Teachers = new List<Teacher>();
            StudyGroups = new List<StudyGroup>();
            Competencies = new List<Competence>();
        }
    }
}
