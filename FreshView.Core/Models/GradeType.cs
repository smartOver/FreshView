﻿using System;
using System.Collections.Generic;
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
        public Guid Id { get; set; }
        /// <summary>
        /// Тип.
        /// </summary>
        public string Name { get; set; }
        // TODO: Заполнить таблицу значениями
    }
}
