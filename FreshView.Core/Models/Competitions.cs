using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class Competitions
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CompetitionDate { get; set; }
        public string City { get; set; }
        public string Subject { get; set; }
    }
}
