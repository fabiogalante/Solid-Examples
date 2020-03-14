using System.Collections.Generic;

namespace Dip
{
    // low-level class
    public class EmployeeManager
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> Employees => _employees;
    }
}
