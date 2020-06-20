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
        public Guid Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Обучающая программа.
        /// </summary>
        public Guid EducationalProgramId { get; set; }
        /// <summary>
        /// Число вакансий на hh.ru.
        /// </summary>
        public int VacansiesCountHH { get; set; }
        /// <summary>
        /// Средняя зарплата.
        /// </summary>
        public decimal AverageSalary { get; set; }
        /// <summary>
        /// Количество вакансий по региону.
        /// </summary>
        public int VacansiesCountInRegion { get; set; }
        /// <summary>
        /// Средняя зарплата по региону.
        /// </summary>
        public int AverageSalaryInRegion { get; set; }

        public virtual EducationalProgram EducationalProgram { get; set; }
    }
}
