using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class Emp
    {
        public int Id { get; set; }
        public string? Ename { get; set; }
        public string? Address1 { get; set; }
        public int? DeptId { get; set; }

        public virtual Dept? Dept { get; set; }
    }
}
