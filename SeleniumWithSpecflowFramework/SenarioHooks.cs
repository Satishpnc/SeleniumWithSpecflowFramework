using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumWithSpecflowFramework.DriverBase;
using SeleniumWithSpecflowFramework.Steps;

namespace SeleniumWithSpecflowFramework
{
    [Binding]
    public sealed class SenarioHooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.quitWebDriver(HorseRacingBetSteps.driver);
        }
    }
}
