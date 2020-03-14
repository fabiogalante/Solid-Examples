using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    public class EmployeeManager2 :  IEmployeeSearchable
    {
        private readonly List<Employee> _employees;

        public EmployeeManager2()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
        {
            return _employees.Where(emp => emp.Gender == gender && emp.Position == position);
        }
    }
}
