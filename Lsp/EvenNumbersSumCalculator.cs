using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp
{
    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers) 
            : base(numbers)
        {
        }

        public new int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }
}
