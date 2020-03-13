using System;
using System.Collections.Generic;

namespace OcpOtherExample
{
    /*
    Let’s imagine for a moment that we have a task to write an application which gives
    us all the required information about computer monitors in our shop, based on 
    different criteria. We will introduce only two criteria here, the type of monitors 
    and the screen size.

    */


    class Program
    {
        static void Main(string[] args)
        {
            //var monitors = new List<ComputerMonitor>
            //{
            //    new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
            //    new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
            //    new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
            //    new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
            //    new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
            //};

            //var filter = new MonitorFilter();

            //var lcdMonitors = filter.FilterByType(monitors, MonitorType.LCD);

            //Console.WriteLine("All LCD monitors");

            //foreach (var monitor in lcdMonitors)
            //{
            //    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            //}


            var monitors = new List<ComputerMonitor>
            {
                new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
                new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
            };

            var filter = new MonitorFilterOcp();

            var lcdMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));

            Console.WriteLine("All LCD monitors");

            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }

            Console.WriteLine("All WideScreen Monitors");

            var wideScreenMonitors = filter.Filter(monitors, new ScreenSpecification(Screen.WideScreen));
            foreach (var monitor in wideScreenMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }

        }
    }
}


/*

 Why Should We Implement the Open Closed Principle
By implementing the OCP we are lowering the chance of producing bugs in our project.

For example, if we have a fully working and already tested class in production, by extending it instead of changing it, 
we would definitely have a lesser impact on the rest of the system.

Therefore, we introduce another class to extend the behavior of the main class thus avoid the existing 
functionality modification that other classes may rely upon.

Another benefit is that we only have to test and deploy the new features, which wouldn’t be the case if we had
to change existing functionality. Furthermore, if we decide that we don’t need this feature anymore (sometime in the future), 
all we have to do is to revert just newly implemented change and that’s it.

Conclusion
We’ve seen how the OCP can help us create better and more maintainable code. But, as with everything else, 
we should be cautious when implementing this principle.

Sometimes it’s just impossible to extend our class and all we are left to do is to modify existing functionality. 
We shouldn’t be afraid to do it, it is quite normal, but at least we should try to make those changes as discrete as they can be.

So, we should develop our applications with the OCP in mind and we should strive to write extendable code as much as 
we can because it leads to the maintainable, scalable and testable codebase.

*/
