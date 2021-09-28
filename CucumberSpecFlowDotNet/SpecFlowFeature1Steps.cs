using FluentAssertions;
using TechTalk.SpecFlow;

namespace CucumberSpecFlowDotNet
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private int num1;
        private int num2;
        private int sum;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            num1 = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            num2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = num1 + num2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            sum.Should().Be(p0);
        }
    }
}
