using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDefectDensityStepDefinitions
    {
        private double _result;
        private Exception _caughtException;
        private Calculator _calculator;

        public UsingCalculatorDefectDensityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press dd")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDd(int p0, int p1)
        {
            try
            {
                _result = _calculator.DefectDensity(p0, p1);
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [Then(@"the defect density result should be (.*)")]
        public void ThenTheDefectDensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press ssi")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressSsi(int p0, int p1, int p2)
        {
            try
            {
                _result = _calculator.SSI(p0, p1, p2);
            }
            catch (Exception e)
            {
                _caughtException = e;
            }
        }

        [Then(@"the SSI result should be (.*)")]
        public void ThenTheSSIResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"an ArgumentException should be thrown 4")]
        public void ThenAnArgumentExceptionShouldBeThrown()
        {
            Assert.That(_caughtException, Is.TypeOf<ArgumentException>());
        }
    }
}
