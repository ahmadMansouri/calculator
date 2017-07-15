using System;
using TechTalk.SpecFlow;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TestTools.UnitTesting;
//using Microsoft.VisualStudio.TestTools.UnitTesting
/*
using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
*/
namespace Unit_Test_Projec02
{
    [Binding]
    public class SpecFlowCalculatorSteps
    {
        int firstNumber, secondNumber, result;

        //public object Assert { get; private set; }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
           firstNumber = p0 ;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            secondNumber=p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = firstNumber+ secondNumber;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
                        
              Assert.Equal(p0, result);
            //Assert.Equal(1,2);

        }
    }
}
