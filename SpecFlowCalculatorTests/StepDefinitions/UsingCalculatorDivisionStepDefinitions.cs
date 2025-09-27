using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorDivisionStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }


        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositive_Infinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
