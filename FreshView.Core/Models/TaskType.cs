using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class TaskType
    {
        public TaskType()
        {
            PartnersTask = new HashSet<PartnersTask>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PartnersTask> PartnersTask { get; set; }
    }
}
