using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
   
   public class CalculatorTests
    {

       

        [Fact]
        public void WhenAddingTwoNumbersThenReturnsZero()
        {
            //var sut = new Calculator();
            //int result = sut.Add(1, 1);

            //Assert.Equal(0, result);
            



        }
     
        public void WhenPassTomanConvertItToUSD()
        {
            int result = sut.convertToUSD("100");


        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            ChromeDriver driver = new ChromeDriver(options);
        }
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

    }
}
