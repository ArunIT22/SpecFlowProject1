using LivingDoc.SpecFlowPlugin;
using MyApplication;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        Calculator calc = new Calculator();
        int num1, num2, output;

        [Given(@"First number is (.*)")]
        public void GivenFirstNumberIs(int n1)
        {
            num1 = n1;
        }

        [Given(@"then second number is (.*)")]
        public void GivenThenSecondNumberis(int n2)
        {
            num2 = n2;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            output = calc.AddNumber(num1, num2);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
           Assert.AreEqual(expected, output);
        }
    }
}
