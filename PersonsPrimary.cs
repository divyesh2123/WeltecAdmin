using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class PersonsPrimary
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string? FirstName { get; set; }
        public int? Age { get; set; }
    }
}
