using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class PartnersTask
    {
        public Guid Id { get; set; }
        public Guid? Course { get; set; }
        public Guid? Company { get; set; }
        public Guid? TaskType { get; set; }

        public virtual Company CompanyNavigation { get; set; }
        public virtual TaskType TaskTypeNavigation { get; set; }
    }
}
