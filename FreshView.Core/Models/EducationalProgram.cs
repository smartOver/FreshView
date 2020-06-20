﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Обучающая программа.
    /// </summary>
    public class EducationalProgram
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        /// <summary>
        /// Код направления.
        /// </summary>
        public string ProgramsCode { get; set; } = "";
        [Required]
        /// <summary>
        /// Название программы.
        /// </summary>
        public string Name { get; set; }
        [Required]
        /// <summary>
        /// Описание программы.
        /// </summary>
        public string Description { get; set; } = "";
        [Required]
        /// <summary>
        /// Ссылка на описание стандарта.
        /// </summary>
        public string StandartsDescription { get; set; } = "";
        /// <summary>
        /// Список курсов.
        /// </summary>
        public List<Course> Courses { get; set; }
        [Required]
        /// <summary>
        /// Индикатор состояния.
        /// </summary>
        public int StatusIdicator { get; set; } = 0;
        public EducationalProgram()
        {
            Courses = new List<Course>();
        }
    }
}
