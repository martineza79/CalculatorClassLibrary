using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCalculator;

namespace TDDCalculatorMSTest
{
    [TestClass]
    public class CalculatorTest
    {
        ICalculator calculate;
        [TestInitialize]
        public void TestSetUp()
        {
            calculate = new Calculator();
        }

        [TestMethod]
        public void Add_AddTwoNumbers_ShouldReturnSumOfTwoNumbers()
        {
            int result = calculate.Add(8, 9); //inserted this line after initial test failed
            Assert.AreEqual(17, result); //inserted this line after initial test failed
        }
    }
}
