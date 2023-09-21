using LivingDoc.SpecFlowPlugin;
using MyApplication;
using NUnit.Framework;
using SpecFlowProject1.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        Calculator calc = null;
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
            output = CalculatorHooks.calc.AddNumber(num1, num2);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, output);
        }

        //Substract
        [Given(@"I have give the values below")]
        public void GivenIHaveGiveTheValuesBelow(Table table)
        {
            foreach (var row in table.Rows)
            {
                num1 = Convert.ToInt32(row["num1"]);
                num2 = Convert.ToInt32(row["num2"]);
            }
        }

        [When(@"I call the SubstractNumber method")]
        public void WhenICallTheSubstractNumberMethod()
        {
            output = CalculatorHooks.calc.SubtractNumber(num1, num2);
        }

        [Then(@"It should result (.*)")]
        public void ThenItShouldResult(int expected)
        {
            Assert.AreEqual(expected, output);
        }

        //Divide Method
        [Given(@"I have give (.*) and (.*)")]
        public void GivenIHaveGiveAnd(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        [When(@"I call the Divide method")]
        public void WhenICallTheDivideMethod()
        {
            output = CalculatorHooks.calc.Divide(num1, num2);
        }

        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(int expected)
        {
            Assert.AreEqual(expected, output);
        }

    }
}
