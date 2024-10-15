using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Pages;
using TechTalk.SpecFlow;

namespace SeleniumFramework.Steps
{
    [Binding]
    public class GoogleSearchSteps
    {
        private readonly ScenarioContext scenarioContex;   
       private readonly GooglePage googlePage;
        private readonly IWebDriver driver;


       
        public GoogleSearchSteps(ScenarioContext scenarioContex)
        {
            this.scenarioContex = scenarioContex;
            driver = (IWebDriver)this.scenarioContex["WebDriver"];// obtiene el webdriver del contexto
            googlePage = new GooglePage(driver);
            
        }

        [Given(@"I am on the google search page")]
        public void GivenIAmOnTheGoogleSearchPage()
        {
            googlePage.NavigateToGoogle();

        }
        [When(@"I enter ""(.*)""")] //I enter "Java" 
        public void WhenEnter(string searchText)
        {
            googlePage.EnterSearchText(searchText);

        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            
            googlePage.ClickSearchButton();
        }


        [Then(@"The search results should contain the term Java")]

        public void ThenIShouldSeeSearchResults()
        {
            Assert.IsTrue(googlePage.GetContainSubString());
        }

    }
}
////Scenario: Search for a term in Google
//Given I am on the google search page
//  when I enter "Java"
//  And I click the search button
//  Then The search results should  contain the term Java ~