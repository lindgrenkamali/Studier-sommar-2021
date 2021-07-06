using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class CalculatorLibUnitTests
    {

        [Fact]
        public void TestAdding3And3()
        {
            //arrange

            double a = 3;
            double b = 3;
            double expected = 6;

            var calc = new Calculator();

            //act
            double actual = calc.Add(a, b);

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestAdding5And7()
        {
            //arrange

            double a = 5;
            double b = 7;
            double expected = 13;

            var calc = new Calculator();

            //act
            double actual = calc.Add(a, b);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
