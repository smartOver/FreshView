using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Категория преподавателя.
    /// </summary>
    public class TeachersCategory
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        // TODO: Заполнить таблицу значениями: внутренний, внешний совместитель
    }
}
