using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCalculator
{
    // Following the "RED", "GREEN", "RAFACTOR" aproach of TDD
    public class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
    }
}
