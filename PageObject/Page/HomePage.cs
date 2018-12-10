using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AirlinesTestingApp.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private const string url = "https://ibe.belavia.by";
        By addInput = By.ClassName("ui-paxinput");
        By addPassenger = By.ClassName("plus");
        By plusBaby = By.ClassName("plus");
        By errorsMessages = By.ClassName("field-validation-error");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.FindElement(addInput).Click();
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void AddPassengers(){
            driver.FindElements(addPassenger)[0].Click();
        }

        public void PlusBaby(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                driver.FindElements(plusBaby)[1].Click();
            }
        }

        public IWebElement GetErrorsMessages()
        {
            return driver.FindElement(errorsMessages);
        }
    }
}
