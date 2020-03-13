namespace OcpOtherExample
{
    public class ScreenSpecification : ISpecification<ComputerMonitor>
    {
        private readonly Screen _screen;

        public ScreenSpecification(Screen screen)
        {
            _screen = screen;
        }

        public bool IsSatisfied(ComputerMonitor item)
        {
            return item.Screen == _screen;
        }
    }
}
