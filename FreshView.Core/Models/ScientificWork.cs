using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class ScientificWork
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Subject { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Annotation { get; set; }
        public Guid? Course { get; set; }

        public virtual Course CourseNavigation { get; set; }
    }
}
