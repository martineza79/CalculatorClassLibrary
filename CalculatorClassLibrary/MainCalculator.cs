using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    //Reference using https://www.youtube.com/watch?v=8YFZBNFm0OM&t=1578s
    public class MainCalculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Multiply(int num1, int num2)
        {
            // failed test: int result = num1 + num2;
            int result = num1 * num2;
            return result;
        }
    }
}
