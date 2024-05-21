using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class Person
    {
        public string PersonId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? Company { get; set; }
    }
}
