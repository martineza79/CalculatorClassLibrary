using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorClassLibrary;

namespace CalculatorNUnitTest
{
    [TestFixture]   
    public class MainCalculatorNUnit
    {
        MainCalculator calculate;

        [OneTimeSetUp]
        public void TestSetup()
        {
            calculate = new MainCalculator();
        }

        [Test]
        public void Add_AddTwoNumbers_ShouldReturnSumOfTwoNumbers()
        {
            //Arrange
            //MainCalculator calculate = new MainCalculator(); lines 14 & 19 takes the place of this line

            //Act
            int result = calculate.Add(5, 4);

            //Assert
            Assert.That(result, Is.EqualTo(9)); //in NUnit, use .That("Act" object/variable, Is.EqualTo(expected result))
        }

        [Test]
        public void Multiply_MultiplyTwoNumbers_ShouldReturnProductOfTwoNumbers()
        {
            //Arrange
            //MainCalculator calculate = new MainCalculator(); Lines 14 & 19 takes the place of this line

            //Act
            int result = calculate.Multiply(5, 4);

            //Assert
            Assert.That(result, Is.EqualTo(20)); //(expected value, "Act" object/variable)
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            calculate = null;
        }
    }
}
