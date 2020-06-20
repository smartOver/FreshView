using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    /// <summary>
    /// Научная работа.
    /// </summary>
    public class ScientificWork
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
        /// Дата публикации.
        /// </summary>
        public DateTime PublicationDate { get; set; }
        /// <summary>
        /// Тематика.
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Направление.
        /// </summary>
        public string Course { get; set; }
#warning Это должна быть ссылка на направление как модель данных?
        /// <summary>
        /// Ключевые слова.
        /// </summary>
        public string Keywords { get; set; }
#warning Может сделать как отдельную таблицу + кросстаблица для удобства поиска? На будущее.
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Аннотация.
        /// </summary>
        public string Annotation { get; set; }
    }
}
