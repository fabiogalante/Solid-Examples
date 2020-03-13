using System.Collections.Generic;
using System.Linq;

namespace OcpOtherExample
{
    public class MonitorFilterOcp : IFilter<ComputerMonitor>
    {
      
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(specification.IsSatisfied).ToList();
        }
    }
}
