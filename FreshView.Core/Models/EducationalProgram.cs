using System;
using System.Collections.Generic;
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
        public Guid Id { get; set; }
        /// <summary>
        /// Код направления.
        /// </summary>
        public string CourcesCode { get; set; }
        /// <summary>
        /// Название программы.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание программы.
        /// </summary>
        public string Descriptions { get; set; }
        /// <summary>
        /// Ссылка на описание стандарта.
        /// </summary>
        public string StandsrtsDescription { get; set; }
        // TODO: Список специальностей.
        /// <summary>
        /// Индикатор состояния.
        /// </summary>
        public int StatusIdicator { get; set; }
    }
}
