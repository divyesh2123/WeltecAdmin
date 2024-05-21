using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class PersonsFk
    {
        public PersonsFk()
        {
            OrdersFks = new HashSet<OrdersFk>();
        }

        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string? FirstName { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<OrdersFk> OrdersFks { get; set; }
    }
}
