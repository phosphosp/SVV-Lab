using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private string _result;
        private Exception _caughtException;
        private Calculator _calculator;

        public UsingCalculatorAvailabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            try
            {
                _result = _calculator.MTBF(p0, p1).ToString();
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            try
            {
                _result = _calculator.Availability(p0, p1).ToString();
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(string p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"an ArgumentException should be thrown 1")]
        public void ThenAnArgumentExceptionShouldBeThrown()
        {
            Assert.That(_caughtException, Is.TypeOf<ArgumentException>());
        }
    }
}
