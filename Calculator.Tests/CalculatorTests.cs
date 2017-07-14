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


    }
}
