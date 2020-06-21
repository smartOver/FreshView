using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Competence
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
