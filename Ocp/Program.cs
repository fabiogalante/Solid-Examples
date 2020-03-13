using System;
using System.Collections.Generic;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var devReports = new List<DeveloperReport>
            var devCalculations = new List<BaseSalaryCalculator>
            {
                //new DeveloperReport
                new SeniorDevSalaryCalculator(new DeveloperReport{ Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160}),
            //new DeveloperReport
                new JuniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150}),
                //new DeveloperReport
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180})

            };

            //var calculator = new SalaryCalculator(devReports);
            var calculator = new SalaryCalculator(devCalculations);

            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");


        }
    }
}
