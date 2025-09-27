using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private double _result;
        private Exception _caughtException;
        private Calculator _calculator;

        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press fail")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFail(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.CurrentFailureIntensity(p0, p1, p2);
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press expfail")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressExpfail(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.AverageFailure(p0, p1, p2);
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [Then(@"the basic musa result should be (.*)")]
        public void ThenTheBasicMusaResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"an ArgumentException should be thrown 2")]
        public void ThenAnArgumentExceptionShouldBeThrown()
        {
            Assert.That(_caughtException, Is.TypeOf<ArgumentException>());
        }
    }
}
