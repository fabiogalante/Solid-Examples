using System.Linq;

namespace Lsp
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;

        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        //public int Calculate()
        //{
        //    return _numbers.Sum();
        //}

        public virtual int Calculate()
        {
            return _numbers.Sum();
        }
    }
}
