using System.Collections.Generic;

namespace Ocp
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developer;

        public SalaryCalculator(IEnumerable<DeveloperReport> developer)
        {
            _developer = developer;
        }


        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;


            foreach (var developerReport in _developer)
            {
                totalSalaries += developerReport.HourlyRate * developerReport.WorkingHours;
            }

            return totalSalaries;
        }
    }
}
