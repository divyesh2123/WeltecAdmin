using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class Dept
    {
        public Dept()
        {
            Emps = new HashSet<Emp>();
        }

        public int Id { get; set; }
        public string? Dname { get; set; }

        public virtual ICollection<Emp> Emps { get; set; }
    }
}
