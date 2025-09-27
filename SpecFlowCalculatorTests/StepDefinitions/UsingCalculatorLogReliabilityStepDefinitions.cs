using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorLogReliabilityStepDefinitions
    {
        private double _result;
        private Exception _caughtException;
        private Calculator _calculator;

        public UsingCalculatorLogReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press logfail")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressLogfail(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.LogCurrentFailureIntensity(p0, p1, p2);
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press logexpfail")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressLogexpfail(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.LogAverageFailure(p0, p1, p2);
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [Then(@"the log musa result should be (.*)")]
        public void ThenTheLogMusaResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"an ArgumentException should be thrown 3")]
        public void ThenAnArgumentExceptionShouldBeThrown()
        {
            Assert.That(_caughtException, Is.TypeOf<ArgumentException>());
        }

    }
}
