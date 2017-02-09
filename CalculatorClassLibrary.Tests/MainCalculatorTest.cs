using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorClassLibrary;

namespace CalculatorClassLibrary.Tests
{
    [TestClass]
    public class MainCalculatorTest
    {
        [TestMethod]
        public void Add_AddTwoNumbers_ShouldReturnSumOfTwoNumbers()
        {
            //Arrange
            MainCalculator calculate = new MainCalculator();

            //Act
            int result = calculate.Add(5, 4);

            //Assert
            Assert.AreEqual(9, result); //(expected value, "Act" object/variable)
        }

        [TestMethod]
        public void Multiply_MultiplyTwoNumbers_ShouldReturnProductOfTwoNumbers()
        {
            //Arrange
            MainCalculator calculate = new MainCalculator();

            //Act
            int result = calculate.Multiply(5, 4);

            //Assert
            Assert.AreEqual(20, result); //(expected value, "Act" object/variable)
        }

    }
}
