﻿using System.Collections.Generic;

namespace Ocp
{
    public class SalaryCalculator
    {
        //private readonly IEnumerable<DeveloperReport> _developer;

        //public SalaryCalculator(IEnumerable<DeveloperReport> developer)
        //{
        //    _developer = developer;
        //}


        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }


        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;


            //foreach (var developerReport in _developer)
            //{
            //    if (developerReport.Level == "Senior developer")
            //    {
            //        totalSalaries += developerReport.HourlyRate * developerReport.WorkingHours * 1.2;
            //    }
            //    else
            //    {
            //        totalSalaries += developerReport.HourlyRate * developerReport.WorkingHours;
            //    }

            //}

            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }



        /*
        So, all of this is working great, but now our boss comes to our office and says that we need a 
        different calculation for the senior and junior developers. The senior developers should have a bonus of 20% on a salary.
           
        Of course, to satisfy this requirement, we are going to modify our CalculateTotalSalaries 
        method like this:

        ==================================

        Even though this solution is going to give us the correct result, this is not an optimal 
        solution.
           
        Why is that?
           
        Mainly, because we had to modify our existing class behavior which worked perfectly. 
        Another thing is that if our boss comes again and ask us to modify calculation 
        for the junior dev’s as well, we would have to change our class again. 
        This is totally against of what OCP stands for.
         */



        /*
        This looks so much better because we won’t have to change any of our 
        current classes if our boss comes with another request about the intern
        payment calculation or any other as well.

        All we have to do now is to add another class with its own calculation logic. 
        So basically, our SalaryCalculator class is now closed for modification and 
        opened for an extension, which is exactly what OCP states.

        */
    }
}
