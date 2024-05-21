using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class OrdersFk
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int? PersonId { get; set; }

        public virtual PersonsFk? Person { get; set; }
    }
}
