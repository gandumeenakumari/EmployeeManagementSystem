using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.DataAccessLayer.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string EmployeeDept { get; set; } = null!;
        public string EmployeeSalary { get; set; } = null!;
    }
}
