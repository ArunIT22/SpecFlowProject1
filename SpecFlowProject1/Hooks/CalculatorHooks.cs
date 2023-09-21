using MyApplication;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class CalculatorHooks
    {
        public static Calculator calc = null;

        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    calc = new Calculator();
        //}

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    calc = null;
        //}
    }
}