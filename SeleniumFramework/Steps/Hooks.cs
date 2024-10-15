using OpenQA.Selenium;
using SeleniumFramework.Drivers;
using TechTalk.SpecFlow;


namespace SeleniumFramework.Steps
{
    [Binding]
    public class Hooks(ScenarioContext scenarioContext)
    {
        private readonly ScenarioContext scenarioContext = scenarioContext;
        private IWebDriver? driver;
        [BeforeScenario]
        public void BeforeScenario()
        {

            driver = WebDriveFactory.CreateWebDriver();// usa la fabrica para crear el webdriver
            this.scenarioContext["WebDriver"] = driver;//almacena el webdriver en el contexto del escenario

        }
        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit(); // Cierra Navegador
                driver.Dispose(); // Libera los recursos
            }
           


        }
    }
}
    
