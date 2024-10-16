using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumFramework.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        //Metodo navegar a cualquier sitio

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);

        }

        //cerrar el navegador

        public void CloseBroser()
        {
            driver.Quit();
        }
        // Para buscar un elemento html

        public IWebElement FindElement(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        //Para realizar click en elemento (Button,input)


        public void ClickElement(By locator) 
        {
            FindElement(locator).Click();
        }

        //Escribir en un elemento
        public void Write(By locator, string textToWrite) 

        {
           //var element = FindElement(locator);

            IWebElement element = FindElement(locator);
            element.Clear();
            element.SendKeys(textToWrite);

            
        }
        //Para elementos que son visibles por condicio
        public bool ElementIsDisplayed(By locator)
        {
            return FindElement(locator).Displayed;

        }
        //
        public string GetTextFromElement(By locator)
        {
            return FindElement(locator).Text;

        }
        //Select
        public void  selectFromDropdownByValue(By locator,string value)
        {
            var dropdown = new SelectElement(FindElement(locator));

            dropdown.SelectByValue(value);


        }

    }
}
