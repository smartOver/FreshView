using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Тип курса.
    /// </summary>
    public class CourseType
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Тип.
        /// </summary>
        public string Name { get; set; }
        // TODO: Заполнить таблицу значениями: общеобразовательный, специальный
    }
}
