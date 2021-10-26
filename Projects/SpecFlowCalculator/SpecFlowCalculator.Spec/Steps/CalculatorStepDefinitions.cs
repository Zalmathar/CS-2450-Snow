using TechTalk.SpecFlow;
using FluentAssertions;
using System;

namespace SpecFlowCalculator.Spec.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(float number)
        {
            Calculator c = new Calculator();
            c.FirstNumber = number;
            _scenarioContext.Add("_calculator", c);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(float number)
        {
            _scenarioContext.Get<Calculator>("_calculator").SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _scenarioContext.Add("Result", _scenarioContext.Get<Calculator>("_calculator").Add());
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _scenarioContext.Add("Result", _scenarioContext.Get<Calculator>("_calculator").Subtract());
        }

        [When("the two numbers are multiplied")]
        public void WhenTwoNumbersAreMultiplied()
        {
            _scenarioContext.Add("Result", _scenarioContext.Get<Calculator>("_calculator").Multiply());
        }

        [When("the two numbers are divided")]
        public void WhenTwoNumbersAreDivided()
        {
            try
            {
                _scenarioContext.Add("Result", _scenarioContext["_calculator"].As<Calculator>().Divide());
            }
            catch (Exception e)
            {
                _scenarioContext.Add("Exception", e);
            }
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void OperationPlusIsDoneToTheNumber(float number)
        {
            Calculator c = _scenarioContext.Get<Calculator>("_calculator");
            if (_scenarioContext.ContainsKey("Result"))
            {
                // First number needs to be changed as we have already run this part before, therefore result is the number we are modifying
                float res = _scenarioContext.Get<float>("Result");
                c.FirstNumber = res;
                c.SecondNumber = number;
                _scenarioContext.Remove("Result");
                _scenarioContext.Add("Result", c.Add());
            }
            else
            {
                c.SecondNumber = number;
                _scenarioContext.Add("Result", c.Add());
            }
        }

        [When(@"operation / is done to the number (.*)")]
        public void WhenOperationDivideIsDoneToTheNumber(float number)
        {
            Calculator c = _scenarioContext.Get<Calculator>("_calculator");
            if (_scenarioContext.ContainsKey("Result"))
            {
                // First number needs to be changed as we have already run this part before, therefore result is the number we are modifying
                float res = _scenarioContext.Get<float>("Result");
                c.FirstNumber = res;
                c.SecondNumber = number;
                _scenarioContext.Remove("Result");
                _scenarioContext.Add("Result", c.Divide());
            }
            else
            {
                c.SecondNumber = number;
                _scenarioContext.Add("Result", c.Divide());
            }
        }

        [When(@"operation - is done to the number (.*)")]
        public void WhenOperation_IsDoneToTheNumber(float number)
        {
            Calculator c = _scenarioContext.Get<Calculator>("_calculator");
            if (_scenarioContext.ContainsKey("Result"))
            {
                // First number needs to be changed as we have already run this part before, therefore result is the number we are modifying
                float res = _scenarioContext.Get<float>("Result");
                c.FirstNumber = res;
                c.SecondNumber = number;
                _scenarioContext.Remove("Result");
                _scenarioContext.Add("Result", c.Subtract());
            }
            else
            {
                c.SecondNumber = number;
                _scenarioContext.Add("Result", c.Subtract());
            }
        }

        [When(@"operation % is done to the number (.*)")]
        public void WhenOperationModIsDoneToTheNumber(float number)
        {
            Calculator c = _scenarioContext.Get<Calculator>("_calculator");
            if (_scenarioContext.ContainsKey("Result"))
            {
                // First number needs to be changed as we have already run this part before, therefore result is the number we are modifying
                float res = _scenarioContext.Get<float>("Result");
                c.FirstNumber = res;
                c.SecondNumber = number;
                _scenarioContext.Remove("Result");
                _scenarioContext.Add("Result", c.Mod());
            }
            else
            {
                c.SecondNumber = number;
                _scenarioContext.Add("Result", c.Mod());
            }
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(float result)
        {
            _scenarioContext.Get<float>("Result").Should().BeApproximately(result, 0.0001F);
            _scenarioContext.ContainsKey("Exception").Should().BeFalse();
        }

        [Then("the user is presented with an error message")]
        public void TheUserIsPresentedWithAnErrorMessage()
        {
            _scenarioContext.ContainsKey("Result").Should().BeFalse();
            _scenarioContext.ContainsKey("Exception").Should().BeTrue();
        }

        public []<mytpe
    }
}
