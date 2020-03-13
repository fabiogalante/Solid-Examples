using System.Collections.Generic;
using System.Linq;

namespace OcpOtherExample
{
    public class MonitorFilter
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type)
        {
            return monitors.Where(m => m.Type == type).ToList();
        }


        /*

        This is going to work just fine. But, after a couple of days, we receive a 
        request that our customers want to have the filter by Screen functionality as well.

        So this should be quite simple, shouldn’t it?

        Let’s just change the MonitorFilter class:

        */

        public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, Screen screen) =>
            monitors.Where(m => m.Screen == screen).ToList();


        /*
         
        Even though this is going to give us the correct result, we have a problem 
        because we have to modify our existing class. And what if we receive another 
        request to filter all the monitors by type and screen together? We all see 
        where this lead us, towards breaking the OCP. We are not extending our MonitorFilter 
        class but modifying it.

        So, in order to avoid existing class modification, let’s try another approach.


         */
    }
}
