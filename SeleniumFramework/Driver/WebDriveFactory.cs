﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Drivers
{
    public class WebDriveFactory
    {
        /// <summary>
        /// maximiza pantalla mercado libre pantalla prueba  selenium
        /// </summary>
        /// <returns></returns>
        public static IWebDriver CreateWebDriver()
        {

            var options = new ChromeOptions();
            options.AddArguments("--Start-maximized");
            return new ChromeDriver(options);




        }

       
    }
    
}
