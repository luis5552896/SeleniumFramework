using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Drivers
{
    public class WebDriveFactory
    {
        public static IWebDriver CreateWebDriver()
        {

            var options = new ChromeOptions();
            options.AddArguments("--Start-maximized");
            return new ChromeDriver(options);



        }

       
    }
    
}
