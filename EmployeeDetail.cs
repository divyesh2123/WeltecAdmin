using System;
using System.Collections.Generic;

namespace WeltecAdmin
{
    public partial class EmployeeDetail
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public string EmpCity { get; set; } = null!;
        public int EmpSalary { get; set; }
    }
}
