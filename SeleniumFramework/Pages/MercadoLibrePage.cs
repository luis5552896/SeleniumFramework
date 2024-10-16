using OpenQA.Selenium;

namespace SeleniumFramework.Pages
{
    public  class MercadoLibrePage:BasePage
    {
        private readonly By searchBox = By.Name("as-word");
        private readonly By searchButton = By.CssSelector("button.nav-search-btn");
        private readonly By thirdResult = By.CssSelector("//li¨[3]//h2/a");
        private readonly By addCartButton = By.CssSelector("button[id=':R2aqakck4um:'] span[class='andes-button__content']");
        private readonly By messageRegisterAccount = By.CssSelector(".center-card__title");
        // private readonly By addCartButton = By.Id(":R2aqakck4um:");

        public MercadoLibrePage(IWebDriver driver):base(driver)
        {
        }

public void NavigateToMercadoLibre()
        {
            NavigateTo("https://www.mercadolibre.cl/");
        }
       //metodo para escribir un texto

        public void EnterSearchCriterio(string criterio)
        {
            Write(searchBox, criterio);
        }

        public void ClickSearchButton()
        {
            ClickElement(searchButton);
        }
        public void PickThirdItem()
        {
            ClickElement(thirdResult);
        }
        public void AddToCard()
        {
            ClickElement(addCartButton);
        }

        public string GetMessageCreateAccount()
        {
            return GetTextFromElement(messageRegisterAccount);
        }
        
    }
}
    
