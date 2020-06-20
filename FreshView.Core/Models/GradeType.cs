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
    ///  Тип оценки.
    /// </summary>
    public class GradeType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /// <summary>
        /// Тип.
        /// </summary>
        public string Name { get; set; }
        // TODO: Заполнить таблицу значениями: Кейс ВУЗа, Кейс внешний, Кейс преподавателя, КП
        /// <summary>
        /// Описание.
        /// </summary>
        public string Decription { get; set; }
        /// <summary>
        /// Отзыв.
        /// </summary>
        public string Review { get; set; }
    }
}
