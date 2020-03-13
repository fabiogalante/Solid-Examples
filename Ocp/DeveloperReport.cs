using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{

    /*

    Salary Calculator Example
    Let’s imagine that we have a task where we need to calculate the total cost of all 
    the developer salaries in a single company.Of course, we are going to make 
    this example simple and focus on the required topic.

    */


    public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
