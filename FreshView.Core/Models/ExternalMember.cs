using System;
using System.Collections.Generic;

namespace FreshView.Core.Models
{
    public partial class ExternalMember
    {
        public Guid Id { get; set; }
        public string Lastname { get; set; }
        public string Secondname { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public bool? IsInTopHundred { get; set; }
    }
}
