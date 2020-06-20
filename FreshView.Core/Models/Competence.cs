using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Компетенция.
    /// </summary>
    public class Competence
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Шифр.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
    }
}
