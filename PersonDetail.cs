using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class PersonDetail
    {
        public string? PersonId { get; set; }
        public string? Address { get; set; }

        public virtual Person? Person { get; set; }
    }
}
