using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class EmployeeContact
    {
        public int EmpId { get; set; }
        public string MobileNo { get; set; } = null!;

        public virtual EmployeeDetail Emp { get; set; } = null!;
    }
}
