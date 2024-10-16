﻿using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.IndexedDB;
namespace SeleniumFramework.Pages
{
    public class GooglePage
    {

        private readonly IWebDriver driver;
        private readonly By searchBox = By.Name("q");
        private readonly By searchButton = By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']");
        private readonly By elementosH3 = By.CssSelector("h3.LC20lb.MBeuO.DKV0Md");
        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;

        }
        // Metodo para navegar pagina google

        public void NavigateToGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        public void EnterSearchText(string searchText)
        {
            //driver.FindElement(By.Id("'APjFqb")).SendKeys("java");
            driver.FindElement(searchBox).SendKeys(searchText);
            driver.FindElement(searchBox).SendKeys(Keys.Tab);
        }

        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }
   
    public bool GetContainSubString()


    {
            Console.WriteLine(driver.FindElements(elementosH3).FirstOrDefault()?.Text);
            return driver.FindElements(elementosH3).FirstOrDefault()?.Text.Contains("Java") ?? false;

    }
    }
}
