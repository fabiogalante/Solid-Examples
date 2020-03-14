using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    public class EmployeeStatistics2
    {
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics2(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() =>
            _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
