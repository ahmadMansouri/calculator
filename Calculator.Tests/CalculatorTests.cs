using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
   
   public class CalculatorTests
    {


        [Fact]
        public void WhenAddingTwoNumbersThenReturnsZero()
        {
            var calculator = new Calculator();
            int result = calculator.Add(1, 1);

            Assert.Equal(0, result);            

        }

        [Fact]
        public void WhenMinusTwoNumbersThenReturnsZero()
        {
            var calculator = new Calculator();
            var result = calculator.Minus(2, 1);
            Assert.Equal(1, result);
        }


    }
}
