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
            var monitors = new List<ComputerMonitor>
            {
                new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
                new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
            };

            var filter = new MonitorFilter();

            var lcdMonitors = filter.FilterByType(monitors, MonitorType.LCD);

            Console.WriteLine("All LCD monitors");

            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }



        }
    }
}
