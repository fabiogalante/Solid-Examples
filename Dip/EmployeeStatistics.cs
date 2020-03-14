using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeeStatistics(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public int CountFemaleManagers()
        {
            return _employeeManager.Employees.Count(emp =>
                emp.Gender == Gender.Female && emp.Position == Position.Manager);
        }
    }
}
