using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Company
    {
        public Company()
        {
            PartnersTask = new HashSet<PartnersTask>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<PartnersTask> PartnersTask { get; set; }
    }
}
