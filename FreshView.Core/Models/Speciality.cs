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
    /// Специальность.
    /// </summary>
    public class Speciality
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
        /// Обучающая программа.
        /// </summary>
        public Guid EducationalProgramId { get; set; }
        [Required]
        /// <summary>
        /// Число вакансий на hh.ru.
        /// </summary>
        public int VacansiesCountHH { get; set; } = 100;
        [Required]
        /// <summary>
        /// Средняя зарплата.
        /// </summary>
        public decimal AverageSalary { get; set; } = 100m;
        [Required]
        /// <summary>
        /// Количество вакансий по региону.
        /// </summary>
        public int VacansiesCountInRegion { get; set; } = 50;
        [Required]
        /// <summary>
        /// Средняя зарплата по региону.
        /// </summary>
        public int AverageSalaryInRegion { get; set; } = 50;

        public virtual EducationalProgram EducationalProgram { get; set; }
    }
}
